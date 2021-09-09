using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Car
    {
        public Car()
        {

        }

        private string maker;
        private string model { get; set; }
        private string abc { get; set; }
        private int def { get; set; }
        private int xyz { get; set; }
        public string abcd { get; set; }
       

        public string Property
        {
            get { return maker; }
            set { maker = value; }
        }
    }


class Program
    {
        
        static void Main(string[] args)
        {
           

            int num = 100;
            float rate = 10.2f;
            decimal amount = 100.50M;
            char code = 'C';
            bool isValid = true;
            string name = "Steve";

            Console.WriteLine(num);
            Console.WriteLine(rate);
            Console.WriteLine(amount);
            Console.WriteLine(code);
            Console.WriteLine(isValid);
            Console.WriteLine(name);

           


          
            int i = 10, j = 20;

            if (i < j)
            {
                Console.WriteLine("i is less than j");
            }

            if (i > j)
            {
                Console.WriteLine("i is greater than j");
            }

         

            
            int x = 5;

            switch (x)
            {
                case 1:
                    Console.WriteLine("Value of x is 1");
                    break;
                case 10:
                    Console.WriteLine("Value of x is 10");
                    break;
                case 3:
                    Console.WriteLine("value of x is 3");
                    break;
                case 4:
                    Console.WriteLine("Value of x is 4");
                    break;
                default:
                    Console.WriteLine("No match");
                    break;
            }


            Program p1 = new Program();
            p1.Paint(20);
        }
        void Paint(int z)
        {
            for (int i = z; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine(' ');
            }
        }
    }
}
