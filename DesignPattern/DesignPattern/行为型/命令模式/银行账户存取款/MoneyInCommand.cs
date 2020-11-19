namespace DesignPattern.行为型.命令模式.银行账户存取款
{
    /// <summary>
    /// 存款命令
    /// </summary>
    public class MoneyInCommand : Command
    {
        private decimal amount;

        public MoneyInCommand(Account account, decimal amount)
            : base(account)
        {
            this.amount = amount;
        }

        /// <summary>
        /// 实现存钱命令
        /// </summary>
        public override void Execute()
        {
            account.MoneyIn(amount);
        }
    }
}