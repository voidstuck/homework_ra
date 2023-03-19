
namespace HW2
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите размер массива:");
            int leghtOfArray = ReadInt();
            Console.WriteLine("Введите числа-элементы массива:");
            int[] userArray = GetArray(leghtOfArray);
            SecondMaximum(userArray);
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
                else throw new FormatException("Вы ввели не число");
            }
            return number;
        }

        public static int[] GetArray(int leghtOfArray)
        {
            if (leghtOfArray <= 1)
            {
                throw new Exception("Размер массива должен быть больше 1");
            }
            else
            {
                int[] userArray = new int [leghtOfArray];
                for (int i = 0; i < leghtOfArray; i++)
                {
                    userArray[i] = ReadInt();
                }
                return userArray;
            }
            
        }

        public static void SecondMaximum(int[] userArray)
        {
            Array.Sort(userArray);
            Array.Reverse(userArray);
            int secMax = 0;
            try
            {
                for (int i = 0; i < userArray.Length;)
                {
                    while (userArray[i] == userArray[i + 1])
                    {
                        i++;
                    }
                    secMax = userArray[i + 1];
                    break;
                }
                Console.WriteLine($"Второе максимальное число: {secMax}");
            }
            catch (Exception)
            {
                Console.WriteLine("Массив состоит из одинаковых чисел. Создайте новый.");
            }
        }
    }
}
