using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_App
{
    public class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator=new Calculator();

            bool keepCalculate = true;

            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("***Welcome To The Calculator ! ***");
            Console.ResetColor();

            //The loop of the program

            while (keepCalculate)
            {
                //taking inputs from user
               
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Enter The First Number ..");
                float num1 = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter The Second Number ..");
                float num2 = float.Parse(Console.ReadLine());
              

                Console.BackgroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Chosse Operation (+) , (-) , (*) , (/) ,(%) ,(^) ");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Cyan;
                string operation = Console.ReadLine().Trim();
                float result = 0;


                //switch case for operations

                switch (operation)
                {
                    case "+":
                        result = calculator.Add(num1, num2);
                        break;
                    case "-":
                        result = calculator.Subtract(num1, num2);
                        break;
                    case "*":
                        result = calculator.multiply(num1, num2);
                        break;
                    case "/":
                        try
                        {
                            result = calculator.divide(num1, num2);
                        }
                        catch (DivideByZeroException ex)
                        {
                            Console.WriteLine(ex.Message);
                            continue;
                        }
                        break;
                    case "%":
                        result = calculator.Modulus(num1, num2);
                        break;
                    case "^":
                        result = calculator.Power(num1, num2);
                        break;
                   
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Invalid operation...");
                        continue;
                }
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Result = {result}");

                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("Calculate Again ? Y  /  N ");
                string choice = Console.ReadLine().ToUpper().Trim();
                if (choice != "Y")
                {
                    keepCalculate = false; // to end the loop 
                    Console.ResetColor();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Thank You For Using The Calculator !");
                }
                Console.ResetColor();
            }
            Console.ReadKey();

            //Thank You For Your Time ! :) 




        }
    }
}
