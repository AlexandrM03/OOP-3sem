using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOP_Lab_13
{
    static class MADLog
    {
        public static void AddNote(string utility, string path, string message)
        {
            using (StreamWriter sw = new StreamWriter(@"D:\2 курс\Лабораторные по ООП\OOP Lab№13\OOP Lab№13\MADLogFile.txt", true))
            {
                sw.WriteLine($"{utility}: {path}");
                sw.WriteLine($"{message}");
            }
        }

        public static void Clear()
        {
            using (StreamWriter sw = new StreamWriter(@"D:\2 курс\Лабораторные по ООП\OOP Lab№13\OOP Lab№13\MADLogFile.txt"))
            {
                sw.WriteLine(DateTime.Now);
                sw.WriteLine();
                sw.Close();
            }
        }
    }
}
