using System;
using System.Management.Automation;

namespace VeyonCtl
{
    class Program
    {
        private const string ServiceName = "VeyonService";

        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                ShowUsage();
                return;
            }

            string action = args[0].ToLower();

            try
            {
                switch (action)
                {
                    case "start":
                        StartService();
                        break;
                    case "stop":
                        StopService();
                        break;
                    case "enable":
                        EnableService();
                        break;
                    case "disable":
                        DisableService();
                        break;
                    default:
                        Console.WriteLine("Invalid command.");
                        ShowUsage();
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        private static void ShowUsage()
        {
            Console.WriteLine("Usage: veyonctl <start|stop|enable|disable>");
            Console.WriteLine("  start   - Starts the VeyonService.");
            Console.WriteLine("  stop    - Stops the VeyonService.");
            Console.WriteLine("  enable  - Enables the VeyonService (sets to automatic start).");
            Console.WriteLine("  disable - Disables the VeyonService (sets to disabled).");
        }

        private static void StartService()
        {
            Console.WriteLine($"Starting service '{ServiceName}'...");
            ExecutePowerShellCommand("Start-Service", ServiceName);
        }

        private static void StopService()
        {
            Console.WriteLine($"Stopping service '{ServiceName}'...");
            ExecutePowerShellCommand("Stop-Service", ServiceName);
        }

        private static void EnableService()
        {
            Console.WriteLine($"Enabling service '{ServiceName}' (setting start mode to 'Automatic')...");
            ExecutePowerShellCommand("Set-Service", ServiceName, ("StartupType", "Automatic"));
        }

        private static void DisableService()
        {
            Console.WriteLine($"Disabling service '{ServiceName}' (setting start mode to 'Disabled')...");
            ExecutePowerShellCommand("Set-Service", ServiceName, ("StartupType", "Disabled"));
        }

        private static void ExecutePowerShellCommand(string command, string serviceName, params (string, object)[] parameters)
        {
            using (PowerShell ps = PowerShell.Create())
            {
                ps.AddCommand(command).AddParameter("Name", serviceName);

                foreach (var param in parameters)
                {
                    ps.AddParameter(param.Item1, param.Item2);
                }

                var results = ps.Invoke();

                if (ps.HadErrors)
                {
                    foreach (var error in ps.Streams.Error)
                    {
                        Console.WriteLine($"Error: {error.ToString()}");
                    }
                }
                else
                {
                    Console.WriteLine("Command executed successfully.");
                }
            }
        }
    }
}
