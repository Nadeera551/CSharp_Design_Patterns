using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpDesignPatterns.com.singleton
{
    class TestLogger
    {
        static void Main()
        {
            Console.WriteLine("------singleton------");
            Logger obj1 = Logger.GetInstance();
            Logger obj2 = Logger.GetInstance();
            Console.WriteLine(obj1.GetHashCode());
            Console.WriteLine(obj2.GetHashCode());


            Console.WriteLine("-----Non singleton-----");
            Test obj3 = new Test();
            Test obj4 = new Test();
            Console.WriteLine(obj3.GetHashCode());
            Console.WriteLine(obj4.GetHashCode());
        }
    }
    class Test
    {

    }
}
