using System;

namespace DesignPattern.行为型.策略模式.鸭子
{
    public class RedDuck : Duck
    {

        public RedDuck()
        {
            _flyBehavior = new FlyWithWings();
            _quackInterface = new Squeak();
        }

        public override void Display()
        {
            Console.WriteLine("红头鸭");
        }
    }
    
    public class RubberDuck : Duck
    {

        public RubberDuck()
        {
            _flyBehavior = new FlyNoWay();
            _quackInterface = new MuteQuack();
        }

        public override void Display()
        {
            Console.WriteLine("红头鸭");
        }
    }
}