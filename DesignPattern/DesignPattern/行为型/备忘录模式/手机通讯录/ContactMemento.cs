using System.Collections.Generic;

namespace DesignPattern.行为型.备忘录模式.手机通讯录
{
    /// <summary>
    /// 备忘录
    /// </summary>
    public class ContactMemento
    {
        // 保存发起人的内部状态
        public List<ContactPerson> contactPersonBack;

        public ContactMemento(List<ContactPerson> persons)
        {
            contactPersonBack = persons;
        }
    }
}