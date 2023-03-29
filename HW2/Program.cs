
namespace HW2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива:");
            int leghtOfArray = ReadInt();
            try
            {
                int[] userArray = GetArray(leghtOfArray);
                GetSecondMaximum(userArray);
            }
            catch (IndexOutOfRangeException) //опытным путём было выяснено, что если все числа одинаковы, то выпадает именно эта ошибка
            {
                Console.WriteLine("Массив состоит из одинаковых чисел. Создайте новый.");
            }
            catch (Exception)
            {
                Console.WriteLine("Размер массива должен быть больше 1");
            }
            
        }

        public static int ReadInt()
        {
            int number = 0;
            bool checkFormat = false;
            while (!checkFormat)
            {
                if (int.TryParse(Console.ReadLine(), out number))
                {
                    checkFormat = true;
                }
                else Console.WriteLine("Вы ввели не число. Повторите ввод"); //исправлено, программа мучает юзера пока не увидит тут число
            }
            return number;
        }

        public static int[] GetArray(int leghtOfArray) //теперь обработка ошибки происходит в мэйне
        {
            if (leghtOfArray <= 1)
            {
                throw new Exception();
            }
            else
            {
                int[] userArray = new int [leghtOfArray];
                Console.WriteLine("Введите числа-элементы массива:");
                for (int i = 0; i < leghtOfArray; i++)
                {
                    userArray[i] = ReadInt();
                }
                return userArray;
            }
            
        }

        public static void GetSecondMaximum(int[] userArray) //название исправлено!
        {
            Array.Sort(userArray);
            Array.Reverse(userArray);
            int secMax = 0;
            int[] userArray1 = userArray.Distinct().ToArray(); //мозги додумались до более простого способа найти максимум без использования циклов))
            secMax = userArray1[1];
            Console.WriteLine($"Второе максимальное число: {secMax}");
        }
    }
}
