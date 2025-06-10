using COM_PortsReader.Commands;
using System.Globalization;
using System.Text.Json;

namespace COM_PortsReader;

internal class Program
{
    private static bool isRunning = true;

    private static string enterString = "> ";

    private static void Main(string[] args)
    {
        var culture = new CultureInfo("en-US");
        CultureInfo.CurrentCulture = culture;
        CultureInfo.CurrentCulture = culture;

        Localizer.Initialize(culture);
        
        Console.WriteLine(Localizer.GetString("Welcome"));

        InitializeCommands();

        while (isRunning)
        {
            Console.Write(enterString);
            var input = Console.ReadLine()?.Trim().Split(' '); // taking command and parameters
            if (input![0] == "") break;
            CommandHandler.Execute(input!);
        }
    }

    private static void InitializeCommands()
    {
        CommandHandler.RegisterCommand("list", new ListPortsCommand());
        CommandHandler.RegisterCommand("help", new HelpCommand());

    }
}