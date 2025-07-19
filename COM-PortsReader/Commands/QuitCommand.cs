namespace COM_PortsReader.Commands;

internal class QuitCommand : ICommand
{
    public string Description => Localizer.GetString("Description command quit");

    public void Execute(string[] args)
    {
        Program.QuitTheProgram();
    }
}
