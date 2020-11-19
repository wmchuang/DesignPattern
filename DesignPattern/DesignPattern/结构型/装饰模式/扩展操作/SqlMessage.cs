using System;
using System.Collections.Generic;

namespace DesignPattern.结构型.装饰模式.扩展操作
{
    public class SqlMessage : AbstractMessage
    {

        public override List<MessageModel> Get()
        {
            return new List<MessageModel> {new MessageModel("SQL方式获取Message", DateTime.Now)};
        }

        public override bool Insert(MessageModel model)
        {
            return true;
        }
    }
}