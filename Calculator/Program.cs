﻿namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float num1 = 0;
            float num2 = 0;

            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");
            Console.WriteLine("Type a number, then press Enter");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type another number, and then press Enter");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Choose an option from the following list:");
            Console.WriteLine("\ta - Add");
            Console.WriteLine("\ts - Subtract");
            Console.WriteLine("\tm - Multiply");
            Console.WriteLine("\td - Divide");
            Console.Write("Your option? ");

            switch (Console.ReadLine()) 
            {
                case "a":
                    Console.WriteLine($"Your result: {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    while (num2 ==0)
                    {
                        Console.WriteLine("Cannot divide by 0, please enter any number other than 0: ");
                        num2 = Convert.ToInt32(Console.ReadLine());
                    }
                    Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
                    break;
            }
            Console.Write("Press any key to close the calculator console app...");
            Console.ReadKey();
        }
    }
}