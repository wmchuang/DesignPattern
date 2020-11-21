using System;
using DesignPattern.创建型;
using DesignPattern.结构型;
using DesignPattern.行为型;

namespace DesignPattern
{
    class Program
    {
        static void Main()
        {
           CreateType.Run();

           //  StructType.Run();

            // BehavioralType.Run();

            Console.WriteLine("设计模式O(∩_∩)O!");
            Console.ReadKey();
        }

        private static void Print(string name)
        {
            Console.WriteLine(Environment.NewLine);
            Console.Write("*".PadRight(10, '*'));
            Console.Write(name);
            Console.Write("*".PadLeft(10, '*'));
            Console.WriteLine(Environment.NewLine);
        }
    }
}