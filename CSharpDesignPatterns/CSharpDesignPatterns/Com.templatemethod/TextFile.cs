using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.Com.templatemethod
{
    public class TextFile : DataProcessor
    {
        public override void ReadData()
        {
            Console.WriteLine("Read data from Text File");
        }
        public override void ProcessData()
        {
            Console.WriteLine("Process Data from Text File");
        }
        
    }
}
