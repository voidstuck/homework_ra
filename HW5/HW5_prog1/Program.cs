/*
Необходимо написать две консольные программы.
Первая из них совершает следующие действия:
1. Распаковывает архив в папку рядом с запускаемым файлом программы
2. Считывает названия файлов и папок из указанной папки
3. Записывает информацию о содержимом папки (тип (файл/папка), название, дата
изменения) в текстовый файл в формате .csv (разделитель – \t (знак табуляции) )
4. Удаляет папку с распакованным архивом
5. Сохраняет путь к файлу csv в файле %AppData%/Lesson12Homework.txt
*/

using System.IO.Compression;

namespace HW5_prog1
{
    public class Program
    {
        public const string zippedFile = "D:\\Progs\\gitfolder\\test.zip";
        public const string targetFolder = "D:\\Progs\\gitfolder\\SmartGit\\homework_ra.git\\HW5\\HW5_prog1";
        public const string pathToTxtFile = "AppData\\Lesson12Homework.txt";

        public static void Main(string[] args)
        {
            //1 Распаковка архива
            string unzippedFolderPath = Path.Combine(targetFolder, "test");
            if (!Directory.Exists(unzippedFolderPath))
            {
                ZipFile.ExtractToDirectory(zippedFile, targetFolder);
            }

            //2 Чтение файлов и папок
            List<ItemsForRecord> filesAndFolders;
            filesAndFolders = ToolsForGettingFilesAndDirs.GetFilesAndDirs(unzippedFolderPath);

            //3 Запись инфы о содержимом в csv
            string csvFilePath = Path.Combine(targetFolder, "1.csv");
            ToolsForGettingFilesAndDirs.SaveFilesAndDirsInCsv(filesAndFolders, csvFilePath);

            //4 Удаление распакованной папки
            if (Directory.Exists(unzippedFolderPath))
            {
                Directory.Delete(unzippedFolderPath, true);
            }

            //5 Сохранение пути к csv файлу в txt формате
            string savedPathFile = Path.Combine(targetFolder, pathToTxtFile);
            if (!Directory.Exists(Path.Combine(targetFolder, pathToTxtFile.Remove(7))))
            {
                Directory.CreateDirectory(Path.Combine(targetFolder, pathToTxtFile.Remove(7)));
            }
            if (!File.Exists(savedPathFile))
            {
                File.Create(savedPathFile);
            }
            using (StreamWriter savePathToCsv = new StreamWriter(savedPathFile, false))
                savePathToCsv.WriteLine(csvFilePath);
        }
    }
}