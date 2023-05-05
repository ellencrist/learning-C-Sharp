using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste2
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, b, total;
            float c, d, total2;
            
            Console.WriteLine(" digite valor de a:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine(" digite valor de b:");
            b = double.Parse(Console.ReadLine());
            total = a / b;
            
            Console.WriteLine(" digite valor de c:");
            c = float.Parse(Console.ReadLine());
            Console.WriteLine(" digite valor de d:");
            d = float.Parse(Console.ReadLine());
            total2 = c / d;

            Console.WriteLine(total);
            Console.WriteLine(total2);

            Console.ReadLine();


        }
    }
}
