/* consoleCalculator
*  Tony Biccum
*  Sept 16th, 2021
*  ECET 230 Lab 2
*  
*  This program is meant to be a basic console calculator.
*  It can perform addition, subtraction, multiplication, and division. 
*  The program will ask the user what kind of operation they would like to do.
*  Then ask for how many inputs. 
*  Then input all inputs.
*  Then produce a result.
* 
*/
using System;

namespace consoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Welcome to Console Calculator! What kind of operation do you with to perform?");
            Console.WriteLine("a - Addition");
            Console.WriteLine("s - Subtraction");
            Console.WriteLine("m - Multiplication");
            Console.WriteLine("d - Division");


            switch(Console.ReadLine())
            {
                case "a":
                    Console.WriteLine("Please enter your first number:");
                    var input1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter your second number:");
                    var input2 = Console.ReadLine();
                    int answer = input1 + input2;
                    Console.WriteLine($"Your Result: {answer}");    

                    break;
            }
        }
    }
}
