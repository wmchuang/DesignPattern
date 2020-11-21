using System;

namespace DesignPattern.行为型.中介者模式.基本
{
    public class ColleagueA : Colleague
    {

        public override void SendMessage(string message, Mediator mediator)
        {
            Console.WriteLine($"A发送消息{message}");
            mediator.Send(message, this);
        }

        public override void ReceiveMessage(string message)
        {
            Console.WriteLine($"A接收到消息{message}");
        }
    }
}