using System;

namespace DesignPattern.行为型.策略模式.基本
{
    public class ConcreteStrategyA : IStrategy
    {

        public void Algorithm()
        {
            Console.WriteLine("算法A");
        }
    }
}