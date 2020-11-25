namespace DesignPattern.行为型.中介者模式.消息通知
{
    /// <summary>
    /// Colleague 同事接口
    /// </summary>
    public interface IPerson
    {
        void Send(string message);

        void Receive(string message, string sender);
    }
}