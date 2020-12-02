using DesignPattern.行为型.状态模式.基本;

namespace DesignPattern.行为型.状态模式.糖果公司
{
    public class GumballMachine
    {
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

        private IState _state;

        public void SetState(IState state)
        {
            _state = state;
        }
        
        public void SetCount(int count)
        {
            Count = count;
        }


        /// <summary>
        /// 投币
        /// </summary>
        public void InsertQuarter()
        {
            _state.InsertQuarter();
        }

        /// <summary>
        /// 退币
        /// </summary>
        public void EjectQuarter()
        {
            _state.EjectQuarter();
        }

        /// <summary>
        /// 转动曲柄
        /// </summary>
        public void TurnCrank()
        {
            _state.TurnCrank();
        }

        /// <summary>
        /// 发放糖果
        /// </summary>
        public void Dispense()
        {
            _state.Dispense();
        }

    }
}