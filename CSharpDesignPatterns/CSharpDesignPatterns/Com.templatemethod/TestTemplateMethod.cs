using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.Com.templatemethod
{
    class TestTemplateMethod
    {
        static void Main()
        {
            ExcelFile obj = new ExcelFile();
            obj.ReadProcessandSave();
            //obj.ReadData();
            //obj.ProcessData();
            //obj.SaveData();

            TextFile obj2 = new TextFile();
            obj2.ReadProcessandSave();
            //obj2.ReadData();
            //obj2.ProcessData();
            //obj2.SaveData();
        }
    }
}
