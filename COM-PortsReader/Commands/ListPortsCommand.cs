namespace COM_PortsReader.Commands;

internal class ListPortsCommand : ICommand
{
    public string Description => Localizer.GetString("Description command list");

    public void Execute(string[] args)
    {
        throw new NotImplementedException();
    }
}