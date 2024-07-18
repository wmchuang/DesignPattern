namespace DesignPattern.行为型.命令模式.Test
{
    public abstract class Command
    {
        protected readonly Account Account;

        protected Command(Account account)
        {
            Account = account;
        }

        public abstract T Execute<T>();
    }
}