using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops
{   class shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }
    
    class Triangle
    {
        string kind;
        static long CreateDate;

        static Triangle() // called only once even with multiple objects
        {
            CreateDate = DateTime.Now.Ticks;
            Console.WriteLine("called static constructor");
        }

        /* private Trriangle(double area)
         {
         }*/
        public Triangle(double x, double y): this(x)
        {
            Width = x;
            Height = y;
        }

        public Triangle(double x):base()
        {
            //Width = x;
            
        }

        
        /*using sub class get set
        public double Width { get; set; }
        public double Height { get; set; }*/
    }
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t1 = new Triangle(3.4,4.5);
            Triangle t2 = t1;
            Console.WriteLine(t1 == t2);
            

            Console.Read();

        }
    }
}
