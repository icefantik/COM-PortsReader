namespace COM_PortsReader.Commands;

internal class PortInfoCommand : ICommand
{
    public string Description => Localizer.GetString("Description command info");

    public void Execute(string[] args)
    {
        if (Program.selectedPort == null)
        {
            Console.WriteLine(Localizer.GetString("Don't select com-port"));
            return;
        }

        Console.WriteLine(Localizer.GetString("Port information") + Program.selectedPort.PortName);
        Console.WriteLine(Localizer.GetString("State com-port") + (Program.selectedPort.IsOpen ? "Open" : "Close"));
        Console.WriteLine(Localizer.GetString("Settings") 
            + Program.selectedPort.BaudRate + Localizer.GetString("bot") 
            + Program.selectedPort.DataBits + Localizer.GetString("bit"));
    }
}
