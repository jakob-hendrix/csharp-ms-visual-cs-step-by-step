using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsArray
{
    class Program
    {
        static void doWork()
        {
             Console.WriteLine(Util.Sum(5,5,5,5));
            Console.WriteLine(Util.Sum(5, 5, 5));
            Console.WriteLine(Util.Sum(5, 5, 5, 5, 5));
        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
