namespace DesignPattern.行为型.命令模式.Test
{
    /// <summary>
    /// 取款命令类
    /// </summary>
    public class MoneyOutCommand : 银行账户存取款.Command
    {
        private decimal amount;
        public MoneyOutCommand(银行账户存取款.Account account, decimal amount)
            : base(account)
        {
            this.amount = amount;
        }
 
        /// <summary>
        /// 实现取钱命令
        /// </summary>
        public override void Execute()
        {
            Account.MoneyOut(amount);
        }
    }
}