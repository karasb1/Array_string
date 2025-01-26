namespace Array_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter sentence: ");
            string sentence = Console.ReadLine();
            Console.WriteLine("Enter word: ");
            string word = Console.ReadLine();
            int count = 0;
            for(int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i] == word[0])
                {
                    bool isWord = true;
                    for (int j = 1; j < word.Length; j++)
                    {
                        if (sentence[i + j] != word[j])
                        {
                            isWord = false;
                            break;
                        }
                    }
                    if (isWord)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("Number of word in sentence: " + count);
        }
    }
}