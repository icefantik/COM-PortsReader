namespace COM_PortsReader.Commands;

internal interface ICommand
{
    void Execute(string[] args);
    string Description { get; }
}
