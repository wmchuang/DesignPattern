using System;

namespace DesignPattern.行为型.状态模式.基本
{
    public class StateC : State
    {

        public override void Handle(Context c)
        {
            Console.WriteLine("StateC Handle");
        }
    }
}