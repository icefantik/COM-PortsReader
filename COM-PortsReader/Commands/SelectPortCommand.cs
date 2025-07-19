using System.IO.Ports;

namespace COM_PortsReader.Commands;

internal class SelectPortCommand : ICommand
{
    public string Description => Localizer.GetString("Description command select");

    public void Execute(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine(Localizer.GetString("Don't select com-port")); 
            return ;
        }

        var portName = args[0];
        if (Array.Exists(SerialPort.GetPortNames(), p => p == portName))
        {
            Program.selectedPort = new SerialPort(portName);
            Console.WriteLine(Localizer.GetString("Selected port") + portName);
        }
        else
        {
            Console.WriteLine(Localizer.GetString("Port don't find"));
        }
    }
}
