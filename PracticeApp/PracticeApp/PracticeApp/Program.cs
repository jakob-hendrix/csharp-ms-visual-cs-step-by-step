using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ReadData()
            {
                Console.WriteLine("How many elements");
                string reply = Console.ReadLine();
                int numElements = int.Parse(reply);

                int[] data = new int[numElements];
                for (int i = 0; i < numElements; i++)
                {
                    Console.WriteLine($"Enter data for element {i}");
                    reply = Console.ReadLine();
                    int elementData = int.Parse(reply);
                    data[i] = elementData;
                }
                return data;
            }

            int[] userData = ReadData();
        }
    }
}
