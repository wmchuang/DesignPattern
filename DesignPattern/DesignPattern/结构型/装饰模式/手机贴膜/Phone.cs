using System;

namespace DesignPattern.结构型.装饰模式.手机贴膜
{
    public abstract class Phone
    {
        public abstract void Print();
    }
    
    public class ApplePhone : Phone
    {
        public override void Print()
        {
            Console.WriteLine("开始执行具体的对象--苹果手机");
        }
    }
    
    

}