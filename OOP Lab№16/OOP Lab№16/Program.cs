using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Collections.Concurrent;

namespace OOP_Lab_16
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task1();
            // Task2();
            // Task3();
            // Task4();
            // Task5();
            // Task6();
            // Task7();
            Task8();
        }

        #region Task1
        static void Task1()
        {
            for (int i = 0; i < 5; i++)
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                Task task = new Task(() => MulNumbers(100000));
                task.Start();
                Console.WriteLine($"Task id: {task.Id}, status: {task.Status}");
                task.Wait();
                Console.WriteLine($"Task id: {task.Id}, status: {task.Status}");
                sw.Stop();
                Console.WriteLine($"Task #1: {sw.ElapsedMilliseconds}ms");
                Console.WriteLine();
            }
        }

        //static long MulNumbersThread(int k, int m)
        //{
        //    // k - Размер массива
        //    // m - Количество потоков

        //    Stopwatch sw = new Stopwatch();
        //    sw.Start();

        //    int[] vector1 = new int[k];
        //    Random random = new Random();
        //    for (int i = 0; i < k; i++)
        //        vector1[i] = random.Next(1, 10);

        //    Thread[] threads = new Thread[m];
        //    var range = (int)Math.Ceiling((double)k / m);

        //    for (int i = 0; i < m; i++)
        //    {
        //        int start = i * range;
        //        int end = start + range - 1;

        //        if (start > k - 1)
        //            break;
        //        if (end > k - 1)
        //            _ = k - 1;

        //        threads[i] = new Thread(() => MulRange(start, end));
        //        threads[i].Start();
        //        threads[i].Join();
        //    }

        //    void MulRange(int start, int end)
        //    {
        //        for (int i = start; i <= end; i++)
        //            vector1[i] *= 2;
        //    }

        //    sw.Stop();
        //    return sw.ElapsedMilliseconds;
        //}

        static void MulNumbers(int k, object ob = null)
        {
            if (ob != null)
            {
                var token = (CancellationToken)ob;
                if (token.IsCancellationRequested)
                {
                    Console.WriteLine("Exiting");
                    return;
                }
            }

            Random random = new Random();

            List<int> vector = new List<int>();
            for (int i = 0; i < k; i++)
                vector.Add(random.Next(1, 10));

            vector = vector.Select(x => x * 10).ToList();
        }
        #endregion

        static void Task2()
        {
            CancellationTokenSource cancellation = new CancellationTokenSource();
            Task task = Task.Run(() => MulNumbers(1000, cancellation), cancellation.Token);
            try
            {
                cancellation.Cancel();
                task.Wait();
            }
            catch (Exception)
            {
                if (task.IsCanceled)
                    Console.WriteLine("Task is canceled");
            }
        }
        static void Task3()
        {
            Task<int> first = new Task<int>(() => new Random().Next(1, 9) * 100);
            Task<int> second = new Task<int>(() => new Random().Next(0, 9) * 10);
            Task<int> third = new Task<int>(() => new Random().Next(0, 9));

            first.Start();
            second.Start();
            third.Start();
            first.Wait();
            second.Wait();
            third.Wait();

            Task<int> number = new Task<int>(() => first.Result + second.Result + third.Result);
            number.Start();
            Console.WriteLine($"Number: {number.Result}");
        }
        static void Task4()
        {
            Task<int> task4 = new Task<int>(() => 100 + 10 + 1);
            Task show = task4.ContinueWith(sum => Console.WriteLine($"Sum = {sum.Result}"));
            task4.Start();
            show.Wait();

            Task<double> sqrt = new Task<double>(() => Math.Sqrt(49));
            TaskAwaiter<double> awaiter = sqrt.GetAwaiter();
            awaiter.OnCompleted(() => Console.WriteLine($"Result is: {sqrt.Result}"));
            sqrt.Start();
            sqrt.Wait();
            awaiter.GetResult();
            Thread.Sleep(10);
        }
        static void Task5()
        {
            int[] arr1 = new int[100000];
            int[] arr2 = new int[100000];
            int[] arr3 = new int[100000];

            Stopwatch sw = new Stopwatch();
            sw.Start();
            Parallel.For(0, 100000, Fill);
            sw.Stop();
            Console.WriteLine($"Parallel for: {sw.ElapsedMilliseconds}ms");

            sw.Restart();
            for(int i = 0; i < 100000; i++)
            {
                arr1[i] = i;
                arr2[i] = i;
                arr3[i] = i;
            }
            sw.Stop();
            Console.WriteLine($"Normal for: {sw.ElapsedMilliseconds}ms");

            sw.Restart();
            Parallel.ForEach(arr1, i => i = 1);
            Parallel.ForEach(arr2, i => i = 1);
            Parallel.ForEach(arr3, i => i = 1);
            sw.Stop();
            Console.WriteLine($"Parallel foreach: {sw.ElapsedMilliseconds}ms");

            void Fill(int x)
            {
                arr1[x] = x;
                arr2[x] = x;
                arr3[x] = x;
            }
        }
        static void Task6()
        {
            int count = 0;
            int maxCount = 100;
            Parallel.Invoke(() =>
            {
                while (count < maxCount)
                {
                    count++;
                    Console.WriteLine($"1: {count}");
                }
            },
            () =>
            {
                while (count < maxCount)
                {
                    count++;
                    Console.WriteLine($"2: {count}");
                }
            },
            () =>
            {
                while (count < maxCount)
                {
                    count++;
                    Console.WriteLine($"3: {count}");
                }
            });
        }
        static void Task7()
        {
            BlockingCollection<string> bc = new BlockingCollection<string>(5);

            Task[] sellers = new Task[10]
            {
                new Task(() => { while (true) { Thread.Sleep(700); bc.Add("Стол"); } }),
                new Task(() => { while (true) { Thread.Sleep(700); bc.Add("Шкаф"); } }),
                new Task(() => { while (true) { Thread.Sleep(700); bc.Add("Зеркало"); } }),
                new Task(() => { while (true) { Thread.Sleep(700); bc.Add("Бра"); } }),
                new Task(() => { while (true) { Thread.Sleep(700); bc.Add("Подоконник"); } }),
                new Task(() => { while (true) { Thread.Sleep(700); bc.Add("Микроволновка"); } }),
                new Task(() => { while (true) { Thread.Sleep(700); bc.Add("Кровать"); } }),
                new Task(() => { while (true) { Thread.Sleep(700); bc.Add("Дверь"); } }),
                new Task(() => { while (true) { Thread.Sleep(700); bc.Add("Вазон"); } }),
                new Task(() => { while (true) { Thread.Sleep(700); bc.Add("Стул"); } })
            };

            Task[] consumers = new Task[5]
            {
                new Task(() => { while (true) { Thread.Sleep(300); bc.Take(); } }),
                new Task(() => { while (true) { Thread.Sleep(500); bc.Take(); } }),
                new Task(() => { while (true) { Thread.Sleep(500); bc.Take(); } }),
                new Task(() => { while (true) { Thread.Sleep(400); bc.Take(); } }),
                new Task(() => { while (true) { Thread.Sleep(250); bc.Take(); } })
            };

            foreach (var i in sellers)
                if (i.Status != TaskStatus.Running)
                    i.Start();

            foreach (var i in consumers)
                if (i.Status != TaskStatus.Running)
                    i.Start();

            int count = 1;
            while (true)
            {
                if (bc.Count != count && bc.Count != 0)
                {
                    count = bc.Count;
                    Thread.Sleep(500);
                    Console.Clear();
                    Console.WriteLine("---Склад---");

                    foreach(var i in bc)
                        Console.WriteLine(i);
                }
            }
        }
        static void Task8()
        {
            void Factorial()
            {
                int result = 1;
                for (int i = 1; i <= 6; i++)
                    result *= i;
                Thread.Sleep(1000);
                Console.WriteLine($"6! = {result}");
            }

            async void FactorialAsync()
            {
                Console.WriteLine("FA start");
                await Task.Run(() => Factorial());
                Console.WriteLine("FA ends");
            }

            FactorialAsync();
            Console.ReadKey();
        }
    }
}
