using System;

namespace DesignPattern.行为型.中介者模式.消息通知
{

   // public delegate void NotificationEventHandler(string message, string sender);
    
    /// <summary>
    /// 中介者
    /// </summary>
    public class NotificateionEventHandler
    {

      //  public event NotificationEventHandler NotificationEventHandler;
      
      public event Action<string,string> NotificationEventHandler;

        public void Send(string message, string sender)
        {
            NotificationEventHandler?.Invoke(message, sender);
        }

    }
}