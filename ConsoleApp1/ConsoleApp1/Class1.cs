using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class User
    {
        public string name { get; set; }
    }

    class class1
    {
        public void Trial()
        {
            User u1 = new User();
            Console.WriteLine(typeof(User));
            Console.WriteLine(u1 is User);

            Console.ReadLine();
        }
    }
}
