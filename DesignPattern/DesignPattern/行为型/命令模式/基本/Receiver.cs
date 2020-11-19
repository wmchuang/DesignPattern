using System;

namespace DesignPattern.行为型.命令模式.基本
{
    /// <summary>
    /// 接收者
    /// </summary>
    public class Receiver
    {
        public void Action()
        {
            Console.WriteLine("接收者执行的方法");
        }
    }
}