#region Using directives

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#endregion

namespace StructsAndEnums
{
    class Program
    {
        static void doWork()
        {
            /*
            Month first = Month.January;
            Console.WriteLine(first);
            for (int count = 0; count < 20; count++)
            {
                if (first == Month.December)
                {
                    first = Month.January;
                }
                else
                {
                    first++;
                }
                Console.WriteLine(first);
            }
            */
            Date defaultDate = new Date();
            Console.WriteLine(defaultDate);

            Date weddingAnniversary = new Date(2017, Month.July, 4);
            Console.WriteLine(weddingAnniversary);
        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
