using System;

namespace DesignPattern.行为型.状态模式.糖果公司
{
    /// <summary>
    /// 有币状态
    /// </summary>
    public class HasQuarterState : IState
    {

        private GumballMachine _gumballMachine;

        public HasQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("有币状态，不可再投币");
        }

        public void EjectQuarter()
        {
            _gumballMachine.SetState(_gumballMachine.NoQuarterState);
        }

        public void TurnCrank()
        {
            Console.WriteLine("有币状态，，转动曲柄");
            _gumballMachine.SetState(_gumballMachine.SoldState);
        }

        public void Dispense()
        {
            Console.WriteLine("有币状态，请先转动");
        }
    }
}