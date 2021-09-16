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
                
                switch(Console.ReadLine())
                {
                    case "a":
                        
                        Calculator.doAddition(addInput1, addInput2);
                        break;
                    case "s":

                        break;
                    case "m":

                        break;
                    case "d":

                        while(input8 == 0)
                        {
                            Console.WriteLine("Cannot divide by zero! Enter second number: ");
                            input8 = Convert.ToDouble(Console.ReadLine());
                        }
                        double answer4 = input7 / input8;
                        Console.WriteLine($"Your Result: {answer4}");
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

            return answer;
        }
        public static double doSubtraction(double input1, double input2)
        {
            double answer = double.NaN;

            return answer;
        }

        public static double doMultiplication(double input1, double input2)
        {
            double answer = double.NaN;

            return answer;
        }
        public static double doDivision(double input1, double input2)
        {
            double answer = double.NaN;

            return answer;
        }


    }
}
