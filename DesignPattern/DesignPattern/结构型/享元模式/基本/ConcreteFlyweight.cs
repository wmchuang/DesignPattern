using System;

namespace DesignPattern.结构型.享元模式.基本
{
    public class ConcreteFlyweight : FlyWeight
    {
        private int state = 0;
        public override void Operation(int extrinsicstate)
        {
            state = extrinsicstate;
            Console.WriteLine($"状态{extrinsicstate}");
        }

        public override int GetState()
        {
            return state;
        }
    }
}