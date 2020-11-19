namespace DesignPattern.行为型.命令模式.银行账户存取款
{
    public abstract class Command
    {
        protected Account account;
 
        public Command(Account account)
        {
            this.account = account;
        }
 
        public abstract void Execute();
    }
}