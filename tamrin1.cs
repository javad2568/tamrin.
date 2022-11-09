using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class test
    {
        static void Main(string[] args)
        {
            int Number=int.Parse(Console.ReadLine());
            int Num=Convert.ToInt32(Number);
            Number=Number+10;
            Console.WriteLine(Number);
            Console.ReadKey();
        }
    }
}
