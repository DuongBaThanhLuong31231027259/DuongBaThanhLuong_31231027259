using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace DuongBaThanhLuong_31231027259
{
    internal class Session_06
    {
        static void Main5()
        {
            //Exercise01();
            Exercise02();
            //Exercise03();
            //Exercise04();
            //Exercise05();
            //Exercise06();
            Console.WriteLine();
            Console.WriteLine("Press any button to escape");
            Console.ReadKey();
            static void Exercise01()
            {
                Console.Write("Nhap so phan tu trong mang: ");
                int n = int.Parse(Console.ReadLine());
                int[] a = new int[n];
                NhapMangBangCom(a);
                InMang(a);
                IncreaseItems(a, 2);
                Console.WriteLine();
                InMang(a);
                Console.WriteLine();
                Console.WriteLine("Tong cua mang: " + SumOfArray(a));
                Console.WriteLine("Trung binh cua mang la: " + AverageOfArray(a));
                Console.WriteLine("Gia tri nho nhat cua mang la: " + MinOfArray(a));
                Console.WriteLine("Gia tri lon nhat cua mang la: " + MaxOfArray(a));
            }
            static void NhapMangBangCom(int[] a)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    Console.Write($"Enter a number: ");
                    a[i] = int.Parse(Console.ReadLine());
                }
            }
            static void InMang(int[] a)
            {
                Console.WriteLine("Array cua ban: ");
                foreach (int i in a)
                {
                    Console.Write(i + " ");
                }
            }
            static void IncreaseItems(int[] a, int val)
            {
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] += val;
                }
            }
            static int SumOfArray(int[] a)
            {
                int tong = 0;
                foreach (int i in a)
                {
                    tong += i;
                }
                return tong;
            }
            static double AverageOfArray(int[] a)
            {
                return a.Average();
            }
            static int MinOfArray(int[] a)
            {
                return a.Max();
            }
            static int MaxOfArray(int[] a)
            {
                return a.Min();
            }
            // Create a random integer values array, then create functions that:
            // 1. to calculate the average value of array elements
            // 2.to test if an array contains a specific value.
            // 3.to find the index of an array element.
            // 4.to remove a specific element from an array.
            // 5.to find the maximum and minimum value of an array.
            // 6.to reverse an array of integer values.
            // 7.to find duplicate values in an array of values.
            // 8.to remove duplicate elements from an array.
            static void Exercise02()
            {
                Random random = new Random();
                Console.Write("Nhap mang cua ban: ");
                int n = int.Parse(Console.ReadLine());
                int[] a = new int[n];
                for (int i = 0; i < a.Length; i++)
                {
                    a[i] = random.Next(0, 101);
                    Console.Write(a[i] + " ");
                }
                Console.WriteLine();
                Console.WriteLine("Gia tri trung binh cua array la: " + CalculateAverageValue(a));
                Console.Write("Nhap gia tri can kiem tra: ");
                int b = int.Parse(Console.ReadLine());
                bool ketqua = CheckSpecificValue(a, b);
                Console.WriteLine("Array cua ban co chua gia tri {0} khong? Cau tra loi la {1} " , b, ketqua);
                Console.Write("Nhap gia tri can tim index: ");
                int c = int.Parse(Console.ReadLine());
                int ketqua1 = FindIndex(a, c);
                Console.WriteLine("Index cua {0} la {1} ", c, ketqua1);

                static double CalculateAverageValue(int[] a)
                {
                    return a.Average();
                }
                static bool CheckSpecificValue(int[] a, int value)
                {
                    return a.Contains(value);
                }
                static int FindIndex(int[] a, int element)
                {
                    return Array.IndexOf(a, element);
                }
            }
        }
    }
}

