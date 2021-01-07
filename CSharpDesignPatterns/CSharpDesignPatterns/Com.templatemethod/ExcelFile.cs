using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.Com.templatemethod
{
    public class ExcelFile : DataProcessor
    {
        public override void ReadData()
        {
            Console.WriteLine("Read data from Excel file");
        }
        public override void ProcessData()
        {
            Console.WriteLine("Process Data from Excel file");
        }
        
    }
}
