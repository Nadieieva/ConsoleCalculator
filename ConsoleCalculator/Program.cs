using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class Program
    {
        private static readonly string[] operations = { "+", "-", "*", "/" };
        static void Main(string[] args)
        {

            double X = InputNumber("Enter the number X: \n");
            string Operation = InputOperation("Enter the operation ( + | - | * | / ) \n");
            double Y = InputNumber("Enter the number Y: \n");
            double result = 0;
            string conclusion = "Result of the operation is ";
            switch (Operation)
            {
                case "+":
                    result = X + Y;
                    break;
                case "-":
                    result = X - Y;
                    break;
                case "*":
                    result = X * Y;
                    break;
                case "/":
                    if (Y !=0)
                    {
                        result = X / Y;
                    }
                    else
                    {
                        Console.WriteLine("Sorry you can't divide by zero");
                        Console.ReadKey();
                    } 
                    break;
            }

            if (result !=0)
            {
                conclusion = String.Concat(conclusion, result);
                Console.WriteLine(conclusion);
                Console.ReadKey();
            }
        }

        //verifying the input 
        private static double InputNumber(string Input)
        {
            double check;
            Console.Write(Input);
            string temp = Console.ReadLine();
            while (!double.TryParse(temp, out check))
            {
                Console.WriteLine("Incorrect input. Please try again");
                Console.Write(Input);
                temp = Console.ReadLine();
            }
            return double.Parse(temp);
        }

        //verifying the operation
        private static string InputOperation(string Input)
        {
            Console.Write(Input);
            string temp = Console.ReadLine();
            while (!operations.Contains(temp))
            {
                Console.WriteLine("Incorrect input. Please try again");
                Console.Write(Input);
                temp = Console.ReadLine();
            }
            return temp;
        }

        
    }
}
