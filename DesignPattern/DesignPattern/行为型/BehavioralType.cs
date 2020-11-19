using System;
using DesignPattern.行为型.责任链模式.基本;
using DesignPattern.行为型.责任链模式.采购;
using DesignPattern.行为型.迭代器模式.基本;

namespace DesignPattern.行为型
{
    /// <summary>
    /// 行为型
    /// 用户描述对类或对象怎样交互和怎样分配职责
    /// </summary>
    public  class BehavioralType
    {
        public static void Run()
        {
            ChainOfResponsibility();

            // IteratorTest();
        }

        /// <summary>
        /// 责任链模式 ⭐⭐
        /// 使多个对象都有机会处理请求，从而避免请求的发送者和接收者之间的耦合关系
        /// 将这些对象连成一条链，并沿着这条链传递该请求，直到有一个对象处理它为止。
        /// </summary>
        private static void ChainOfResponsibility()
        {
            {
                var hand = new HandlerA();
                hand.HandlerRequest("1");
                hand.HandlerRequest("2");
            }
            {
                var requestTelphone = new PurchaseRequest(4000.0, "手机");
                var requestSoftware = new PurchaseRequest(10000.0, "平板");
                var requestComputers = new PurchaseRequest(40000.0, "电脑");
                Approver manager = new Manager("LearningHard");


                // 处理请求
                manager.ProcessRequest(requestTelphone);
                manager.ProcessRequest(requestSoftware);
                manager.ProcessRequest(requestComputers);
            }
        }

        /// <summary>
        /// 迭代器模式 ⭐⭐⭐⭐⭐
        /// 提供一种方法顺序访问聚合对象中各个元素，而又不暴漏该对象的内部表示
        /// </summary>
        private static void IteratorTest()
        {
            var aggregate = new  ConcreteAggregate();
            var iteraotr = aggregate.GetIterator();
            while (!iteraotr.IsEnd())
            {
                Console.WriteLine(iteraotr.CurrentItem());
                iteraotr.Next();
            }
        }
    }
}