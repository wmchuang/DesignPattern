namespace DesignPattern.行为型.命令模式.银行账户存取款
{
    public abstract class Command
    {
        protected readonly Account Account;

        protected Command(Account account)
        {
            Account = account;
        }

        public abstract void Execute();
    }
}