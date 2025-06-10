using COM_PortsReader;
using System.Globalization;
using System.Text.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        var culture = new CultureInfo("en-US");
        CultureInfo.CurrentCulture = culture;
        CultureInfo.CurrentCulture = culture;

        Localizer.Initialize(culture);
        
        Console.WriteLine(Localizer.GetString("Welcome"));
        //Console.WriteLine(Localizer.GetString(""));
        Console.Read();

    }

    private static void InitializeCommands()
    {
        CommandHandler.RegisterCommand("list", new ListPortsCommand());
    }
}