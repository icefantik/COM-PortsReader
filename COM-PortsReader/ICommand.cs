namespace COM_PortsReader;

internal interface ICommand
{
    void Execute(string[] args);
    string Description { get; }
}
