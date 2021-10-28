using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace OOP_Lab_15
{
    class Program
    {
        [Obsolete]
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Process[] processList = Process.GetProcesses();

            using (StreamWriter sw = new StreamWriter(@"D:\2 курс\Лабораторные по ООП\OOP Lab№15\OOP Lab№15\processes.txt"))
            {
                sw.WriteLine("{0, -10} {1, -40} {2, -10}", "|ID|", "|Name|", "|Priority|");
                sw.WriteLine(new string('-', 62));
                foreach (Process p in processList)
                {
                    sw.WriteLine("{0, -10} {1, -40} {2, -10}", p.Id, p.ProcessName, p.BasePriority);
                }
            }

            AppDomain thisAppDomain = AppDomain.CurrentDomain;
            Console.WriteLine($"Name: {thisAppDomain.FriendlyName}");
            Console.WriteLine($"Details: {thisAppDomain.SetupInformation}");
            Console.WriteLine($"Assemblies: ");
            thisAppDomain.GetAssemblies().ToList().ForEach(x => Console.WriteLine($"\t{x.FullName}"));

            AppDomain newDomain = AppDomain.CreateDomain("New Domain");
            newDomain.Load(Assembly.GetExecutingAssembly().FullName);
            AppDomain.Unload(newDomain);


            void Count(object num)
            {
                int number = (int)num;
                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine(i);
                    Thread.Sleep(100);
                }
            }
            Thread numbersThread = new Thread(new ParameterizedThreadStart(Count));
            numbersThread.Name = "myThread";

            numbersThread.Start(9);
            Thread.Sleep(500);
            numbersThread.Suspend();

            Console.WriteLine($"Status: {numbersThread.ThreadState}");
            Console.WriteLine($"Name: {numbersThread.Name}");
            Console.WriteLine($"Priority: {numbersThread.Priority}");
            Console.WriteLine($"ID: {numbersThread.ManagedThreadId}");

            numbersThread.Resume();
            Thread.Sleep(500);
            Console.WriteLine();

            OddAndEven.ByOne();
            Thread.Sleep(1000);
            Console.WriteLine();
            OddAndEven.Together();
            Thread.Sleep(1000);
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.Green;

            TimerCallback timerCallback = new TimerCallback(CurrentTime);
            Timer timer = new Timer(timerCallback, null, 0, 1000);
            Thread.Sleep(5000);
            void CurrentTime(object obj)
            {
                Console.WriteLine(DateTime.Now);
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
