using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsArray
{
    class Util
    {
        public static int Sum(params int[] paramList)
        {
            Console.WriteLine("Using parameter list");
            if (paramList == null)
            {
                throw new ArgumentNullException("paramList", "Util.Sum: null parameter list");
            }
            else if (paramList.Length == 0)
            {
                throw new ArgumentException("Util.Sum: empty parameter list","paramList");
            }

            int sumTotal = 0;
            foreach(int i in paramList)
            {
                sumTotal += i;
            }
            return sumTotal;
        }

        public static int Sum(int num1 = 0, int num2 = 0, int num3 = 0, int num4 = 0)
        {
            Console.WriteLine("Using optional parameters");
            int sumTotal = num1 + num2 + num3 + num4;

            return sumTotal;
        }
    }
}
