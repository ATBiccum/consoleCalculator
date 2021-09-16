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
            Console.WriteLine("Welcome to Console Calculator! What kind of operation do you with to perform?");
            Console.WriteLine("a - Addition");
            Console.WriteLine("s - Subtraction");
            Console.WriteLine("m - Multiplication");
            Console.WriteLine("d - Division");


            switch(Console.ReadLine())
            {
                case "a":
                    Console.WriteLine("Please enter your first number:");
                    int input1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter your second number:");
                    int input2 = Convert.ToInt32(Console.ReadLine());
                    int answer1 = input1 + input2;
                    Console.WriteLine($"Your Result: {answer1}");    
                    break;
                case "s":
                    Console.WriteLine("Please enter your first number:");
                    int input3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter your second number:");
                    int input4 = Convert.ToInt32(Console.ReadLine());
                    int answer2 = input3 - input4;
                    Console.WriteLine($"Your Result: {answer2}");
                    break;
                case "m":
                    Console.WriteLine("Please enter your first number:");
                    int input5 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Please enter your second number:");
                    int input6 = Convert.ToInt32(Console.ReadLine());
                    int answer3 = input5 * input6;
                    Console.WriteLine($"Your Result: {answer3}");
                    break;
                case "d":
                    Console.WriteLine("Please enter your first number:");
                    var input7 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Please enter your second number:");
                    var input8 = Convert.ToDouble(Console.ReadLine());
                    double answer4 = input7 / input8;
                    Console.WriteLine($"Your Result: {answer4}.2d");
                    break;
            }
        }
    }
}
