using System;

namespace AlgorithmProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare the variables
            int a, b, i, j, flag;

            Console.WriteLine("Enter First Value: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("\nEnter Second Value: ");
            b = int.Parse(Console.ReadLine());

            // Print display message
            Console.WriteLine("\nPrime numbers between " +
                              "{0} and {1} are: ", a, b);

            for (i = a; i <= b; i++)
            {
                if (i == 1 || i == 0)
                    continue;
                flag = 1;

                for (j = 2; j <= i / 2; ++j)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }

                // flag = 1 means i is prime
                // and flag = 0 means i is not prime
                if (flag == 1)
                    Console.WriteLine(i);
            }

        }
    }
}