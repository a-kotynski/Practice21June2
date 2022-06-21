using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice21June2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insert second number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if (number1 > number2)
            {
                Console.WriteLine("Maximum value of the two is: {0}", number1);
            }
            else if (number1 < number2)
            {
                Console.WriteLine("Maximum value of the two is: {0}", number2);
            }
            else if (number1 == number2)
            {
                Console.WriteLine("Two numbers are equal");
            }
            else
            {
                Console.WriteLine("hmm?");
            }
        }
    }
}