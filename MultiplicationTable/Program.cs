using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTable
{
    public class ProgramMultiplicationTable
    {
        public static void Main()
        {
            Console.Write("\nInput a Number: ");
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(number + " x " + i + " = " + number * i);
            }

        }
    }
}
