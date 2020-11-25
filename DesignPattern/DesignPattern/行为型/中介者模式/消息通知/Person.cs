using System;

namespace DesignPattern.行为型.中介者模式.消息通知
{
    public class Person : IPerson
    {
        public Person(NotificateionEventHandler mediator, string role)
        {
            _mediator = mediator;
            Role = role;
            _mediator.NotificationEventHandler += Receive;
        }
        
        private readonly NotificateionEventHandler _mediator;

        private string  Role{ get; set; }

        public void Send(string message)
        {
            Console.WriteLine($"{Role} 发送消息:  {message}");
            _mediator.Send(message, Role);
        }

        public void Receive(string message, string sender)
        {
            if (sender != Role)
            {
                Console.WriteLine($"{Role}收到来自于 {sender}的消息 '{message}'");
            }
        }
    }
}