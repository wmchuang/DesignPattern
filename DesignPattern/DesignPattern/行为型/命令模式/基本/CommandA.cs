namespace DesignPattern.行为型.命令模式.基本
{
    /// <summary>
    /// 具体命令
    /// </summary>
    public class CommandA : Command
    {
        //命令应该知道接收者是谁
        private Receiver _receiver;

        public CommandA()
        {
            _receiver = new Receiver();
        }

        public override void Execute()
        {
            _receiver.Action();
        }
    }
}