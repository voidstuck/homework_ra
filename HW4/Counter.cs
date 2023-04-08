namespace HW4;

public class Counter
{
    public delegate void CounterNotifier();

    public static event CounterNotifier CountedTo;
    public void CountByCounter()
    {
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine($"Сейчас {i}");
            if (i == 23)
            {
                CountedTo();
                break;
            }
        }
    }
}