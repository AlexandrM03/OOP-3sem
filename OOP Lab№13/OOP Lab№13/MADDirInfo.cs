using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOP_Lab_13
{
    static class MADDirInfo
    {
        public static void FileCount(string path)
        {
            Console.WriteLine($"Количество файлов в каталоге {path}: {Directory.GetFiles(path).Length}");
            Console.WriteLine();

            MADLog.AddNote("MADDirInfo", path, "Определено количество файлов в каталоге.\n");
        }

        public static void CreationTime(string path)
        {
            Console.WriteLine($"Время создания каталога {path}: {Directory.GetCreationTime(path)}");
            Console.WriteLine();

            MADLog.AddNote("MADDirInfo", path, "Определено время создания каталога.\n");
        }

        public static void SubDirectoryCount(string path)
        {
            Console.WriteLine($"Количество подкаталогов каталога {path}: {Directory.GetDirectories(path).Length}");
            Console.WriteLine();

            MADLog.AddNote("MADDirInfo", path, "Определено количество подкаталогов каталога.\n");
        }

        public static void ParentDirectory(string path)
        {
            Console.WriteLine($"Родительский путь каталога {path}: {Directory.GetParent(path)}");
            Console.WriteLine();

            MADLog.AddNote("MADDirInfo", path, "Определен родительский путь каталога.\n");
        }
    }
}
