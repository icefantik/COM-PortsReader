namespace COM_PortsReader.Commands;

internal class OpenPortCommand : ICommand
{
    public string Description => Localizer.GetString("Description command open");

    public void Execute(string[] args)
    {
        if (Program.selectedPort == null)
        {
            Console.WriteLine(Localizer.GetString("Don't select com-port"));
            return ;
        }

        try
        {
            Program.selectedPort.Open();
            Console.WriteLine();
        }
        catch (Exception ex)
        {
            Console.WriteLine(Localizer.GetString("Error") + ex.Message);
        }

    }
}
