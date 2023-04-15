using System.IO;
using System.Linq;
using System.Xml.Linq;

namespace HW5_prog1
{
    public class ToolsForGettingFilesAndDirs //адекватное название
    {
        //чтобы считать названия папок и файлов
        public static List<ItemsForRecord> GetFilesAndDirs(string unzippedFolderPath)
        {
            List<ItemsForRecord> filesAndDirs = new List<ItemsForRecord>();
            GiveType(unzippedFolderPath, filesAndDirs);
            return filesAndDirs;
        }

        //не понял как эти блоки можно объединить, ни switch, ни if не пускает
        //вынес в отдельную функцию, чтобы глазу было приятно
        public static List<ItemsForRecord> GiveType(string path, List<ItemsForRecord> filesOrDirs)
        {
            string[] dirs = Directory.GetDirectories(path);
            foreach (string dir in dirs)
            {
                filesOrDirs.Add(new ItemsForRecord(
                        ItemsForRecord.Types.Directory,
                        dir.Remove(0, path.Length + 1),
                        Directory.GetLastWriteTime(path)));    
            }
            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                filesOrDirs.Add(new ItemsForRecord(
                        ItemsForRecord.Types.File,
                        file.Remove(0, path.Length + 1),
                        Directory.GetLastWriteTime(path)));
            }
            return filesOrDirs;
        }

        //чтобы записать в файл .csv
        //асинхронный
        public static async Task SaveFilesAndDirsInCsv(List<ItemsForRecord> filesAndFolders, string csvFilePath)
        {
            if (!File.Exists(csvFilePath))
            {
                File.Create(csvFilePath);
            }
            await using StreamWriter writer = new StreamWriter(csvFilePath, false);
            foreach (var fileAndFolder in filesAndFolders)
            {
                writer.WriteLine($"{fileAndFolder.Type}\t{fileAndFolder.Name}\t{fileAndFolder.LastDatetime}");
            }
        }
    }
}
