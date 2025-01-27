namespace Array_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[,] array = new int[5,5];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = random.Next(-100, 100);
                }
            }
            int min = array[0, 0];
            int max = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                    }
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                }
            }
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > min && array[i, j] < max)
                    {
                        sum += array[i, j];
                    }
                }
            }
            Console.WriteLine("Sum = " + sum);
        }
    }
}