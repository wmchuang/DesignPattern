using System;

namespace DesignPattern.结构型.桥接模式.基本
{
    public class RefinedAbstractionB : Abstraction
    {
        public override void Operation()
        {
            Method();
            base.Operation();
        }

        private void Method()
        {
            Console.WriteLine("我是抽象B");
        }
    }
}