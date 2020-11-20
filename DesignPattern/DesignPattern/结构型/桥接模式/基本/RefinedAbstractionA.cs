using System;
using System.Collections.Generic;

namespace DesignPattern.结构型.桥接模式.基本
{
    public class RefinedAbstractionA : Abstraction
    {
        public override void Operation()
        {
            Method();
            base.Operation();
        }

        private void Method()
        {
            Console.WriteLine("我是抽象A");
        }
    }
}