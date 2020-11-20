using System;

namespace DesignPattern.行为型.观察者模式.委托
{
    /// <summary>
    /// 人
    /// </summary>
    public class Master : IObserver
    {

        public void Response()
        {
            Console.WriteLine("人醒");
        }
    }
}