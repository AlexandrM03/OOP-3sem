using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;

namespace OOP_Lab_13
{
    static class MADFileManager
    {
        public static void InspectDirectoty(string path)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            File.Create(@"D:\2 курс\Лабораторные по ООП\OOP Lab№13\OOP Lab№13\MADInspect\MADDirInfo.txt").Close();

            using (StreamWriter sw = new StreamWriter(@"D:\2 курс\Лабораторные по ООП\OOP Lab№13\OOP Lab№13\MADInspect\MADDirInfo.txt"))
            {
                sw.WriteLine("|Директории|");
                foreach (DirectoryInfo dir in directory.GetDirectories())
                    sw.WriteLine(dir.Name);

                sw.WriteLine();

                sw.WriteLine("|Файлы|");
                foreach (FileInfo file in directory.GetFiles())
                    sw.WriteLine(file.Name);
            }

            File.Copy(@"D:\2 курс\Лабораторные по ООП\OOP Lab№13\OOP Lab№13\MADInspect\MADDirInfo.txt", @"D:\2 курс\Лабораторные по ООП\OOP Lab№13\OOP Lab№13\MADInspect\MADDirInfoRenamed.txt", true);
            File.Delete(@"D:\2 курс\Лабораторные по ООП\OOP Lab№13\OOP Lab№13\MADInspect\MADDirInfo.txt");
        }

        public static void CopyFiles(string path, string extension)
        {
            DirectoryInfo directory = new DirectoryInfo(path);
            Directory.CreateDirectory(@"D:\2 курс\Лабораторные по ООП\OOP Lab№13\OOP Lab№13\MADFiles");

            foreach (FileInfo file in directory.GetFiles())
            {
                if (file.Extension == extension)
                    file.CopyTo($@"D:\2 курс\Лабораторные по ООП\OOP Lab№13\OOP Lab№13\MADFiles\{file.Name}", true);
            }

            Directory.Delete(@"D:\2 курс\Лабораторные по ООП\OOP Lab№13\OOP Lab№13\MADInspect\MADFiles\", true);
            Directory.Move(@"D:\2 курс\Лабораторные по ООП\OOP Lab№13\OOP Lab№13\MADFiles\", @"D:\2 курс\Лабораторные по ООП\OOP Lab№13\OOP Lab№13\MADInspect\MADFiles\");
        }

        public static void Archive(string pathFrom, string pathTo)
        {
            if (!File.Exists($@"{pathFrom}.zip"))
                ZipFile.CreateFromDirectory(pathFrom, $@"{pathFrom}.zip");

            ZipFile.ExtractToDirectory($@"{pathFrom}.zip", pathTo, true);
        }
    }
}
