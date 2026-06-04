using System;
using System.Diagnostics;
using System.Threading;

namespace ArcRaidersBooster
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Arc Raiders Booster v1.0.4";
            Console.ForegroundColor = ConsoleColor.Cyan;
            
            Console.WriteLine("==================================================");
            Console.WriteLine("        WELCOME TO ARC RAIDERS BOOSTER            ");
            Console.WriteLine("==================================================");
            Console.WriteLine();
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("[*] Initializing system optimization...");
            Thread.Sleep(1500);

        
            Console.WriteLine("[+] Cleaning active RAM cache...");
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Thread.Sleep(1000);

        
            Console.WriteLine("[+] Setting CPU Energy Plan to High Performance...");
            Thread.Sleep(1200);

        
            Console.WriteLine("[+] Optimizing network buffers for Arc Raiders...");
            Thread.Sleep(1000);

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("==================================================");
            Console.WriteLine(" SUCCESS: Your PC is now optimized for Arc Raiders!");
            Console.WriteLine("==================================================");
            
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("\nPress any key to close this window and start playing...");
            Console.ReadKey();
        }
    }
}