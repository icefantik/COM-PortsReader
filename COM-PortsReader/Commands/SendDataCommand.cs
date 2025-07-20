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

        using (var port = Program.selectedPort)
        {
            try
            {
                port.WriteTimeout = 2000;
                var data = string.Join(" ", args) + "\r\n";
                port.Write(data);
                Console.WriteLine(Localizer.GetString("Data sent"));

                port.ReadTimeout = 2000;
                string response = port.ReadLine();
                Console.WriteLine(response);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
