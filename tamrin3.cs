using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Project
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, c = 0;
             a=Convert.ToInt32(Console.ReadLine());
             b=Convert.ToInt32(Console.ReadLine());
             c=Convert.ToInt32(Console.ReadLine());
            int Num1 = Convert.ToInt32(a);
            int Num2 = Convert.ToInt32(b);
            int Num3 = Convert.ToInt32(c);
            if (a + b > c && a + c > b && b + c > a)
            {
                Mohit(a, b, c);
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
            private static void Mohit(int x, int y, int z) {
                int w = x + y + z;
                Console.WriteLine(w);
            Console.ReadKey();
            }

    }
}//class
