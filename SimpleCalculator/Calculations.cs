using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleCalculator
{
    class Calculations
    {
        public int  Calculate(int operation, int num1,int num2)
        {
            int result = 0;
            switch (operation)
            {
                case 1:
                    result =  num1 + num2;
                    break;
                case 2:
                    result =  Math.Abs(num1 - num2);
                    break;
                case 3:
                    result =  num1 * num2;
                    break;
                case 4:
                    result =  num1 / num2;
                    break;
                default:
                    Console.WriteLine("Enter Correct operation");
                    break;
            }
            return result;
        }
    }
}
