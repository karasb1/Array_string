namespace Array_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            bool newsentence = true;    
            foreach(char a in text)
            {
                if (newsentence && char.IsLetter(a))
                {
                    Console.Write(char.ToUpper(a));
                    newsentence = false;
                }
                else
                {
                    Console.Write(a);
                }
                if (a == '.' || a == '?' || a == '!')
                {
                    newsentence = true;
                }
            }
        }
    }
}