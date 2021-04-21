using System;

namespace DesignPattern.行为型.访问者模式.基本
{
    /// <summary>
    /// 具体元素A
    /// </summary>
    public class ElementA : Element
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }

        public override void Print()
        {
            Console.WriteLine("我是元素A");
        }
    }
}