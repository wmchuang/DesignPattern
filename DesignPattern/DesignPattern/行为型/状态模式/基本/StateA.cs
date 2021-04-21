using System;

namespace DesignPattern.行为型.状态模式.基本
{
    public class StateA : State
    {
        public override void Handle(Context c)
        {
            Console.WriteLine("StateA Handle");
            c._state = new StateB();
        }
    }
}