using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace DuongBaThanhLuong_31231027259
{
    internal class Session_04
    {
        public static void Main()
        {
            //Exercise01();
            //Exercise02();
            //Exercise03();
            //Exercise04();
            //Exercise05();
            //Exercise06();
            Exercise07();
            //Exercise08();
            //Exercise09();
            //Exercise10();
            Console.WriteLine("Press any button to escape");
            Console.ReadLine();
        }
        /// <summary>
        /// Write a C# Sharp program to display certain values of the function x = y2+ 2y + 1 (using integer numbers for y, ranging from -5 to +5).
        /// </summary>
        public static void Exercise01()
        {
            for (int y = -5; y <= 5; y++)
            {
                int x = (y * y) + (2 * y) + 1;
                Console.WriteLine($"y = {y}, x = {x}");
            }
        }
        /// <summary>
        /// Write a C# Sharp program that takes distance and time (hours, minutes, seconds) as input and displays speed in kilometers per hour(km/h) and miles per hour(miles/h).
        /// </summary>
        public static void Exercise02()
        {
            Console.Write("Enter the distance in kilometers:");
            double distanceKm = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter time in hours, minutes, and seconds: ");
            Console.Write("Hours: ");
            int hours = int.Parse(Console.ReadLine());
            Console.Write("Minutes: ");
            int minutes = int.Parse(Console.ReadLine());
            Console.Write("Seconds: ");
            int seconds = int.Parse(Console.ReadLine());
            double totalTimeHours = hours + (minutes / 60.0) + (seconds / 3600.0);
            double speedKmh = distanceKm / totalTimeHours;
            double speedMph = speedKmh * 0.621371;
            Console.WriteLine($"Speed: {speedKmh:F2} km/h");
            Console.WriteLine($"Speed: {speedMph:F2} miles/h");
        }
        /// <summary>
        /// Write a C# Sharp program that takes a character as input and checks if it is a vowel, a digit, or any other symbol.
        /// </summary>
        public static void Exercise03()
        {
            Console.Write("Enter a character: ");
            char inputChar = Console.ReadKey().KeyChar;
            Console.WriteLine();
            if ("aeiouAEIOU".IndexOf(inputChar) >= 0)
            {
                Console.WriteLine($"{inputChar} is a vowel.");
            }
            else if (char.IsDigit(inputChar))
            {
                Console.WriteLine($"{inputChar} is a digit.");
            }
            else
            {
                Console.WriteLine($"{inputChar} is a symbol or consonant.");
            }
        }
        /// <summary>
        /// Write a C# Sharp program to check whether a given number is even or odd.
        /// </summary>
        public static void Exercise04()
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine($"{number} is even.");
                }
                else
                {
                    Console.WriteLine($"{number} is odd.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
        /// <summary>
        /// Write a C# Sharp program to find the largest of three numbers.
        /// </summary>
        public static void Exercise05()
        {
            Console.Write("Enter the first number: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            double num2 = double.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            double num3 = double.Parse(Console.ReadLine());
            double largest = num1;
            if (num2 > largest)
            {
                largest = num2;
            }
            if (num3 > largest)
            {
                largest = num3;
            }
            Console.WriteLine($"The largest number is: {largest}");
        }
        /// <summary>
        /// Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.
        /// </summary>
        public static void Exercise06()
        {
            Console.Write("Enter the X coordinate: ");
            double x = double.Parse(Console.ReadLine());
            Console.Write("Enter the Y coordinate: ");
            double y = double.Parse(Console.ReadLine());
            if (x > 0 && y > 0)
            {
                Console.WriteLine("The point lies in the First Quadrant");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("The point lies in the Second Quadrant");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("The point lies in the Third Quadrant");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("The point lies in the Fourth Quadrant");
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine("The point lies at the Origin");
            }
            else if (x == 0)
            {
                Console.WriteLine("The point lies on the Y-axis");
            }
            else if (y == 0)
            {
                Console.WriteLine("The point lies on the X-axis.");
            }
        }
        /// <summary>
        /// Write a program to check whether a triangle is Equilateral, Isosceles or Scalene.
        /// </summary>
        public static void Exercise07()
        {
            Console.Write("Enter the length of side A: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter the length of side B: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Enter the length of side C: ");
            double c = double.Parse(Console.ReadLine());
            if (a + b > c || b + c > a || a + c > b)
            {
                if (a == b && b == c)
                { 
                    Console.WriteLine("This is an Equilateral triangle");
                }
                else if (a == b || b == c || a == c)
                {
                    Console.WriteLine("This is an Isosceles triangle");
                }
                else
                {
                    Console.WriteLine("This is a Scalene triangle");
                }
            }
            else
            {
                Console.WriteLine("You entered a wrong value");
            }
        }
        /// <summary>
        /// Write a program to read 10 numbers and find their average and sum.
        /// </summary>
        public static void Exercise08()
        {

        }
    }
}
