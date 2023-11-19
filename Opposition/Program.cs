
public class Program
{
    public static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }


        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (numbers[i] + numbers[j] == 0)
                {
                    Console.WriteLine($"Числа с индексами {i} и {j} являются противоположными.");
                }

            }
        }
    }
}
