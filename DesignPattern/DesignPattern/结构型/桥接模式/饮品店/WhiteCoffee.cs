using System;

namespace DesignPattern.结构型.桥接模式.饮品店
{
    public class WhiteCoffee : IMakeCoffee
    {

        public void Making()
        {
            Console.WriteLine("牛奶咖啡");
        }
    }
}