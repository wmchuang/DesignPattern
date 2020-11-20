using System;

namespace DesignPattern.结构型.桥接模式.基本
{
    public class ConcreteImplementorA : Implementor
    {

        public void OperationImp()
        {
            Console.WriteLine("我是实现A");
        }
    }
}