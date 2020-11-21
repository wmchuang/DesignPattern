using System;
using System.Collections.Generic;
using DesignPattern.行为型.命令模式.基本;
using DesignPattern.行为型.命令模式.银行账户存取款;
using DesignPattern.行为型.模板方法模式.基本;
using DesignPattern.行为型.模板方法模式.炒菜;
using DesignPattern.行为型.策略模式.基本;
using DesignPattern.行为型.策略模式.所得税;
using DesignPattern.行为型.观察者模式.基本;
using DesignPattern.行为型.观察者模式.猫叫老鼠逃;
using DesignPattern.行为型.解释器模式.四则运算;
using DesignPattern.行为型.解释器模式.基本;
using DesignPattern.行为型.责任链模式.基本;
using DesignPattern.行为型.责任链模式.采购;
using DesignPattern.行为型.迭代器模式.基本;
using NUnit.Framework;
using Command = DesignPattern.行为型.命令模式.基本.Command;
using Context = DesignPattern.行为型.策略模式.基本.Context;
using Subject = DesignPattern.行为型.观察者模式.基本.Subject;

namespace DesignPattern.行为型
{
    /// <summary>
    /// 行为型
    /// 用于描述对类或对象怎样交互和怎样分配职责
    /// 这一类的模式关心的是算法以及对象之间的任务分配. 它所描述的不仅仅是对象或类的设计模式, 还有它们之间的通讯模式.
    /// 侧重于具体行为，所以概念中才会出现职责分配和算法通信等内容。
    /// </summary>
    public class BehavioralType
    {

        /// <summary>
        /// 责任链模式 ⭐⭐
        /// 使多个对象都有机会处理请求，从而避免请求的发送者和接收者之间的耦合关系
        /// 将这些对象连成一条链，并沿着这条链传递该请求，直到有一个对象处理它为止。
        /// </summary>
        [Test]
        public void ChainOfResponsibility()
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
        [Test]
        public void IteratorTest()
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
        [Test]
        public void CommandTest()
        {
            {
                Command command = new CommandA();
                var i = new Invoke(command);
                i.ExecuteCommand();
            }
            {
                // 创建银行帐号
                var account = new Account();
                // 创建一个存入500元的命令
                var commandIn = new MoneyInCommand(account, 500);
                // 创建一个调度者
                var invoker = new Invoker();

                // 执行存钱
                invoker.ExecuteCommand(commandIn);
                Console.WriteLine("当前余额 " + account.GetTotalAmout().ToString("N2"));

                // 再次存入500
                var commandIn2 = new MoneyInCommand(account, 500);
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

        /// <summary>
        /// 观察者模式 ⭐⭐⭐⭐⭐
        /// 定义了一种一对多的依赖关系，让多个观察者对象同时监听某一个主题对象。
        /// 这个主题对象在状态发生变化时，会通知所有观察者对象，让他们能够自动更新自己
        /// </summary>
        [Test]
        public void ObserverTest()
        {
            // {
            //     Subject subject = new ConcreteSubject();
            //
            //     var a = new ObserverA();
            //     var b = new ObserverB();
            //     subject.Attach(a);
            //     subject.Attach(b);
            //     subject.Notify();
            //     subject.Delete(b);
            //     subject.Notify();
            // }
            // {
            //     var cat = new Cat();
            //     cat.Attach(new Master());
            //     cat.Attach(new Mouse());
            //     cat.Cry();
            // }
            {
                var cat = new DesignPattern.行为型.观察者模式.委托.Cat();
                var master = new DesignPattern.行为型.观察者模式.委托.Master();
                var mouse = new DesignPattern.行为型.观察者模式.委托.Mouse();
                cat.Attach(master);
                cat.Attach(mouse);
                cat.Cry();
                cat.Delete(master);
                cat.Cry();
            }
        }

        /// <summary>
        /// 策略模式 ⭐⭐⭐⭐
        /// 它定义了算法家族，分别封装起来，使得它们之间可以相互替换
        /// 此模式让算法的变化，不会影响到使用该算法的客户
        /// 抽取行为
        /// </summary>
        [Test]
        public void StrategyTest()
        {
            {
                var content = new Context();
                content.AlgorithmInvoker();
                content.SetStrategy(new ConcreteStrategyA());
                content.AlgorithmInvoker();
                content.SetStrategy(new ConcreteStrategyB());
                content.AlgorithmInvoker();
            }
            {
                var operation = new InterestOperation();
                operation.SetStragety(new PersonalTaxStrategy());
                Console.WriteLine("个人支付的税为{0}", operation.GetTax(5000));

                operation.SetStragety(new EnterpriseTaxStrategy());
                Console.WriteLine("企业支付的税为{0}", operation.GetTax(50000));
            }
        }

        /// <summary>
        /// 模板方法模式 ⭐⭐⭐
        /// 定义一个操作中算法的骨架，而将一些步骤延迟到子类中，模板方法使得子类可以不改变一个算法的结构即可重定义该算法的某些特定步骤
        /// </summary>
        [Test]
        public void TemplateTest()
        {
            {
                var a = new ConcreteClassA();
                a.TemplateMethod();
                var b = new ConcreteClassB();
                b.TemplateMethod();
            }
            {
                var spinach = new Spinach();
                spinach.CookVegetabel();
                var chineseCabbage = new ChineseCabbage();
                chineseCabbage.CookVegetabel();
            }
        }

        /// <summary>
        /// 解释器模式 ⭐
        /// 给定一个语言，定义它的文法的一种表示，并定义一个解释器，这个解释器使用该表示来解释语句中的句子
        /// </summary>
        [Test]
        public void InterpreterTest()
        {
            {
                var context = new 解释器模式.基本.Context();
                var list = new List<AbstractExpression>
                {
                    new TerminalExpression(),
                    new NonterminalExpression(),
                    new TerminalExpression(),
                    new TerminalExpression()
                };
                list.ForEach(item => { item.Intesrpre(context); });
            }
            {
                var str = "a+b-c";
                var str1 = "a+b+c";
                var dir = new Dictionary<string, int>()
                {
                    {"a", 1},
                    {"b", 3},
                    {"c", 2},
                };
                var cal = new Calculator(str);
                Console.WriteLine(cal.run(dir));
                
                var cal1 = new Calculator(str1);
                Console.WriteLine(cal1.run(dir));
            }
        }
    }
}