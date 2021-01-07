using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.Com.templatemethod
{
    public abstract  class DataProcessor
    {
        public void ReadProcessandSave()
        {
            ReadData();
            ProcessData();
            SaveData();
        }

        public abstract void ReadData();
        public abstract void ProcessData();
        public void SaveData()
        {
            Console.WriteLine("Save Data to DB");
        }
    }
}
