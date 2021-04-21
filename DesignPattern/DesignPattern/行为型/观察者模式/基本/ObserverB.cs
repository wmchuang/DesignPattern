using System;

namespace DesignPattern.行为型.观察者模式.基本
{
    public class ObserverB : IObserver
    {
        /// <summary>
        ///     具体的订阅者
        /// </summary>
        public void Update()
        {
            Console.WriteLine("我是B，我开始干活了");
        }
    }
}