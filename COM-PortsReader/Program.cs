using COM_PortsReader.Commands;
using System.Globalization;
using System.IO.Ports;

namespace COM_PortsReader;

internal class Program
{
    internal static SerialPort selectedPort;

    private static bool isRunning = true;

    private static string enterString = "> ";

    public static void QuitTheProgram() => isRunning = false;

    private static void Main(string[] args)
    {
        var culture = new CultureInfo("en-US");
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
        CommandHandler.RegisterCommand("help", new HelpCommand());
        CommandHandler.RegisterCommand("quit", new QuitCommand());
        CommandHandler.RegisterCommand("list", new ListPortsCommand());
        CommandHandler.RegisterCommand("select", new SelectPortCommand());
        CommandHandler.RegisterCommand("send", new SendDataCommand());
        CommandHandler.RegisterCommand("close", new ClosePortCommand());
        CommandHandler.RegisterCommand("open", new OpenPortCommand());
        CommandHandler.RegisterCommand("info", new PortInfoCommand());
        CommandHandler.RegisterCommand("output", new OutputDataCommand());
    }
}