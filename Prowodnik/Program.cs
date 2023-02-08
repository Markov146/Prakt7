using System;

namespace Prowodnik
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Console.SetCursorPosition(50, 0);
            Console.WriteLine("Этот компьютер");
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            Console.SetCursorPosition(0, 3);
            foreach (DriveInfo drive in allDrives)
            {
                Console.WriteLine($"  {drive.Name} Свободно {drive.TotalFreeSpace / 1073741824} ГБ из {drive.TotalSize / 1073741824} ГБ");

            }
        }
        
        public void DirConsole(string pathToFolder)
        {
            Dir(pathToFolder, 0);

            void Dir(string nameFolder, int level)
            {
                string[] allfiles = Directory.GetFiles(nameFolder);
                foreach (string filename in allfiles)
                {
                    Console.WriteLine(new string('\t', level) + filename);
                }
                string[] allfolders = Directory.GetDirectories(pathToFolder);
                foreach (string folder in allfolders)
                {
                    Console.WriteLine(new string('\t', level) + folder);
                    Dir(folder, level + 1);
                }
            }          
                Console.Clear();               
            
            



        }


     }
     
}
