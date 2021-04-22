using System;

namespace DesignPattern.结构型.装饰模式.基本
{
    /// <summary>
    /// 具体的对象
    /// </summary>
    public class ConcreteComponent : Component
    {
        public override void Work()
        {
            Console.WriteLine("我是具体对象做的操作");
        }
    }
}