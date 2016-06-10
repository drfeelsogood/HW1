using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ca1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[10];
            Random rnd = new Random();
            int number;
            int smallest = 0;

            for (int i = 0; i < myArray.Length; i++)
            {
                number = rnd.Next(0, 20);
                if (!myArray.Contains(number))
                {
                    myArray[i] = number;
                    Console.WriteLine(myArray[i]);
                }
                else
                {
                    i--;
                }
                smallest = myArray.Min();
            }
            Console.WriteLine("Smallest number is: " + smallest.ToString());
            Console.ReadLine();
        }
    }
}
