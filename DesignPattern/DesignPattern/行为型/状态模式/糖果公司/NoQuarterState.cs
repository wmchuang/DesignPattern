using System;

namespace DesignPattern.行为型.状态模式.糖果公司
{
    /// <summary>
    /// 没有币
    /// </summary>
    public class NoQuarterState : IState
    {

        private GumballMachine _gumballMachine;

        public NoQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            _gumballMachine.SetState(_gumballMachine.HasQuarterState);
        }

        public void EjectQuarter()
        {
            Console.WriteLine("当前没有币，不可退");
        }

        public void TurnCrank()
        {
            Console.WriteLine("当前没有币，不可转动");
        }

        public void Dispense()
        {
            Console.WriteLine("当前没有币，不可发放");
        }
    }
}