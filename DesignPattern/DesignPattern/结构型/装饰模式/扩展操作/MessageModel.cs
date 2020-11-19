using System;

namespace DesignPattern.结构型.装饰模式.扩展操作
{
    /// <summary>
    /// Message实体类
    /// </summary>
    public class MessageModel
    {
        public MessageModel(string message, DateTime publishTime)
        {
            Message = message;
            PublishTime = publishTime;
        }

        public string Message { get; set; }

        public DateTime PublishTime { get; set; }
    }
}