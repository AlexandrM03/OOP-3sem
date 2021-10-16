using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOP_Lab_8
{
    class FileStreamer
    {
        public static void WriteToFile(MyList<string> list)
        {
            using (StreamWriter sw = new StreamWriter(@"D:\2 курс\Лабораторные по ООП\OOP Lab№08\OOP Lab№8\file.txt"))
            {
                Node<string> temp = list.GetHead();
                while (temp.NextNode != null)
                {
                    sw.Write($"{temp.Data} --> ");
                    temp = temp.NextNode;
                }
                sw.WriteLine(temp.Data);
            }
        }

        public static void ReadFromFile(ref MyList<string> list)
        {
            using (StreamReader sw = new StreamReader(@"D:\2 курс\Лабораторные по ООП\OOP Lab№08\OOP Lab№8\file.txt"))
            {
                string[] items = sw.ReadToEnd().Split(" --> ");
                foreach (string item in items)
                {
                    list.Add(item);
                }
            }
        }
    }
}
