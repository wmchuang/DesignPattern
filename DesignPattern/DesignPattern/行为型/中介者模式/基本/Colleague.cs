namespace DesignPattern.行为型.中介者模式.基本
{
    /// <summary>
    /// 抽象同事角色
    /// </summary>
    public abstract class Colleague
    {

        public abstract void SendMessage(string message,Mediator mediator);
        
        public abstract void ReceiveMessage(string message);
    }
}