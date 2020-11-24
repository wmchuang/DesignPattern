using System;

namespace DesignPattern.行为型.策略模式.鸭子
{
    /// <summary>
    /// 飞行行为
    /// </summary>
    public interface IFlyBehavior
    {
        public void Fly();
    }
    
    public class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("飞");
        }
    }
    
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("不会飞");
        }
    }
}