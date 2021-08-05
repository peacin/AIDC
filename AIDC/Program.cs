using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AIDC
{
    class Program
    {
        static void Main(string[] args)
        {
            Process.GetProcessesByName("AnyDesk")[0].Kill(); //Kill the process of anydesk

            File.Delete("C:\\ProgramData\\AnyDesk\\system.conf"); //Delete config files.
            File.Delete("C:\\ProgramData\\AnyDesk\\service.conf");

            Console.WriteLine("Start AnyDesk");
            Thread.Sleep(5000);
            Environment.Exit(0); //Exists the program after 5 seconds.

        }
    }
}
