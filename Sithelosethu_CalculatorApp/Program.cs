using System;

namespace Sithelosethu_CalculatorApp
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("You are welcome to use my calculator");
            Console.WriteLine("Insert any two numbers that you want to work with--");
            Console.WriteLine("First Value--");
            // Prompt correct for a value and makesure to set parameters for right input
            int Value1;
            while (!int.TryParse(Console.ReadLine(), out Value1) || Value1 <= 0)
            {
                Console.WriteLine("Invalid Input, makesure value is greater than zero and is an integer");
            }
            // Prompt for the second value
            Console.WriteLine("Second Value");
            int Value2;
            //Parse the string input
            while (!int.TryParse(Console.ReadLine(), out Value2) || Value2 <= 0)
            {
                Console.WriteLine("Incorrect Input, makesure value is greater than zero and an integer");


                // Operation symbol

                Console.WriteLine("Select the symbol you want to use from these '+' '-' '*' '/' '%'");
                string symbol = Console.ReadLine();

                switch (symbol)
                {
                    case "+":
                        int sum = Value1 + Value2;
                        Console.WriteLine("The sum of " + Value1 + " and " + Value2 + " is " + sum);
                        break;
                    case "-":
                        int minus = Value1 - Value2;
                        Console.WriteLine(Value1 + " minus " + Value2 + " is " + minus);
                        break;
                    case "*":
                        int product = Value1 * Value2;

                        Console.WriteLine("The multiplication of " + Value1 + " and " + Value2 + " is " + product);
                        break;
                    case "/":
                        //Additional code to handle invalid input just incase
                        if (Value2 == 0)
                        {
                            Console.WriteLine("Division by zero is not allowed.");
                        }
                        else
                        {
                            double division = (double)Value1 / Value2; // Cast to double for precision
                            Console.WriteLine(Value1 + " divided by " + Value2 + " is " + division);
                        }
                        break;
                    case "%":
                        if (Value2 == 0)
                        {
                            Console.WriteLine("Division by zero is not allowed");
                        }
                        else
                        {
                            int modulas = Value1 % Value2;
                            Console.WriteLine("Modulus of " + Value1 + " and " + Value2 + " is " + modulas);
                        }
                        break;
                    default:
                        Console.WriteLine("Incorrect input, please try again");
                        break;
                }
            }
        }
    }
}