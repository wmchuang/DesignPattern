using System.Collections.Generic;

namespace DesignPattern.结构型.装饰模式.扩展操作
{
    public class Decorator : AbstractMessage
    {
        private AbstractMessage _abstractMessage;

        public Decorator(AbstractMessage abstractMessage)
        {
            _abstractMessage = abstractMessage;
        }

        public override List<MessageModel> Get()
        {
            return _abstractMessage.Get();
        }

        public override bool Insert(MessageModel model)
        {
            return _abstractMessage.Insert(model);
        }
    }
    
    public class  CheckUserWrapper : Decorator
    {
        public CheckUserWrapper(AbstractMessage abstractMessage) : base(abstractMessage)
        {
        }

        public override List<MessageModel> Get()
        {
            var list = base.Get();
            foreach (var item in list)
            {
                item.Message += "用户验证";
            }

            return list;
        }
    }
    
    public class CheckInputWrapper : Decorator
    {
        public CheckInputWrapper(AbstractMessage abstractMessage) : base(abstractMessage)
        {
        }
        
        public override List<MessageModel> Get()
        {
            var list = base.Get();
            foreach (var item in list)
            {
                item.Message += "用户输入";
            }

            return list;
        }
    }
}