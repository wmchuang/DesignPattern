using System.Collections.Generic;

namespace DesignPattern.结构型.装饰模式.扩展操作
{
    public abstract class AbstractMessage
    {
        /// <summary>
        /// 获取Message
        /// </summary>
        /// <returns></returns>
        public abstract List<MessageModel> Get();

        /// <summary>
        /// 插入Message
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public abstract bool Insert(MessageModel model);
    }
}