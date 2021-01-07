using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com.factory
{
    class Test
    {
        static void Main()
        {
            Console.WriteLine("Enter First Number");
            string input = Console.ReadLine();
            double num1, num2;
            bool result = Double.TryParse(input, out num1);

            if(!result)
            {
                Console.WriteLine("Please Enter a Number");
                return;
            }

            Console.WriteLine("Enter Second Number");
            result = Double.TryParse(Console.ReadLine(), out num2);
            if (!result)
            {
                Console.WriteLine("Please Enter a Number");
                return;
            }

            Console.WriteLine(" Enter Add , Subtract or Divide");
            CalculateFactory factory = new CalculateFactory();
            ICalculate obj = factory.GetCalculation(Console.ReadLine());
            //Divide obj = new Divide();
            obj.Calculate(num1, num2);
            Main();


        }

    }
}
