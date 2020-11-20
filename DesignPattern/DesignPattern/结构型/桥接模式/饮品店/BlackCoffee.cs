using System;

namespace DesignPattern.结构型.桥接模式.饮品店
{
    public class BlackCoffee : IMakeCoffee
    {

        public void Making()
        {
            Console.WriteLine("原味咖啡");
        }
    }
}