using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace COM_PortsReader;

internal class Localizer
{
    private static Dictionary<string, string> _translations = new();

    internal static void Initialize(CultureInfo cultureInfo)
    {
        var basePath = "LocalizationMessages";
        var cultureName = cultureInfo.Name;

        var filesToTry = new[]
        {
            $"{cultureName}.json",
            $"{cultureInfo.TwoLetterISOLanguageName}.json",
            "en-US.json"
        };

        foreach (var file in filesToTry)
        {
            var path = Path.Combine(basePath, file);
            if (!File.Exists(path)) continue;

            var json = File.ReadAllText(path);
            _translations = JsonSerializer.Deserialize<Dictionary<string, string>>(json);
            return;
        }

        throw new FileNotFoundException("No localization files found");
    }

    internal static string GetString(string key, params object[] args)
    {
        if (_translations.TryGetValue(key, out var value))
        {
            return args.Length > 0
                ? string.Format(value, args)
                : value;
        }
        return $"[{key}]";
    }
}
