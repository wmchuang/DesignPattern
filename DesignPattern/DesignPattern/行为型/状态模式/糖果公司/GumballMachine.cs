using System;

namespace DesignPattern.行为型.状态模式.糖果公司
{
    public class GumballMachine
    {
        private IState _state;

        public GumballMachine()
        {
            NoQuarterState = new NoQuarterState(this);
            HasQuarterState = new HasQuarterState(this);
            SoldState = new SoldState(this);
            _state = NoQuarterState;
            Count = 10;
        }

        public NoQuarterState NoQuarterState { get; set; }
        public HasQuarterState HasQuarterState { get; set; }
        public SoldState SoldState { get; set; }

        public int Count { get; set; }

        public void SetState(IState state)
        {
            _state = state;
        }

        public void SetCount(int count)
        {
            Count = count;
        }

        public void Print()
        {
            Console.WriteLine($"当前剩余糖果数量{Count}");
        }

        /// <summary>
        ///     投币
        /// </summary>
        public void InsertQuarter()
        {
            Console.WriteLine("操作--> 投币");
            _state.InsertQuarter();
        }

        /// <summary>
        ///     退币
        /// </summary>
        public void EjectQuarter()
        {
            Console.WriteLine("操作--> 退币");
            _state.EjectQuarter();
        }

        /// <summary>
        ///     转动曲柄
        /// </summary>
        public void TurnCrank()
        {
            Console.WriteLine("操作--> 转动曲柄");
            _state.TurnCrank();
        }

        /// <summary>
        ///     发放糖果
        /// </summary>
        public void Dispense()
        {
            Console.WriteLine("操作--> 发放糖果");
            _state.Dispense();
        }
    }
}