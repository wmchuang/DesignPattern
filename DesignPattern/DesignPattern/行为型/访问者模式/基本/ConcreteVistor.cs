using System;

namespace DesignPattern.行为型.访问者模式.基本
{
    /// <summary>
    ///     具体访问者
    /// </summary>
    public class ConcreteVisitor : IVisitor
    {
        public void Visit(ElementA a)
        {
            a.Print();
            Console.WriteLine(DateTime.Now);
        }

        public void Visit(ElementB b)
        {
            b.Print();
        }
    }
}