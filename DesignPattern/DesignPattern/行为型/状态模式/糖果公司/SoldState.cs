using System;

namespace DesignPattern.行为型.状态模式.糖果公司
{
    /// <summary>
    ///     销售状态
    /// </summary>
    public class SoldState : IState
    {
        private readonly GumballMachine _gumballMachine;

        public SoldState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void InsertQuarter()
        {
            Console.WriteLine("销售状态，不可投币");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("销售状态，已转动，不可退币");
        }

        public void TurnCrank()
        {
            Console.WriteLine("销售状态，不可重复转动");
        }

        public void Dispense()
        {
            Console.WriteLine("得到糖果");
            _gumballMachine.SetCount(_gumballMachine.Count - 1);
            _gumballMachine.SetState(_gumballMachine.NoQuarterState);
        }
    }
}