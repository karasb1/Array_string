namespace Array_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] array = new int[40];
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
            Console.WriteLine("Enter a first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a third number: ");
            int number3 = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 0; i < array.Length - 3; i++)
            {
                if (array[i] == number1 && array[i + 1] == number2 && array[i + 2] == number3)
                {
                    count++;
                }
            }
            Console.WriteLine("Count: " + count);
        }
    }
}