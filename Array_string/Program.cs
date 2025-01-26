namespace Array_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            int vowels = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == 'a' || sentence[i] == 'e' || sentence[i] == 'i' || sentence[i] == 'o' || sentence[i] == 'u')
                {
                    vowels++;
                }
            }
            Console.WriteLine("Vowels : " + vowels);
        }
    }
}