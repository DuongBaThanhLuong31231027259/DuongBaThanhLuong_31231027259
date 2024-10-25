
namespace DuongBaThanhLuong_31231027259
{
    internal class Session_02
    {
        public static void Main1()
        {
            //Question_01();
            //Question_02();
            //Question_03();
            //Question_04();
            //Question_05();
            //Question_06();
            //Question_07();
            //Question_08();
            //Question_09();
            Question_10();


            Console.WriteLine("Press any key to stop");
            Console.ReadKey();
        }
        ///
        /// to Add / Sum Two Numbers
        ///
        public static void Question_01()
        {
            Console.Write("Enter the first number = ");
            int a1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number = ");
            int b1 = int.Parse(Console.ReadLine());  
            int sum = a1 + b1;
            int product = a1 * b1;
            Console.WriteLine($"{a1} + {b1} = {sum}");
            Console.WriteLine($"{a1} * {b1} = {product}");

        }
        /// <summary>
        /// to Swap Values of Two Variables
        /// </summary>
        public static void Question_02()
        {
            Console.Write("Enter the first number = ");
            int a2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number = ");
            int b2 = int.Parse(Console.ReadLine());
            (a2, b2) = (b2, a2);
            Console.WriteLine($"Tong 2 so truoc khi doi la = {a2} + {b2} ");
            Console.WriteLine($"Tong 2 so sau khi doi la = {b2} + {a2} ");
        }
        /// <summary>
        /// to Multiply two Floating Point Numbers
        /// </summary>
        public static void Question_03()
        {
            Console.Write("Enter the first number = ");
            float a3 = float.Parse(Console.ReadLine());
            Console.Write("Enter the second number = ");
            float b3 = float.Parse(Console.ReadLine());
            float Ket_qua = a3 * b3;
            Console.WriteLine($"Tong cua 2 so la = {a3} * {b3} = {Ket_qua} ");
        }
        /// <summary>
        /// to convert feet to meter
        /// </summary>
        public static void Question_04()
        {
            Console.Write("Nhap so feet = ");
            float feet = float.Parse(Console.ReadLine());
            double doi_ra_met = feet * 0.3048;
            Console.WriteLine("{0} feet = {1} met", feet, doi_ra_met);
        }
        /// <summary>
        /// to convert Celsius to Fahrenheit and vice versa
        /// </summary>
        public static void Question_05()
        {
            Console.Write("Nhap so do C = ");
            float do_C = float.Parse(Console.ReadLine());
            float doi_ra_do_F = (do_C * 5 / 9) + 32;
            Console.WriteLine("{0} do C = {1} do F ", do_C, doi_ra_do_F);
            Console.Write("Nhap so do F = ");
            float do_F = float.Parse(Console.ReadLine());
            float doi_ra_do_C = (do_F - 32) * 5 / 9;
            Console.WriteLine("{0} do F = {1} do C ", do_F, doi_ra_do_C);
        }
        /// <summary>
        /// to find the Size of data types
        /// </summary>
        public static void Question_06()
        {
            Console.WriteLine("Size of int: " + sizeof(int));
            Console.WriteLine("Size of float: " + sizeof(float));
            Console.WriteLine("Size of double: " + sizeof(double));
            Console.WriteLine("Size of decimal: " + sizeof(decimal));
            Console.WriteLine("Size of long: " + sizeof(long));
            Console.WriteLine("Size of short: " + sizeof(short));
        }
        /// <summary>
        /// to Print ASCII Value (tip: read character, print number of this char)
        /// </summary>
        public static void Question_07()
        {
            Console.Write("Input the character: ");
                char character = char.Parse(Console.ReadLine());
            int ASCII = (int)character;
            Console.WriteLine("ASCII value: " + ASCII);
        }
        /// <summary>
        /// to Calculate Area of Circle
        /// </summary>
        public static void Question_08()
        {
            Console.Write("Nhap ban kinh hinh tron (r) = ");
            float r = float.Parse(Console.ReadLine());
            double S = Math.Pow(r, 2) * Math.PI;
            Console.WriteLine("Dien tich hinh tron la = " + S);
        }
        /// <summary>
        /// to Calculate Area of Square
        /// </summary>
        public static void Question_09()
        {
            Console.Write("Nhap canh hinh vuong = ");
            float c = float.Parse(Console.ReadLine());
            double S = c * c;
            Console.WriteLine("Dien tich hinh vuong la = " + S);
        }
        /// <summary>
        /// to convert days to years, weeks and days
        /// </summary>
        public static void Question_10()
        {
            Console.Write("Enter the number of days: ");
            int numofDay = int.Parse(Console.ReadLine());
            int year = numofDay / 365;
            int week = (numofDay % 365) / 7;
            int day = (numofDay % 365) % 7;
            Console.WriteLine($"Result: {year} year(s), {week} week(s), {day} day(s)");
        }
    }
}
