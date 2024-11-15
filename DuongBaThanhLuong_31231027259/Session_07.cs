using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DuongBaThanhLuong_31231027259
{
    internal class Session_07
    {
        static void Main6()
        {
            Console.WriteLine("So nguyen la: {0:F5}", FindX(8, 10));
            int[] counts = CharCharChar("Tss5!");
            Console.WriteLine(counts[0]);
            Console.Write("Input number of rows: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Input number of collumns: ");
            int col = int.Parse(Console.ReadLine());
            int[,] table = RandomTable(row, col);
            PrintTable(table);
            //Console.Write("Input the row index: ");
            //int rowIndex = int.Parse(Console.ReadLine());
            //PrintTableRow(table, rowIndex);
            //Console.Write("Input the col index: ");
            //int colIndex = int.Parse(Console.ReadLine());
            //PrintTableCol(table, colIndex);
            PrintTable(Transpose(table));


        }
        public static float FindX(float a, float b)
        {
            float x = -b / a;
            return x;
        }
        public static int[] CharCharChar(string s)
        {
            int[] counts = new int[3] { 0, 0, 0 };
            foreach (char c in s)
            {
                if ('a' <= c && c <= 'z')
                {
                    counts[0]++;
                }
                else if ('A' <= c && c <= 'Z')
                {
                    counts[1]++;
                }
                else if ('0' <= c && c <= '9')
                {
                    counts[2]++;
                }
            }
            return counts;
        }

        public static int[,] RandomTable(int r, int c)
        {
            Random rangen = new Random();
            int[,] table = new int[r, c];
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    table[i, j] = rangen.Next(1001);
                }
            }
            return table;
        }

        public static void PrintTable(int[,] table)
        {
            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    Console.Write(table[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static void PrintTableRow(int[,] table, int row)
        {
            if (row < 0 || table.GetLength(0) < row || table.GetLength(0) == 0)
            {
                Console.WriteLine("Input error");
                return;
            }
            for (int i = 0; i <= table.GetLength(1) - 1; i++)
            {
                Console.Write(table[row - 1, i] + " ");
            }
        }

        public static void PrintTableCol(int[,] table, int col)
        {
            if (col < 0 || table.GetLength(0) < col || table.GetLength(0) == 0)
            {
                Console.WriteLine("Input error");
                return;
            }
            for (int i = 0; i <= table.GetLength(0) - 1; i++)
            {
                Console.WriteLine(table[i, col - 1]);
            }
        }

        public static int MaxValTable(int[,] table)
        {
            int max = table[0, 0];
            for (int i = 0; i <= table.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < table.GetLength(1) - 1; j++)
                {
                    if (table[i, j] > max)
                    { max = table[i, j]; }
                }
            }
            return max;
        }

        public static int MinRow(int[,] table, int row)
        {
            row -= 1;
            int min = table[row, 0];
            for (int i = 0; i < table.GetLength(1) - 1; i++)
            {
                if ((table[row, i] < min))
                {
                    min = table[row, i];
                }
            }
            return min;
        }
        public static int MinCol(int[,] table, int col)
        {
            col -= 1;
            int min = table[0, col];
            for (int i = 0; i < table.GetLength(0) - 1; i++)
            {
                if ((table[i, col] < min))
                {
                    min = table[i, col];
                }
            }
            return min;
        }

        public static int[,] Transpose(int[,] table)
        {
            int nrow = table.GetLength(1);
            int ncol = table.GetLength(0);
            int[,] table1 = new int[nrow, ncol];
            for (int i = 0; i <= nrow - 1; i++)
            {
                for (int j = 0; j <= ncol - 1; j++)
                {
                    table1[i, j] = table[j, i];
                }
            }
            return table1;
        }
    }
}


