using COM_PortsReader.Commands;

namespace COM_PortsReader;

internal class CommandHandler
{
    private static Dictionary<string, ICommand> commands = new Dictionary<string, ICommand>();

    public static Dictionary<string, ICommand> GetCommand() => commands;

    public static void RegisterCommand(string name, ICommand command)
    {
        commands[name.ToLower()] = command;
    }

    public static void Execute(string[] input)
    {
        if (input.Length == 0) return;

        var commandName = input[0].ToLower();
        if (commands.ContainsKey(commandName))
        {
            commands[commandName].Execute(input[1..]);
        }
        else
        {
            Console.WriteLine(Localizer.GetString("Unknown command"));
        }
    }
}
