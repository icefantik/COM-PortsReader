# COM-PortsReader

List of commands with a description:

1) help - The help command outputs a description of all commands;
2) quit - The command to exit the program;
3) list - Displays a list of com ports on the device;
4) select - Allows you to select a specific COM port by name for subsequent operations;
5) send - Send data on select COM-port if it is not close. Accepting input arguments as text to pass;
6) close - Responsible for closing the selected COM port, if it is open, with the output of the operation status;
7) open - Opens the selected COM port for data transfer if it was previously selected and not open;
8) info - Displays basic information about the selected COM port, including its status (open/closed) and current settings (baud rate, data bits) if the port was previously selected;
