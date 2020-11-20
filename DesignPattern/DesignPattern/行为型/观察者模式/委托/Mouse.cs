using System;

namespace DesignPattern.行为型.观察者模式.委托
{
    public class Mouse : IObserver
    {

        public void Response()
        {
            Console.WriteLine("老鼠逃");
        }
    }
}