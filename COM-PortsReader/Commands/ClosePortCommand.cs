namespace COM_PortsReader.Commands;

internal class ClosePortCommand : ICommand
{
    public string Description => Localizer.GetString("Description command close");

    public void Execute(string[] args)
    {
        if (Program.selectedPort == null)
        {
            Console.WriteLine(Localizer.GetString("Don't select com-port"));
            return;
        }

        try
        {
            Program.selectedPort.Close();
            Console.WriteLine();
        }
        catch (Exception ex)
        {
            Console.WriteLine(Localizer.GetString("Error"));
        }
    }
}
