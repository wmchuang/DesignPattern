using System;

namespace DesignPattern.行为型.策略模式.基本
{
    public class ConcreteStrategyC : IStrategy
    {

        public void Algorithm()
        {
            Console.WriteLine("算法C");
        }
    }
}