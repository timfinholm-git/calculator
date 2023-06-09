﻿using CalculatorProgram;
using CalculatorLibrary;
using System;

namespace CalculatorProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;

            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");
            
            while (!endApp)
            {
                Calculator calculator = new Calculator();
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;
                Console.Write("Type a number, then press Enter: ");
                numInput1 = Console.ReadLine();
                double cleanNum1 = 0;
                bool isNumber1 = double.TryParse(numInput1, out cleanNum1);
                while (isNumber1 != true)
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    numInput1 = Console.ReadLine();
                    isNumber1 = double.TryParse(numInput1, out cleanNum1);
                }
                
                Console.Write("Type another number, and then press Enter: ");
                numInput2 = Console.ReadLine();
                double cleanNum2 = 0;
                bool isNumber2 = double.TryParse(numInput2, out cleanNum2);
                while (isNumber2 != true)
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    numInput2 = Console.ReadLine();
                    isNumber2 = double.TryParse(numInput2, out cleanNum2);
                }
                Console.WriteLine("Choose an operator from the following list:");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.Write("Your option? ");

                string op = Console.ReadLine();

                try 
                {
                    result = calculator.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error.\n");

                    }
                    else Console.WriteLine("Your result: {0:0.##}\n", result);
                }
                catch(Exception e) 
                {
                    Console.WriteLine("An exception occorred while trying to do the math.\n - Details: " + e.Message);
                }
                Console.Write("Press 'n' and Enter to close the calculator console app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n")
                {
                    endApp = true;
                }
                Console.WriteLine("\n");

                calculator.Finish();
            }

            
            return;
        }
    }
}