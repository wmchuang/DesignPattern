using System;
using DesignPattern.行为型.命令模式.基本;
using DesignPattern.行为型.命令模式.银行账户存取款;
using DesignPattern.行为型.责任链模式.基本;
using DesignPattern.行为型.责任链模式.采购;
using DesignPattern.行为型.迭代器模式.基本;
using Command = DesignPattern.行为型.命令模式.基本.Command;

namespace DesignPattern.行为型
{
    /// <summary>
    /// 行为型
    /// 用户描述对类或对象怎样交互和怎样分配职责
    /// </summary>
    public class BehavioralType
    {
        public static void Run()
        {
            //ChainOfResponsibility();

            // IteratorTest();

            CommandTest();
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
            var aggregate = new ConcreteAggregate();
            var iteraotr = aggregate.GetIterator();
            while (!iteraotr.IsEnd())
            {
                Console.WriteLine(iteraotr.CurrentItem());
                iteraotr.Next();
            }
        }

        /// <summary>
        /// 命令模式 ⭐⭐⭐⭐
        /// 将一个请求封装为一个对象，从而使你可用不同的请求对客户进行参数化；对请求排队或记录请求日志，以及支持可取消的操作。
        /// </summary>
        private static void CommandTest()
        {
            {
                Command command = new CommandA();
                var i = new Invoke(command);
                i.ExecuteCommand();
            }
            {
                // 创建银行帐号
                Account account = new Account();
                // 创建一个存入500元的命令
                MoneyInCommand commandIn = new MoneyInCommand(account,500);
                // 创建一个调度者
                var invoker = new Invoker();
 
                // 执行存钱
                invoker.ExecuteCommand(commandIn);
                Console.WriteLine("当前余额 " + account.GetTotalAmout().ToString("N2"));
 
                // 再次存入500
                MoneyInCommand commandIn2 = new MoneyInCommand(account, 500);
                invoker.ExecuteCommand(commandIn2);
                Console.WriteLine("当前余额 " + account.GetTotalAmout().ToString("N2"));
 
                // 取出300
                var commandOut = new MoneyOutCommand(account, 300);
                invoker.ExecuteCommand(commandOut);
                Console.WriteLine("当前余额 " + account.GetTotalAmout().ToString("N2"));

                //重复
                invoker.Redo();
                Console.WriteLine("当前余额 " + account.GetTotalAmout().ToString("N2"));
            }
        }
    }
}