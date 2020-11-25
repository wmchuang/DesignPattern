using System.ComponentModel;

namespace DesignPattern.行为型.中介者模式.基本
{
    /// <summary>
    /// 具体中介者
    /// </summary>
    public class ConcreteMediator : Mediator
    {

        public override void Send(string message, Colleague colleague)
        {
            if (colleague.GetType() == typeof(ColleagueA))
            {
                b.ReceiveMessage(message);
            }
            else
            {
                a.ReceiveMessage(message);
            }
        }

        public ConcreteMediator(ColleagueA a, ColleagueB b) : base(a, b)
        {
        }
    }
}