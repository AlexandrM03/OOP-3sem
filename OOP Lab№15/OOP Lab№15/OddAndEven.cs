using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP_Lab_15
{
    public static class OddAndEven
    {
        public static void ByOne()
        {
            object locker = new object();

            Thread OddThread = new Thread(new ThreadStart(PrintOdd));
            Thread EvenThread = new Thread(new ThreadStart(PrintEven));
            EvenThread.Start();
            OddThread.Start();

            void PrintOdd()
            {
                lock (locker)
                {
                    for(int i = 1; i < 10; i += 2)
                    {
                        Thread.Sleep(50);
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write($"{i} ");
                    }
                }
            }

            void PrintEven()
            {
                lock (locker)
                {
                    for (int i = 0; i < 10; i += 2)
                    {
                        Thread.Sleep(50);
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($"{i} ");
                    }
                }
            }
        }

        public static void Together()
        {
            Mutex mutex = new Mutex();

            Thread OddThread = new Thread(new ThreadStart(PrintOdd));
            Thread EvenThread = new Thread(new ThreadStart(PrintEven));
            EvenThread.Start();
            OddThread.Start();
            EvenThread.Join();
            OddThread.Join();
            
            void PrintOdd()
            {
                for (int i = 1; i < 10; i += 2)
                {
                    mutex.WaitOne();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write($"{i} ");
                    mutex.ReleaseMutex();
                }
            }

            void PrintEven()
            {
                for (int i = 0; i < 10; i += 2)
                {
                    mutex.WaitOne();
                    Thread.Sleep(50);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($"{i} ");
                    mutex.ReleaseMutex();
                }
            }
        }
    }
}
