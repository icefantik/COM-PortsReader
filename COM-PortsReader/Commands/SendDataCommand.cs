namespace COM_PortsReader.Commands;

internal class SendDataCommand : ICommand
{
    public string Description => Localizer.GetString("Description command send");

    public void Execute(string[] args)
    {
        if (Program.selectedPort == null)
        {
            Console.WriteLine(Localizer.GetString("Don't select com-port"));
            return;
        }

        if ((bool)!Program.selectedPort?.IsOpen!)
        {
            Console.WriteLine(Localizer.GetString("Port is not open"));
            return ;
        }

        if (args.Length == 0)
        {
            Console.WriteLine(Localizer.GetString("No data"));
            return ;
        }

        var data = string.Join(" ", args);
        Program.selectedPort?.WriteLine(data);
        Console.WriteLine(Localizer.GetString("Data sent"));
    }
}
