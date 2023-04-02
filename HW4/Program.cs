/*
Реализовать 3 класса: 
Первый класс (Counter) будет считать до 100 используя цикл. При достижении некоторого  
числа (например 77) класс должен сгенерировать событие. 
Два других класса (Handler1 и Handler2) будут ждать события, после чего они должны вывести 
на консоль фразы в любой последовательности: «Пора действовать, ведь уже 77», «Уже 77,  
давно пора было начать!».
*/

namespace HW4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Counter counter = new Counter();
            Handler1 hand1 = new Handler1();
            Handler2 hand2 = new Handler2();

            Counter.CountedTo += hand1.NotificationMessage;
            Counter.CountedTo += hand2.NotificationMessage;

            counter.CountByCounter();
        }
    }
}