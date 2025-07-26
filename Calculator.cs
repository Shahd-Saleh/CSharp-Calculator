using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_App
{
    public class Calculator
    {
        //first operation
        public float Add(float num1,float num2)
        {
            return num1 + num2;
        }

        //second operation
        public float Subtract(float num1, float num2)
        {
            return num1 - num2;
        }

        //third operation
        public float multiply(float num1, float num2)
        {
            return num1 * num2;
        }

        //fourth operation
        public float divide(float num1, float num2)
        {
            if (num2 == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                throw new DivideByZeroException("Cannot divide by zero.");
            }
            return num1 / num2;
        }

        //fifth operation
        public float Modulus(float num1, float num2)
        {
            return num1 % num2;
        }
        //sixth operation
        public float Power(float num1, float num2)
        {
            return (float)Math.Pow(num1, num2);
        }
      

    }
}
