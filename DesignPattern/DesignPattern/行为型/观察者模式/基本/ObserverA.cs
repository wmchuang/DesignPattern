using System;

namespace DesignPattern.行为型.观察者模式.基本
{
    /// <summary>
    /// 具体的订阅者
    /// </summary>
    public class ObserverA : IObserver
    {

        public void Update()
        {
            Console.WriteLine("我是A，我开始干活了");
        }
    }
}