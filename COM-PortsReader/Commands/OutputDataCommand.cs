using System.IO.Ports;

namespace COM_PortsReader.Commands;

internal class OutputDataCommand : ICommand
{
    public string Description => Localizer.GetString("Description command output data");

    public void Execute(string[] args)
    {
        if (Program.selectedPort == null)
        {
            Console.WriteLine(Localizer.GetString("Don't select com-port"));
            return;
        }

        Program.selectedPort.DataReceived += (sender, e) =>
        {
            SerialPort port = (SerialPort)sender;
            string data = port.ReadExisting();
            Console.WriteLine($"[{DateTime.Now:HH:mm:ss}]: {data}");
        };
    }
}
