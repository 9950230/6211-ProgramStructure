using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productoftwoinputs
{
    public class ProgramProductoftwoinputs
    {
        public static void Main()
        {
            Console.Write("\nInput first number: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Input second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("\n" + firstNumber + " x " + secondNumber + " = " + firstNumber * secondNumber);
        }
    }
}
