using System;

namespace DesignPattern.行为型.观察者模式.猫叫老鼠逃
{
    public class Mouse : IObserver
    {

        public void Response()
        {
            Console.WriteLine("老鼠逃");
        }
    }
}