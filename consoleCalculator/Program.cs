/* consoleCalculator
*  Tony Biccum
*  Sept 16th, 2021
*  ECET 230 Lab 2
*  
*  This program is meant to be a basic console calculator.
*  It can perform addition, subtraction, multiplication, and division. 
*  The program will ask the user what kind of operation they would like to do.
*  Then input 2 inputs.
*  Then produce a result.
* 
* Program will debug by checking initial characters, if dividing by zero, any invalid numbers. 
*/
using System;
using calculatorLibrary;

namespace consoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;                                            //Bool value to determine if we are running the program or not
            Calculator calculator = new Calculator();
            while (!endApp)
            {
                bool restartLoop = false;
                int count = 0;

                Console.WriteLine("Welcome to Console Calculator! What kind of operation do you with to perform?");
                Console.WriteLine("a - Addition");
                Console.WriteLine("s - Subtraction");
                Console.WriteLine("m - Multiplication");
                Console.WriteLine("d - Division");

                string operation = Console.ReadLine();                      //Read what operation user wishes to do save under operation variable

                //Check if user entered a desired character
                string[] operators = new string[4];                         //Fill a string with desired characters          
                operators[0] = "a";
                operators[1] = "s";
                operators[2] = "m";
                operators[3] = "d";

                while (count < 4)
                {
                    if (operation == operators[count])
                    {
                        count = 4;
                    }
                    else
                    {
                        Console.Write("Please enter a valid menu item. Try again.");
                        restartLoop = true;
                    }
                    count++;
                }


                if (restartLoop == true)                                    //Uses continue to restart the loop is bool restartLoop was triggered earlier
                {
                    continue;
                }

                //Input1 debugging
                Console.WriteLine("Please enter your frist value: ");       //Grab first value, can be anything saves it under dirty variable
                string dirtyInput1 = Console.ReadLine();

                double input1 = 0;
                while (!double.TryParse(dirtyInput1, out input1))            //Try parse converts string to a double and saves under clean new name
                {                                                           //If a unvalid character will trigger warning
                    Console.Write("Not a valid input, please try again.\n");
                    dirtyInput1 = Console.ReadLine();
                }

                //Input2 debugging
                Console.WriteLine("Please enter your second value: ");
                string dirtyInput2 = Console.ReadLine();                    //Grab first value, can be anything

                double input2 = 0;
                while (!double.TryParse(dirtyInput2, out input2))           //Will check if unvalid value and return warning
                {
                    Console.Write("Not a valid input, please try again.\n");
                    dirtyInput2 = Console.ReadLine();
                }

                while (input2 == 0)                                         //Check if we are trying to divide by zero
                {                                                           //Returns an error if trying to divide by zero
                    Console.WriteLine("Cannot divide by zero! Enter second number: ");
                    input2 = Convert.ToDouble(Console.ReadLine());
                }
                //Directs to proper calculation based on operation selected

                switch (operation)
                {
                    case "a":
                        double answer1 = calculator.doAddition(input1, input2); //If user selected a, calls addition function of calculator class
                        try
                        {
                            if (double.IsNaN(answer1))                          //Check if answer is a invalid character or not
                            {
                                Console.WriteLine("This will result in a mathematical error! Try again.");
                            }
                            else Console.WriteLine($"You answer is: {answer1}"); //Returns the answer from the function
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                        }
                        break;
                    case "s":
                        double answer2 = calculator.doSubtraction(input1, input2);//If user selected s, calls subtraction function of calculator class
                        try
                        {
                            if (double.IsNaN(answer2))
                            {
                                Console.WriteLine("This will result in a mathematical error! Try again.");
                            }
                            else Console.WriteLine($"You answer is: {answer2}"); //Returns the answer from the function
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                        }
                        break;
                    case "m":
                        double answer3 = calculator.doMultiplication(input1, input2);//If user selected m, calls multiplication function of calculator class
                        try
                        {
                            if (double.IsNaN(answer3))
                            {
                                Console.WriteLine("This will result in a mathematical error! Try again.");
                            }
                            else Console.WriteLine($"You answer is: {answer3}"); //Returns the answer from the function
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                        }
                        break;
                    case "d":
                        double answer4 = calculator.doDivision(input1, input2);//If user selected d, called division function of calculator class
                        try
                        {
                            if (double.IsNaN(answer4))
                            {
                                Console.WriteLine("This will result in a mathematical error! Try again.");
                            }
                            else Console.WriteLine($"You answer is: {answer4}"); //Returns the answer from the function
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                        }
                        break;
                } //End of switch case

                //Check if user would like to restart the program, or while loop
                Console.WriteLine("Press 'n' to close the app or any other key to continue.\n"); //Restarts the program if user enters any character other than n
                if (Console.ReadLine() == "n") endApp = true;
            }
         calculator.Finish();
         return;
        }
    }
}




