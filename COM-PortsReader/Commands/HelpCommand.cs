using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COM_PortsReader.Commands;

internal class HelpCommand : ICommand
{
    public string Description => "The help command outputs a description of all commands";

    public void Execute(string[] args)
    {
        Console.WriteLine("qwerty");
    }
}
