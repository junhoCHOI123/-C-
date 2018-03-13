using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_ex_3
{
    class Array_ex_3
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 5] { { 3, 5, 7, 4, 1 }, { 4, 5, 7, 8, 9 } };
            Console.WriteLine("{0}", arr.GetLength(0));
            Console.WriteLine("{0}", arr.GetLength(1));
            Console.WriteLine("{0}", arr.Length);
            Console.WriteLine("{0}"+ "차원",arr.Rank);


        }
    }
}
