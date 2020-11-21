using System;

namespace DesignPattern.行为型.模板方法模式.基本
{
    public class ConcreteClassA : AbstractClass
    {

        protected override void Method2()
        {
            Console.WriteLine("我是ConcreteClassA的Method2");
        }
    }
}