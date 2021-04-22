using System;

namespace DesignPattern.结构型.装饰模式.基本
{
    /// <summary>
    /// 装饰类
    /// </summary>
    public class DecoratorB : Decorator
    {

        public DecoratorB(Component innerComponent) : base(innerComponent)
        {
        }

        public override void Work()
        {
            base.Work();
            AddStateB();
        }

        private void AddStateB()
        {
            Console.WriteLine("我是装饰B");
        }
    }
}