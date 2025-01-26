namespace Array_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[10];
            int parameter;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 100);
            }
            Console.WriteLine("Enter parameter: ");
            parameter = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Array: ");
            foreach (int i in array)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Number of elements less than the parameter: ");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < parameter)
                {
                    Console.Write(array[i] + " ");
                }
            }
        }
    }
}