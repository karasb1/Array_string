namespace Array_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = Convert.ToString(Console.ReadLine());
            int wordCount = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == ' ')
                {
                    wordCount++;
                }
            }
            Console.WriteLine("Word count: " + (wordCount + 1));
        }
    }
}