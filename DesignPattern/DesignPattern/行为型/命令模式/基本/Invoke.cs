namespace DesignPattern.行为型.命令模式.基本
{
    /// <summary>
    /// 调度者
    /// </summary>
    public class Invoke
    {
        private Command _command;

        public Invoke(Command command)
        {
            this._command = command;
        }

        public void ExecuteCommand()
        {
            _command.Execute();
        }
    }
}