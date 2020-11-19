using System;

namespace DesignPattern.结构型.装饰模式.基本
{
    /// <summary>
    /// 装饰类
    /// </summary>
    public class DecoratorA : Decorator
    {

        public DecoratorA(Component innerCompomponent) : base(innerCompomponent)
        {
        }

        public override void Work()
        {
            base.Work();
            AddStateA();
        }

        private void AddStateA()
        {
            Console.WriteLine("我是装饰A");
        }
    }
}