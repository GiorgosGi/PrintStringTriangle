using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintStringTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a string: ");
            string text = Console.ReadLine();
            Console.WriteLine();

            int j = 1;
            for (int i = text.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(text.Substring(i, j));
                j++;
            }
            Console.WriteLine();
        }
    }
}
