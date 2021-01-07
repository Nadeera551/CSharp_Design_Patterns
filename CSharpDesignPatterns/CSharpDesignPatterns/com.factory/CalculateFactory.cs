using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com.factory
{
    public class CalculateFactory
    {
        public ICalculate GetCalculation(string type)
        {
            ICalculate obj = null;

            if( type.ToLower().Equals("add"))
            {
                obj = new Add();
            }
            else if(type.ToLower().Equals("subtract"))
            {
                obj = new Subtract();
            }
            else if (type.ToLower().Equals("divide"))
            {
                obj = new Divide();
            }
            else
            {
                Console.WriteLine("We Don't Do That"); 
            }
            return obj;
        }
    }
}
