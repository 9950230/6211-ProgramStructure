using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiplicationTable;
using SumOfTwoNumbers;
using Productoftwoinputs;

namespace ProgramStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;


            while(!exit)
            {
                Console.WriteLine("\nEnter '1' to Create a Multiplication Table");
                Console.WriteLine("Enter '2' to Display the Sum of Two Numbers");
                Console.WriteLine("Enter '3' to get the product of Two Numbers");
                Console.WriteLine("Enter 'exit' to exit the program\n");
                string chosenOption = Console.ReadLine();

                if (chosenOption == "1")
                {
                    ProgramMultiplicationTable.Main();
                }
                else if (chosenOption == "2")
                {
                    ProgramSumOfTwoNumbers.Main();
                }
                else if (chosenOption == "3")
                {
                    ProgramProductoftwoinputs.Main();
                }
                else if (chosenOption == "exit")
                {
                    exit = true;
                }
                else
                {
                    Console.WriteLine("\nInvalid Option. Try again.\n");
                }
            }

            
        }
    }
}
