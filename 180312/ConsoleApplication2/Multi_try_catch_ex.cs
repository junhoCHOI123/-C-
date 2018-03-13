using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_try_catch_ex
{
    class Multi_try_catch_ex
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 11, 22, 33 };
            int[] arr2 = { 0, 1, 2 };
            for(int i = 0; i < arr1.Length; ++i)
            {
                try
                {
                    Console.WriteLine(arr1[i]+ "/" + arr2[1] + "=" + arr1[i] / arr2[i]);
                }
                catch(DivideByZeroException e)
                {
                    Console.WriteLine("Can't divide");
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
