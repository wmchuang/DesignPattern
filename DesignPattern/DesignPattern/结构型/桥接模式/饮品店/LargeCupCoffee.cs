using System;

namespace DesignPattern.结构型.桥接模式.饮品店
{
    public class LargeCupCoffee : Coffee
    {

        public LargeCupCoffee(IMakeCoffee makeCoffee) : base(makeCoffee)
        {
        }

        public override void Make()
        {
            Console.Write("大杯");
            _makeCoffee.Making();
        }
    }
}