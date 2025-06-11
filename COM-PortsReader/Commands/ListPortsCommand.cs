using System.IO.Ports;

namespace COM_PortsReader.Commands;

internal class ListPortsCommand : ICommand
{
    public string Description => Localizer.GetString("Description command list");

    public void Execute(string[] args)
    {
        Console.WriteLine(Localizer.GetString("Available COM ports"));
        foreach (var portName in SerialPort.GetPortNames())
        {
            Console.WriteLine($" - {portName}");
        }
    }
}