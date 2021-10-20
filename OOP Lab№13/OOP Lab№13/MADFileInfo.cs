using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOP_Lab_13
{
    static class MADFileInfo
    {
        public static void FullPath(string path)
        {
            FileInfo file = new FileInfo(path);

            Console.WriteLine($"Полный путь к файлу {file.Name}: {file.FullName}");
            Console.WriteLine();

            MADLog.AddNote("MADFileInfo", file.Name, "Определён полный путь к файлу.\n");
        }

        public static void FileInfo(string path)
        {
            FileInfo file = new FileInfo(path);

            Console.WriteLine($"Имя файла: {file.Name}");
            Console.WriteLine($"Размер: {Math.Round(file.Length / Math.Pow(10, 3), 2)}Кб");
            Console.WriteLine($"Расширение: {file.Extension}");
            Console.WriteLine();

            MADLog.AddNote("MADFileInfo", file.Name, "Выведена базовая информация о файле.\n");
        }

        public static void FileTiming(string path)
        {
            FileInfo file = new FileInfo(path);

            Console.WriteLine($"Время создания файла {file.Name}: {file.CreationTime}");
            Console.WriteLine($"Время редактирования файла {file.Name}: {file.LastWriteTime}");
            Console.WriteLine();

            MADLog.AddNote("MADFileInfo", file.Name, "Определены тайминги файла.\n");
        }
    }
}
