using System.Collections.Specialized;

namespace Array_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            int result = 0;
            int number = 0;
            bool operation = true;
            for (int i = 0; i < expression.Length; i++)
            {
                char c = expression[i];
                if (char.IsDigit(c))
                {
                    number = number * 10 + (c - '0');
                }
                else
                {
                    if (operation)
                    {
                        result += number;
                    }
                    else
                    {
                        result -= number;
                    }
                    number = 0;
                    if (c == '+')
                    {
                        operation = true;
                    }
                    else if (c == '-')
                    {
                        operation = false;
                    }
                }
                if (operation)
                {
                    result += number;
                }
                else
                {
                    result -= number;
                }
            }
            Console.WriteLine(result);
        }
    }
}
