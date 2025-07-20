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

        try
        {
            while (Program.selectedPort.BytesToRead > 0)
            {
                string data1 = Program.selectedPort.ReadLine();
                Console.WriteLine($"[{DateTime.Now:HH:mm:ss}]: {data1}");
            }
        }
        catch (TimeoutException) { }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
