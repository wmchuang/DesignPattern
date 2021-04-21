using System;

namespace DesignPattern.行为型.访问者模式.基本
{
    /// <summary>
    ///     具体元素B
    /// </summary>
    public class ElementB : Element
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override void Print()
        {
            Console.WriteLine("我是元素B");
        }
    }
}