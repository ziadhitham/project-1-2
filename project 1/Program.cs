using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            // Read input values
            Console.WriteLine("Enter n1: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter n2: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            // Write prime numbers from n1 to n2
            for (int i = n1; i <= n2; i++)
            {
                if (IsPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        // Function to check if a number is prime
        static bool IsPrime(int n)
        {
            if (n <= 1) return false;
            if (n <= 3) return true;

            if (n % 2 == 0 || n % 3 == 0) return false;

            for (int i = 5; i * i <= n; i = i + 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}