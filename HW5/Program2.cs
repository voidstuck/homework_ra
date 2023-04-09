/*
Вторая программа:
1. Считывает путь к файлу из %AppData%/Lesson12Homework.txt
2. Открывает указанный файл .csv
3. Выводит в консоль список файлов, прочитанный из файла csv, отсортированный по
дате изменения
4. Удаляет файл %AppData%/Lesson12Homework.txt
*/
using System.Reflection.Metadata.Ecma335;

namespace HW5_prog1
{
    public class Program2
    {
        public const string targetFolder = "D:\\Progs\\gitfolder\\SmartGit\\homework_ra.git\\HW5\\HW5_prog1";
        public const string pathToTxtFile = "AppData\\Lesson12Homework.txt";
        public const string Delimeter = "\\t";
        public static void ShowFilesAndDirs()
        {
            //1
            string path = Path.Combine(targetFolder, pathToTxtFile);

            string pathToCsvFile = File.ReadAllText(path);

            //2
            List<ItemsForRecord> contents = new List<ItemsForRecord>();
            var redLinesCsv = File.ReadAllLines(pathToCsvFile);
            foreach (string line in redLinesCsv)
            {
                string[] lines = line.Split(Delimeter);
                int i = 0;
                ItemsForRecord.Types backMyType;
                switch (lines[i])
                {
                    case "File":
                        backMyType = ItemsForRecord.Types.File;
                        break;
                    case "Directory":
                        backMyType = ItemsForRecord.Types.Directory;
                        break;
                    default:
                        backMyType = ItemsForRecord.Types.Unknown;
                        break;
                }
                contents.Add(new ItemsForRecord(
                    Type: backMyType, 
                    Name: lines[i+1], 
                    LastDateTime: Convert.ToDateTime(lines[i+2])));
                i++;
            }

            //3
            foreach (var element in contents)
            {
                Console.WriteLine($"{element.Type}\t{element.Name}\t{element.LastDatetime}");
            }

            //4
            if (Directory.Exists(path))
            {
                Directory.Delete(path, true);
            }
        }
    }
}
