using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hier_ex
{
    class A
    {
        public void PrintA()
        {
            Console.WriteLine("A class function");
        }
    }
    class B : A
    {
        public void PrintB()
        {
            Console.WriteLine("B class function");
        }
    }
    class hier_ex
    {

        static void Main(string[] args)
        {
            B b = new B();
            b.PrintA();
            b.PrintB();
        }
            
    }
}
