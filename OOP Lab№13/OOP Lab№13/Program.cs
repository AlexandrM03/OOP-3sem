using System;

namespace OOP_Lab_13
{
    class Program
    {
        static void Main(string[] args)
        {
            MADLog.Clear();

            MADDiskInfo.FreeSpace("C:\\");
            MADDiskInfo.FileSystemInfo("C:\\");
            MADDiskInfo.DriveFullInfo();

            MADFileInfo.FullPath(@"D:\2 курс\Лабораторные по ООП\OOP Lab№13\OOP Lab№13\MADLogFile.txt");
            MADFileInfo.FileInfo(@"D:\2 курс\Лабораторные по ООП\OOP Lab№13\OOP Lab№13\MADLogFile.txt");
            MADFileInfo.FileTiming(@"D:\2 курс\Лабораторные по ООП\OOP Lab№13\OOP Lab№13\MADLogFile.txt");

            MADDirInfo.FileCount(@"D:\2 курс\Лабораторные по ООП\OOP Lab№13\OOP Lab№13");
            MADDirInfo.CreationTime(@"D:\2 курс\Лабораторные по ООП\OOP Lab№13\OOP Lab№13");
            MADDirInfo.SubDirectoryCount(@"D:\2 курс\Лабораторные по ООП\OOP Lab№13\OOP Lab№13");
            MADDirInfo.ParentDirectory(@"D:\2 курс\Лабораторные по ООП\OOP Lab№13\OOP Lab№13");

            MADFileManager.InspectDirectoty(@"D:\2 курс\Лабораторные по ООП\OOP Lab№13\OOP Lab№13");
            MADFileManager.CopyFiles(@"D:\2 курс\Лабораторные по ООП\OOP Lab№13\OOP Lab№13", ".txt");
            MADFileManager.Archive(@"D:\2 курс\Лабораторные по ООП\OOP Lab№13\OOP Lab№13\test",
                @"D:\2 курс\Лабораторные по ООП\OOP Lab№13\OOP Lab№13\MADInspect\MADFiles\");
        }
    }
}
