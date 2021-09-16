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
            bool endApp = false; //Bool value to determine if we are running the program or not

            while(!endApp)
            {
                Console.WriteLine("Welcome to Console Calculator! What kind of operation do you with to perform?");
                Console.WriteLine("a - Addition");
                Console.WriteLine("s - Subtraction");
                Console.WriteLine("m - Multiplication");
                Console.WriteLine("d - Division");
                string operation = Console.ReadLine();
                
                Console.WriteLine("Please enter your frist value: ");
                double input1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter your second value: ");
                double input2 = Convert.ToDouble(Console.ReadLine());
                while (input2 == 0)
                {
                    Console.WriteLine("Cannot divide by zero! Enter second number: ");
                    input2 = Convert.ToDouble(Console.ReadLine());
                }


                switch(operation)
                {
                    case "a":
                        double answer1 = Calculator.doAddition(input1, input2);
                        Console.WriteLine($"You answer is: {answer1}");
                        break;
                    case "s":
                        double answer2 = Calculator.doSubtraction(input1, input2);
                        Console.WriteLine($"You answer is: {answer2}");
                        break;
                    case "m":
                        double answer3 = Calculator.doMultiplication(input1, input2);
                        Console.WriteLine($"You answer is: {answer3}");
                        break;
                    case "d":
                        double answer4 = Calculator.doDivision(input1, input2);
                        Console.WriteLine($"You answer is: {answer4}");
                        break;

                }
            }
            return;
        }
    }
    class Calculator
    {
        public static double doAddition(double input1, double input2)
        {
            double answer = double.NaN;
            answer = input1 + input2;
            return answer;
        }
        public static double doSubtraction(double input1, double input2)
        {
            double answer = double.NaN;
            answer = input1 - input2;
            return answer;
        }

        public static double doMultiplication(double input1, double input2)
        {
            double answer = double.NaN;
            answer = input1 * input2;
            return answer;
        }
        public static double doDivision(double input1, double input2)
        {
            double answer = double.NaN;
            answer = input1 / input2;
            return answer;
        }


    }
}
