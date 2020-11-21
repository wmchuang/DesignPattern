using System;

namespace DesignPattern.结构型.代理模式.带货
{
    //真实主题角色
    public class RealBuyPerson : Person
    {
        public override void BuyProduct()
        {
            Console.WriteLine("帮我买一个IPhone和一台苹果电脑");
        }
    }
}