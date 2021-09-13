using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polyMorph

     
{
    enum roles
    {   //datatype enum
        abc, def, qwe
    }
    class Users
    {   

       
        public roles role { get; set; }



        public const int tp = 10;
        public void Enter()
        {
            Console.WriteLine("u");
            Console.ReadLine();
        }

        public Users(string name)

        {
            const int tp = 69;
            Console.WriteLine("user constructor, {0}", tp);
            this.name = name;
        }

        string name { get; }
       

    }

    class Emp:Users
    {
        public new void Enter() //overriding/virtual
        {
            Console.WriteLine("e");
            Console.ReadLine();
        }

        public Emp(string name): base(name)
        {
          
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Users e1 = new Emp("ram");
            e1.Enter();
            e1.role = roles.def;
            Console.WriteLine("@");
            Console.ReadLine();




        }
    }
}
