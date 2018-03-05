using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _180305ps6_io1
{
    class Program
    {
        static void Main(string[] args)
        {
            string strName;
            Console.Write("당신의 이름은 ? ");
            strName = Console.ReadLine();

            Console.WriteLine("Hello, {0}!",strName);
        }
    }
}
