namespace DesignPattern.行为型.命令模式.银行账户存取款
{
    public class Account
    {
        /// <summary>
        /// 帐号总金额
        /// </summary>
        private decimal TotalAmount { get; set; }

        /// <summary>
        /// 存钱
        /// </summary>
        /// <param name="amount"></param>
        public void MoneyIn(decimal amount)
        {
            this.TotalAmount += amount;
        }

        /// <summary>
        /// 取钱
        /// </summary>
        /// <param name="amount"></param>
        public void MoneyOut(decimal amount)
        {
            this.TotalAmount -= amount;
        }

        public decimal GetTotalAmount()
        {
            return TotalAmount;
        }
    }
}