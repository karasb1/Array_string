namespace Array_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] A = new int[5];
            int[,] B = new int[3, 4];
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    B[i, j] = random.Next(1, 10);
                }
            }
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write("Enter a number: ");
                A[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Array A: ");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Array B: ");
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    Console.Write(B[i, j] + " ");
                }
                Console.WriteLine();
            }
            int Amin = A.Min();
            int Amax = A.Max();
            int Asum = A.Sum();
            int Aproduct = 1;
            int AEvenSum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                Aproduct *= A[i];
                if (A[i] % 2 == 0)
                {
                    AEvenSum += A[i];
                }
            }
            int Bmin = B[0, 0];
            int Bmax = B[0, 0];
            int Bsum = 0;
            int Bproduct = 1;
            int BOddColumnSum = 0;
            for (int i = 0; i < B.GetLength(0); i++)
            {
                for (int j = 0; j < B.GetLength(1); j++)
                {
                    if (B[i, j] < Bmin)
                    {
                        Bmin = B[i, j];
                    }
                    if (B[i, j] > Bmax)
                    {
                        Bmax = B[i, j];
                    }
                    Bsum += B[i, j];
                    Bproduct *= B[i, j];
                    if (j % 2 != 0)
                    {
                        BOddColumnSum += B[i, j];
                    }
                }
            }
            Console.WriteLine("Min of A: " + Amin);
            Console.WriteLine("Max of A: " + Amax);
            Console.WriteLine("Sum of A: " + Asum);
            Console.WriteLine("Product of A: " + Aproduct);
            Console.WriteLine("Sum of even numbers in A: " + AEvenSum);
            Console.WriteLine("Min of B: " + Bmin);
            Console.WriteLine("Max of B: " + Bmax);
            Console.WriteLine("Sum of B: " + Bsum);
            Console.WriteLine("Product of B: " + Bproduct);
            Console.WriteLine("Sum of odd columns in B: " + BOddColumnSum);


        }
    }
}