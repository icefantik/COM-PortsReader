namespace COM_PortsReader.Commands;

internal class HelpCommand : ICommand
{
    public string Description => Localizer.GetString("Description command help");

    public void Execute(string[] args)
    {
        var commands = CommandHandler.GetCommands();
        foreach (var command in commands)
        {
            Console.WriteLine($"{command.Key} - {command.Value.Description}");
        }
    }
}
