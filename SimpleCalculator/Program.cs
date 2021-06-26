using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2,operation,result;
            Console.WriteLine("Which Operation do you want to perform?\n");
            Console.WriteLine("1.Addition\n2.Subtraction\n3.Multiplication\n4.Division");
            operation = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter first number\n");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number\n");
            num2 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(operation + " " + num1 + " " + num2);
            Calculations obj = new Calculations();
            result = obj.Calculate(operation,num1,num2);
            Console.WriteLine("The result is " + result);
            Console.Writeline("Thanks for using");


        }
    }
}
