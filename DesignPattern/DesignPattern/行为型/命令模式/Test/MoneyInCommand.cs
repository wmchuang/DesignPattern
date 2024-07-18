namespace DesignPattern.行为型.命令模式.Test
{
    /// <summary>
    ///     存款命令
    /// </summary>
    public class MoneyInCommand : 银行账户存取款.Command
    {
        private readonly decimal amount;

        public MoneyInCommand(银行账户存取款.Account account, decimal amount)
            : base(account)
        {
            this.amount = amount;
        }

        /// <summary>
        ///     实现存钱命令
        /// </summary>
        public override void Execute()
        {
            Account.MoneyIn(amount);
        }
    }
}