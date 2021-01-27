using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Д.з__1_Alif
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            //double a = 16.80;
            //double b = 12.40;
            //Console.WriteLine(Math.Sqrt(a*b));

            //2
            //double a, b, c;
            //a = 1.40;
            //b = -5.50;
            //c = 0.60;
            //double ac = a - c;
            //double bc = c - b;
            //Console.WriteLine(ac+bc);


            //3
            //double x1 = -6.20;
            //double y1 = 5.20;
            //double x2 = 2.10;
            //double y2 = 9.80;
            //Console.WriteLine(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)));


            //4
            //int a = 4;
            //int b = 1;
            //int c = a;
            //a = b;
            //b = c;
            //Console.WriteLine($"{a}{b}");


            //5
            //int s = 10985;
            //int m = s / 60;
            //Console.WriteLine(m);


            //6
            int k = 202;
            int d = k % 7;

            switch (d)
            {
                case 0:
                    Console.WriteLine($"{0} - Воскресенье");
                    break;
                case 1:
                    Console.WriteLine($"{1} - понедельник");
                    break;
                case 2:
                    Console.WriteLine($"{2} - вторник");
                    break;
                case 3:
                    Console.WriteLine($"{3} - среда");
                    break;
                case 4:
                    Console.WriteLine($"{4} - четверг");
                    break;
                case 5:
                    Console.WriteLine($"{5} - пятница");
                    break;
                case 6:
                    Console.WriteLine($"{6} - суббота");
                    break;
                default:
                    break;

            }
        }
    }
}
