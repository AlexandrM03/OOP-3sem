using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab_5.Exceptions
{
    class Logger
    {
        public static void WriteLog(Exception ex, bool infile = true, string filePath = @"D:\2 курс\Лабораторные по ООП\OOP Lab№5-6\OOP Lab№5\LOG.txt") 
        {
            if (infile)
            {
                DateTime time = DateTime.Now;
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine($"Time: {time}");
                    sw.Write($"ERROR: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
