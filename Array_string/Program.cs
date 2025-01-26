namespace Array_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 10);
            }
            Console.WriteLine("Array: ");
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            int odd = 0;
            int even = 0;
            int unique = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                bool isUnique = true;
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j] && i != j)
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique)
                {
                    unique++;
                }
            }
            Console.WriteLine("Odd: " + odd);
            Console.WriteLine("Even: " + even);
            Console.WriteLine("Unique: " + unique);
        }
    }
}