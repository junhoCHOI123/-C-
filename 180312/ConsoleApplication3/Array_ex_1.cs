using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_ex_1
{
    class Array_ex_1
    {
        static void Main(string[] args)
        {
            int[] arr_1 = new int[5] { 3, 5, 7, 4, 1 };
            int[] arr_2 = (int[])arr_1.Clone();     //casting해줌
            foreach(int item in arr_2)
            {
                Console.WriteLine("{0}",item);
            }
        }
    }
}
