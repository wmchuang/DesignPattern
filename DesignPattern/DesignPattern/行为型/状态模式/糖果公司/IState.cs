namespace DesignPattern.行为型.状态模式.糖果公司
{
    public interface IState
    {
        /// <summary>
        ///     投币
        /// </summary>
        public void InsertQuarter();

        /// <summary>
        ///     退币
        /// </summary>
        public void EjectQuarter();

        /// <summary>
        ///     转动曲柄
        /// </summary>
        public void TurnCrank();

        /// <summary>
        ///     发放糖果
        /// </summary>
        public void Dispense();
    }
}