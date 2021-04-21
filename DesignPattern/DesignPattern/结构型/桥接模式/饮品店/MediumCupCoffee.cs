using System;

namespace DesignPattern.结构型.桥接模式.饮品店
{
    public class MediumCupCoffee : Coffee
    {
        public MediumCupCoffee(IMakeCoffee makeCoffee) : base(makeCoffee)
        {
        }

        public override void Make()
        {
            Console.Write("中杯");
            _makeCoffee.Making();
        }
    }
}