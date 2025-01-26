namespace Array_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Console.WriteLine("Enter the number of elements in the first array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of elements in the second array: ");
            int m = Convert.ToInt32(Console.ReadLine());
            int[] array1 = new int[n];
            int[] array2 = new int[m];
            for (int i = 0; i < n; i++)
            {
                array1[i] = random.Next(0, 100);
            }
            for (int i = 0; i < m; i++)
            {
                array2[i] = random.Next(0, 100);
            }
            Console.WriteLine("First array: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write(array1[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Second array: ");
            for (int i = 0; i < m; i++)
            {
                Console.Write(array2[i] + " ");
            }
            Console.WriteLine();
            int a = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        a++;
                    }
                }
            }
            if (a == 0)
            {
                Console.WriteLine("No matches found");
            }
            else
            {
                int[] array3 = new int[a];
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (array1[i] == array2[j])
                        {
                            array3[i] = array1[i];
                        }
                    }
                }
                Console.WriteLine("Array of matches: ");
                foreach (int i in array3)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}