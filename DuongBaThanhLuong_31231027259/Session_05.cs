using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DuongBaThanhLuong_31231027259
{
    internal class Session_05
    {
        static void Main()
        {
            //Exercise_01();
            //Exercise_02();
            //Exercise_03();
            Exercise_04();
            //Exercise_05();
            //Exercise_06();
            Console.WriteLine("Press any button to escape");
            Console.ReadKey();
        }
        /// <summary>
        /// Write a C# function to find the maximum of three numbers - Improve the next version that accept at least 1 parameter.
        /// </summary>
        public static void Exercise_01()
        {
            Console.Write("Enter x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Enter z: ");
            int z = int.Parse(Console.ReadLine());
            int maxNum = Max(x, y, z);
            Console.WriteLine("The maximum of three number is: " + maxNum);
        }
        static int Max(int a, int b, int c)
        {
            int maxNum = a;
            if (a < b)
            {
                maxNum = b;
            }
            if (a < c)
            {
                maxNum = c;
            }
            return maxNum;
        }
        /// <summary>
        /// Write a C# function to calculate the factorial of a number (a non-negative integer). The function accepts the number as an argument.
        /// </summary>
        static void Exercise_02()
        {
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            float factorial = calculateFactorial(n);
            Console.WriteLine($"The factorial of number {n} is {factorial}");
        }
        static float calculateFactorial(int n)
        {
            int demSo = 1;
            for (int i = 1; i <= n; i++)
            {
                demSo *= i;
            }
            return demSo;
        }
        /// <summary>
        /// Write a C# function that takes a number as a parameter and checks whether the number is prime or not.
        /// </summary>
        static void Exercise_03()
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            int soUoc = checkPrimeNumber(n);
            if (soUoc == 2)
            {
                Console.WriteLine($"{n} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{n} is not a prime number.");
            }
        }
        static int checkPrimeNumber(int n)
        {
            int soUoc = 0;
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                    soUoc++;
            }
            return soUoc;
        }

        /// <summary>
        /// Write a C# function to print 1. all prime numbers that less than a number(enter prompt keyboard). 2. the first N prime numbers
        /// </summary>
        static void Exercise_04()
        {
            Console.Write("Enter a number to find all primes less than that number: ");
            if (int.TryParse(Console.ReadLine(), out int limit) && limit > 1)
            {
                PrintPrimesLessThan(limit);
            }
            else
            {
                Console.WriteLine("Please enter a valid integer greater than 1.");
            }
            Console.Write("Enter the number of prime numbers to print: ");
            if (int.TryParse(Console.ReadLine(), out int count) && count > 0)
            {
                PrintFirstNPrimes(count);
            }
            else
            {
                Console.WriteLine("Please enter a valid integer greater than 0.");
            }
        }
        static void PrintPrimesLessThan(int limit)
        {
            Console.WriteLine($"Prime numbers less than {limit}:");
            for (int i = 2; i < limit; i++)
            {
                if (IsPrime(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
        static void PrintFirstNPrimes(int count)
        {
            Console.WriteLine($"The first {count} prime numbers:");
            int foundPrimes = 0;
            int number = 2;
            while (foundPrimes < count)
            {
                if (IsPrime(number))
                {
                    Console.Write(number + " ");
                    foundPrimes++;
                }
                number++;
            }
            Console.WriteLine();
        }
        static bool IsPrime(int num)
        {
            if (num < 2) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
        /// <summary>
        /// Write a C# function to check whether a number is "Perfect" or not. Then print all perfect number that less than 1000.
        /// </summary>
        static void Exercise_05()
        {

        }
        
    }
}
