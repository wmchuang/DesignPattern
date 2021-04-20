namespace DesignPattern.行为型.命令模式.银行账户存取款
{
    /// <summary>
    /// 取款命令类
    /// </summary>
    public class MoneyOutCommand : Command
    {
        private decimal amount;
        public MoneyOutCommand(Account account, decimal amount)
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