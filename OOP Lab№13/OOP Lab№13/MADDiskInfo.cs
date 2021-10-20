using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace OOP_Lab_13
{
    static class MADDiskInfo
    {
        public static void FreeSpace(string driveName)
        {
            foreach(DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.Name == driveName && drive.IsReady)
                {
                    Console.WriteLine($"Доступный объём на диске {driveName.First()}: {Math.Round(drive.AvailableFreeSpace / Math.Pow(10, 9), 2)}Гб");
                    MADLog.AddNote("MADDiskInfo", drive.Name, "Определено свободное место на диске.\n");
                }    
            }
            Console.WriteLine();
        }

        public static void FileSystemInfo(string driveName)
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.Name == driveName && drive.IsReady)
                {
                    Console.WriteLine($"Тип файловой системы и формат диска {driveName.First()} : {drive.DriveType}, {drive.DriveFormat}");
                    MADLog.AddNote("MADDiskInfo", drive.Name, $"{drive.DriveFormat}\n");
                }
            }
            Console.WriteLine();
        }

        public static void DriveFullInfo()
        {
            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                if (drive.IsReady)
                {
                    Console.WriteLine($"Имя: {drive.Name}");
                    Console.WriteLine($"Объём: {Math.Round(drive.TotalSize / Math.Pow(10, 9), 2)}Гб");
                    Console.WriteLine($"Доступный объём: {Math.Round(drive.AvailableFreeSpace / Math.Pow(10, 9), 2)}Гб");
                    Console.WriteLine($"Места тома: {drive.VolumeLabel}");
                    Console.WriteLine();

                    MADLog.AddNote("MADDiskInfo", drive.Name, "Выведена информация о диске.\n");
                }
            }
        }
    }
}
