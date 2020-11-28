using System;
using System.Collections.Generic;

namespace DesignPattern.行为型.备忘录模式.手机通讯录
{
    /// <summary>
    /// 发起人
    /// </summary>
    public class MobileOwner
    {
        // 发起人需要保存的内部状态
        public List<ContactPerson> ContactPersons { get; set; }

        public MobileOwner()
        {
            ContactPersons = new List<ContactPerson>()
            {
                new ContactPerson() {Name = "张三", Phone = "123445"},
                new ContactPerson() {Name = "李四", Phone = "234565"},
                new ContactPerson() {Name = "王五", Phone = "231455"}
            };
        }
        
        // 创建备忘录，将当期要保存的联系人列表导入到备忘录中 
        public ContactMemento CreateMemento()
        {
            return new ContactMemento(new List<ContactPerson>(this.ContactPersons));
        }
        
        
        public void RestoreMemento(ContactMemento memento)
        {
            this.ContactPersons = memento.contactPersonBack;
        }

        public void Show()
        {
            Console.WriteLine("联系人列表中有{0}个人，他们是:", ContactPersons.Count);
            foreach (ContactPerson p in ContactPersons)
            {
                Console.WriteLine("姓名: {0} 号码为: {1}", p.Name, p.Phone);
            }
        }
    }
}