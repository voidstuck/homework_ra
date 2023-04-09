using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_prog1
{
    public class ToolsForGettingFandD
    {
        //чтобы считать названия папок и файлов
        public static List<ItemsForRecord> GetFilesAndDirs (string unzippedFolderPath)
        {
            List<ItemsForRecord> filesAndDirs = new List<ItemsForRecord>();

            string[] dirs = Directory.GetDirectories(unzippedFolderPath);
            foreach (string directory in dirs)
            {
                filesAndDirs.Add(new ItemsForRecord(
                    ItemsForRecord.Types.Directory,
                    directory.Remove(0, unzippedFolderPath.Length+1),
                    Directory.GetLastWriteTime(unzippedFolderPath)));
            }

            string[] files = Directory.GetFiles(unzippedFolderPath);
            foreach (string file in files)
            {
                filesAndDirs.Add(new ItemsForRecord(
                    ItemsForRecord.Types.File,
                    file.Remove(0, unzippedFolderPath.Length+1),
                    File.GetLastWriteTime(file)));
            }
            return filesAndDirs;
        }

        //чтобы записать в файл .csv
        public static void SaveFilesAndDirsInCsv (List<ItemsForRecord> filesAndFolders, string csvFilePath)
        {
            if (!File.Exists(csvFilePath))
            {
                File.Create(csvFilePath);
            }
            using StreamWriter writer = new StreamWriter(csvFilePath, false);
            foreach (var fileAndFolder in filesAndFolders)
            {
                writer.WriteLine($"{fileAndFolder.Type}\t{fileAndFolder.Name}\t{fileAndFolder.LastDatetime}");
            }            
        }
    }
}
