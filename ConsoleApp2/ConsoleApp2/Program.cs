using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //counting elements in array

            string[] animals = { "Cat", "Alligator", "fox", "donkey", "Cat", "alligator" };
            var tc = animals.Count(s => s == "Cat");
            Console.WriteLine(tc);

            //multiD array

            int[,,] arr3d1 = new int[1, 2, 2]{
            {{1, 2}, {3, 4}} // 1 row of two-dimensional array
		};

            int[,,] arr3d2 = new int[2, 2, 2]{ // 2 rows of two-dimensional array
			{{1, 2}, {3, 4}},
            {{5, 6}, {7, 8}}
        };

            int[,,] arr3d3 = new int[2, 2, 3]{ // 2 rows of two-dimensional array
			{{1, 2, 3}, {4, 5, 6}},
            {{7, 8, 9}, {10, 11, 12}}
        };

            Console.WriteLine("arr3d2 Values");
            Console.WriteLine(arr3d1[0, 0, 0]);
            Console.WriteLine(arr3d2[0, 0, 1]);
            Console.WriteLine(arr3d3[0, 1, 2]);
            Console.WriteLine(arr3d2[0, 1, 1]);
            Console.WriteLine(arr3d2[1, 0, 0]);
            Console.WriteLine(arr3d2[1, 0, 1]);
            Console.WriteLine(arr3d2[1, 1, 0]);
            Console.WriteLine(arr3d2[1, 1, 1]);

            Console.ReadLine();
            
           
            
            Func();
        }

        static void Func()
        {
            while (true)
            {
                try
                {

                    Console.Write("Enter x:");
                    string x = Console.ReadLine();
                    var y = int.Parse(x);
                    int z;
                    z = (y * y + 2 * y + 1);

                    Console.WriteLine(z);

                   
                }

                catch
                {
                    Console.WriteLine("int please");
                }

                Console.Write("Enter q to quit");
                string continu = Console.ReadLine();


                if (continu == "q")
                {
                    break;
                }

                Console.ReadLine();




            }
            

        }
    }
}
