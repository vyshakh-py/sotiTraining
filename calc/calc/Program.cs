using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc();
        }

        static void Calc()
        {
            Console.Write("enter no.:");
            int x=Convert.ToInt32(Console.ReadLine());

      

            Console.Write("enter no.:");
            int y= Convert.ToInt32(Console.ReadLine());
        

            Console.WriteLine( x+y);

            Console.ReadLine();
        }
    }
}
