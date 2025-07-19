using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COM_PortsReader.Commands;

internal class SelectPortCommand : ICommand
{
    public string Description => Localizer.GetString("Description command select COM-port [number/name]");

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
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine(Localizer.GetString("Port don't find"));
        }
    }
}
