// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment
{
    internal class ass2
    {
        static void Main(string[] args)
        {
            Console.Write("first number: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("second number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int minNumber;
            if (m < n)
            {
                minNumber = m;
            }
            else
            {
                minNumber = n;
            }
            Console.WriteLine("minimum number is:" + minNumber);
            Console.ReadLine();
        }
    }
}
