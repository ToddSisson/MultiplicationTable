using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Multiplication table for what integer? ");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();


            for (int i = 1; i <= 10; ++i)
            {
                Console.Write("{0} * {1} = ", userNumber, i);
                Console.WriteLine(i * userNumber);
            }
            Console.WriteLine();
        }
    }
}
