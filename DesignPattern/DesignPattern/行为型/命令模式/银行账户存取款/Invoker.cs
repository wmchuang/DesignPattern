using System.Collections.Generic;

namespace DesignPattern.行为型.命令模式.银行账户存取款
{
    /// <summary>
    /// 请求者角色
    /// </summary>
    public class Invoker
    {
        private readonly List<Command> _commands = new List<Command>(0);

        /// <summary>
        /// 执行命令
        /// </summary>
        /// <param name="command"></param>
        public void ExecuteCommand(Command command)
        {
            command.Execute();
            _commands.Add(command);
        }

        /// <summary>
        /// 重复
        /// </summary>
        /// <param name="levels"></param>
        public void Redo(int levels = 1)
        {
            for (var i = 0; i < levels; i++)
            {
                foreach (var m in _commands)
                {
                    m.Execute();
                }
            }
        }

        //Todo 撤销
    }
}