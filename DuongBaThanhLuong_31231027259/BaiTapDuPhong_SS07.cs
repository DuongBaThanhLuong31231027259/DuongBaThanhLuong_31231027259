using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuongBaThanhLuong_31231027259
{
    internal class BaiTapDuPhong_SS07
    {
        static void Main10()
        {
            int n;
            Console.Write("Enter the number of rows: ");
            n = int.Parse(Console.ReadLine());

            int[][] matrix = new int[n][];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter the number of columns for row {i + 1}: ");
                int k = int.Parse(Console.ReadLine());
                matrix[i] = new int[k];
                Console.WriteLine($"Enter {k} elements for row {i + 1}: ");
                for (int j = 0; j < k; j++)
                {
                    matrix[i][j] = int.Parse(Console.ReadLine());
                }
            }

            while (true)
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. In ra ma tran da nhap.");
                Console.WriteLine("2. In ra phan tu lon nhat, nho nhat tren moi dong va tren toan bo ma tran.");
                Console.WriteLine("3. Sap xep cac dong theo thu tu tang dan.");
                Console.WriteLine("4. In ra cac phan tu cua dong la so nguyen to.");
                Console.WriteLine("5. In ra tat ca cac vi tri xuat hien cua mot so X nhap tu nguoi dung.");
                Console.WriteLine("6. Chuyen ma tran nay ve ma tran chu nhat voi cac o thieu duoc dien bang so 0");
                Console.WriteLine("7. Exit");
                Console.Write("Choose an option: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        DisplayMatrix(matrix);
                        break;
                    case 2:
                        FindMaxMin(matrix);
                        break;
                    case 3:
                        SortRows(matrix);
                        break;
                    case 4:
                        DisplayPrimes(matrix);
                        break;
                    case 5:
                        FindPositions(matrix);
                        break;
                    case 6:
                        ConvertToRectangular(matrix);
                        break;
                    case 7:
                        return;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }

        static void DisplayMatrix(int[][] matrix)
        {
            Console.WriteLine("Matrix:");
            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine(string.Join(" ", matrix[i]));
            }
        }

        static void FindMaxMin(int[][] matrix)
        {
            int globalMax = int.MinValue;
            int globalMin = int.MaxValue;
            for (int i = 0; i < matrix.Length; i++)
            {
                int rowMax = matrix[i].Max();
                int rowMin = matrix[i].Min();
                globalMax = Math.Max(globalMax, rowMax);
                globalMin = Math.Min(globalMin, rowMin);
                Console.WriteLine($"Row {i + 1}: Max = {rowMax}, Min = {rowMin}");
            }
            Console.WriteLine($"Global Max = {globalMax}, Global Min = {globalMin}");
        }

        static void SortRows(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                Array.Sort(matrix[i]);
            }
            Console.WriteLine("Sorted matrix:");
            DisplayMatrix(matrix);
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

        static void DisplayPrimes(int[][] matrix)
        {
            for (int i = 0; i < matrix.Length; i++)
            {
                Console.Write($"Row {i + 1} primes: ");
                foreach (int num in matrix[i])
                {
                    if (IsPrime(num))
                        Console.Write(num + " ");
                }
                Console.WriteLine();
            }
        }

        static void FindPositions(int[][] matrix)
        {
            Console.Write("Enter the number to search: ");
            int x = int.Parse(Console.ReadLine());
            bool found = false;
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == x)
                    {
                        Console.WriteLine($"Found {x} at position [{i}][{j}]");
                        found = true;
                    }
                }
            }
            if (!found)
                Console.WriteLine($"{x} is not found in the matrix.");
        }

        static void ConvertToRectangular(int[][] matrix)
        {
            int maxColumns = matrix.Max(row => row.Length);
            int[,] rectangularMatrix = new int[matrix.Length, maxColumns];

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < maxColumns; j++)
                {
                    rectangularMatrix[i, j] = j < matrix[i].Length ? matrix[i][j] : 0;
                }
            }

            Console.WriteLine("Rectangular Matrix:");
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < maxColumns; j++)
                {
                    Console.Write(rectangularMatrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
 }

