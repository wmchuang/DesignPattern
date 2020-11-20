using System;

namespace DesignPattern.行为型.观察者模式.猫叫老鼠逃
{
    public class Cat : Subject
    {
        public void Cry()
        {
            Console.WriteLine("猫叫");
            Notify();
        }
    }
}