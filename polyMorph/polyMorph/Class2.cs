using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polyMorph

{
    class Calc
    {
        public int n1, n2;

        public Calc(int x, int y)
        {
            n1 = x;
            n2 = x;
        }

        public static Calc operator -(Calc c1)
        {
            c1.n1 = -c1.n1;
            c1.n2 = -c1.n2;
            return c1;

        }

        public void print()
        {
            Console.WriteLine(n1.ToString() + "," + n2.ToString());
        }
    }
    class OptrOverload
    {
        static void Main(string[] args)
        {
            Calc cal = new Calc(-3,4);
            cal = -cal;
            Console.WriteLine(cal);
            

            Console.Read();

        }
    }
}
