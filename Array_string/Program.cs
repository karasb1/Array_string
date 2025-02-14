namespace Array_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the operation(Encrypt/Decrypt): ");
            string operetion = Console.ReadLine();
            switch (operetion)
            {
                case "Encrypt":
                    Console.Write("Enter the text: ");
                    string text = Console.ReadLine();
                    Console.Write("Enter the key: ");
                    int key = Convert.ToInt32(Console.ReadLine());
                    string result = "";
                    foreach (char c in text)
                    {
                        char a = char.IsUpper(c) ? 'A' : 'a';
                        result += (char)((c - a + key) % 26 + a);
                    }
                    Console.WriteLine($"Encrypted text : {result}");
                    break;
                case "Decrypt":
                    Console.Write("Enter the text: ");
                    string text1 = Console.ReadLine();
                    Console.Write("Enter the key: ");
                    int key1 = Convert.ToInt32(Console.ReadLine());
                    string result1 = "";
                    foreach (char c in text1)
                    {
                        char a = char.IsUpper(c) ? 'A' : 'a';
                        result1 += (char)((c - a - key1 + 26) % 26 + a);
                    }
                    Console.WriteLine($"Decrypted text : {result1}");
                    break;
                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }
        }
    }
}