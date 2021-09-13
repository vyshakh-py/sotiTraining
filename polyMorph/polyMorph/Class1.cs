using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polyMorph
{
    class RefAndOut
    {
        static void Main(string[] args)
        {
            RefDemo();
            OutDemo();
            string stg = "asd";
            SetValue(ref stg);

            /*int result;
            Add(out result);
            Console.WriteLine(result);
            Console.Read();*/
        }

        private static void SetValue( ref string str)
        {
            throw new NotImplementedException();
        }

        private static void OutDemo()
        {
            int res;
            int res1;
            bool retVal = Add(out res, out res1, 3);
            Console.WriteLine(retVal);
            Console.WriteLine(res);
            Console.WriteLine(res1);
        }

        private static void RefDemo()
        {
            string s1="abc";
            SetValue( ref s1);
            Console.WriteLine(s1);

        }

        public static bool Add(out int x,out int y, int z)
        {
            y = 3;
            x = 2;
            x = x + x;
            return true;
        }

    }
}
