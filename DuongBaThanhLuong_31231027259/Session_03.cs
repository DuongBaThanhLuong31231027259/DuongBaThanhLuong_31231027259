using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuongBaThanhLuong_31231027259
{
    internal class Session_03
    {
        public static void Main()
        {
            Exercise01();
            //Exercise02();
            //Exercise03();
            Console.WriteLine("Press any button to escape");
            Console.ReadLine();
        }
        public static void Exercise01()
        {
            Console.Write("Nhap so do C = ");
            float sodoC = float.Parse(Console.ReadLine());
            float sodoK = sodoC + 273;
            float sodoF = (sodoC * 18) / 10 + 32;
            Console.WriteLine("So do K la = " + sodoK);
            Console.WriteLine("So do F la = " + sodoF);
            Console.ReadKey();
        }
        public static void Exercise02() 
        {
            Console.Write("Nhap ban kinh = ");
            float r = float.Parse(Console.ReadLine());
            double surface = 4 * Math.PI * Math.Pow(r, 2);
            double volume = 4 / 3 * Math.PI * Math.Pow(r, 3);
            Console.WriteLine("Surface cua hinh cau la = " + surface);
            Console.WriteLine("Volume cua hinh cau la = " + volume);
            Console.ReadKey();
        }
        public static void Exercise03()
        {
            Console.Write("Nhap chu so thu nhat = ");
            float num1 = float.Parse(Console.ReadLine());
            Console.Write("Nhap chu so thu hai = ");
            float num2 = float.Parse(Console.ReadLine());
            float adding = num1 + num2;
            float subtracting = num1 - num2;
            double multiplying = num1 * num2;
            double dividing = num1 / num2;
            float mod = num1 % num2;
            Console.WriteLine("Ket qua phep cong = " + adding);
            Console.WriteLine("Ket qua phep tru = " + subtracting);
            Console.WriteLine("Ket qua phep nhan = " + multiplying);
            Console.WriteLine("Ket qua phep chia = " + dividing);
            Console.WriteLine("Ket qua phep mod = " +  mod);    
            Console.ReadKey();  
        }

    }
}
