using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace try_catch_ex
{
    class try_catch_ex
    {
        static void Main(string[] args)
        {
            String str = null;
            try
            {
                Console.WriteLine(str.ToString());
                Console.WriteLine("Program Terminated");
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
