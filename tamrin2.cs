using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            float x=0,y=0;
            x = Convert.ToInt32(Console.ReadLine());
           y = Convert.ToInt32(Console.ReadLine());
            float Number1 = Math.Abs((x-y));
Double Number2=Math.Pow(Number1,Math.Abs(y));
Double Number3=Math.Sqrt(Number2);
            Console.WriteLine(Number3);
            Console.ReadKey(); 
        }
    }
}
