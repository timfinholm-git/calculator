using System.Diagnostics;
using System.Transactions;

namespace CalculatorLibrary
{
    public class Calculator
    {
        public Calculator() 
        {
            StreamWriter logFile = File.CreateText("calculator.log");
            Trace.Listeners.Add(new TextWriterTraceListener(logFile));
            Trace.AutoFlush = true;
            Trace.WriteLine("Starting calculator log");
            Trace.WriteLine(String.Format("Started {0}", System.DateTime.Now.ToString()));

        }
        public static double DoOperation(double num1, double num2, string op)
            {
                double result = double.NaN;

                switch (op)
                {
                    case "a":
                        result = num1 + num2;
                        break;
                    case "s":
                        result = num1 - num2;
                        break;
                    case "m":
                        result = num1 * num2;
                        break;
                    case "d":
                        if (num2 != 0)
                        {
                            result = num1 / num2;
                        }
                        break;
                    default:
                        break;
                }
                return result;
        }
    }
}