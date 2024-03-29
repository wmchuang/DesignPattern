using System;
using System.Collections.Generic;
using DesignPattern.行为型.中介者模式.基本;
using DesignPattern.行为型.中介者模式.消息通知;
using DesignPattern.行为型.命令模式.基本;
using DesignPattern.行为型.命令模式.银行账户存取款;
using DesignPattern.行为型.备忘录模式.基本;
using DesignPattern.行为型.备忘录模式.手机通讯录;
using DesignPattern.行为型.模板方法模式.基本;
using DesignPattern.行为型.模板方法模式.炒菜;
using DesignPattern.行为型.状态模式.糖果公司;
using DesignPattern.行为型.策略模式.基本;
using DesignPattern.行为型.策略模式.所得税;
using DesignPattern.行为型.策略模式.抽题;
using DesignPattern.行为型.策略模式.鸭子;
using DesignPattern.行为型.观察者模式.委托;
using DesignPattern.行为型.观察者模式.气象监测系统;
using DesignPattern.行为型.解释器模式.四则运算;
using DesignPattern.行为型.解释器模式.基本;
using DesignPattern.行为型.访问者模式.基本;
using DesignPattern.行为型.责任链模式.抽题;
using DesignPattern.行为型.责任链模式.采购;
using DesignPattern.行为型.迭代器模式.基本;
using DesignPattern.行为型.迭代器模式.自带;
using NUnit.Framework;
using Cat = DesignPattern.行为型.观察者模式.委托.Cat;
using Command = DesignPattern.行为型.命令模式.基本.Command;
using Context = DesignPattern.行为型.策略模式.基本.Context;
using GetExamContext = DesignPattern.行为型.责任链模式.抽题.GetExamContext;
using HandlerA = DesignPattern.行为型.责任链模式.基本.HandlerA;
using Mouse = DesignPattern.行为型.观察者模式.委托.Mouse;
using Person = DesignPattern.行为型.观察者模式.自带的接口.Person;

namespace DesignPattern.行为型
{
    public class B
    {
        int x = 1;

        public B(int x)
        {
            Console.WriteLine(x);
            Console.WriteLine(this.x);
        }
    }

    public class D : B
    {
        int y = 1;

        public D(int x) : base(x + 1)
        {
            Console.WriteLine(x);
        }
    }

    /// <summary>
    ///     行为型
    ///     用于描述对类或对象怎样交互和怎样分配职责
    ///     这一类的模式关心的是算法以及对象之间的任务分配. 它所描述的不仅仅是对象或类的设计模式, 还有它们之间的通讯模式.
    ///     侧重于具体行为，所以概念中才会出现职责分配和算法通信等内容。
    /// </summary>
    public class BehavioralType
    {
        [Test]
        public void T()
        {
            var d = new D(2);
        }

        /// <summary>
        ///     责任链模式 ⭐⭐
        ///     使多个对象都有机会处理请求，从而避免请求的发送者和接收者之间的耦合关系
        ///     将这些对象连成一条链，并沿着这条链传递该请求，直到有一个对象处理它为止。
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
            {
                var queue = new Queue<HandlerEnum>();
                queue.Enqueue(HandlerEnum.A);
                queue.Enqueue(HandlerEnum.B);
                queue.Enqueue(HandlerEnum.C);

                var context = new GetExamContext();
                var list = context.GetExamIdList(queue);
                list.ForEach(Console.WriteLine);
            }
        }

        /// <summary>
        ///     迭代器模式 ⭐⭐⭐⭐⭐
        ///     提供一种方法顺序访问聚合对象中各个元素，而又不暴漏该对象的内部表示
        /// </summary>
        [Test]
        public void IteratorTest()
        {
            {
                var aggregate = new ConcreteAggregate();
                var iterator = aggregate.GetIterator();
                while (!iterator.IsEnd())
                {
                    Console.WriteLine(iterator.CurrentItem());
                    iterator.Next();
                }
            }
            {
                var month = new MyItrerator.Months();
                foreach (var item in month) Console.WriteLine(item);
            }
        }

        /// <summary>
        ///     命令模式 ⭐⭐⭐⭐
        ///     将一个请求封装为一个对象，从而使你可用不同的请求对客户进行参数化；对请求排队或记录请求日志，以及支持可取消的操作。
        ///     命令；接收者；调度者
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
                Console.WriteLine("当前余额 " + account.GetTotalAmount().ToString("N2"));

                // 再次存入500
                var commandIn2 = new MoneyInCommand(account, 500);
                invoker.ExecuteCommand(commandIn2);
                Console.WriteLine("当前余额 " + account.GetTotalAmount().ToString("N2"));

                // 取出300
                var commandOut = new MoneyOutCommand(account, 300);
                invoker.ExecuteCommand(commandOut);
                Console.WriteLine("当前余额 " + account.GetTotalAmount().ToString("N2"));

                //重复
                invoker.Redo();
                Console.WriteLine("当前余额 " + account.GetTotalAmount().ToString("N2"));
            }
        }

        /// <summary>
        /// 观察者模式 ⭐⭐⭐⭐⭐
        /// 意图： 定义对象间的一种一对多的依赖关系，当一个对象的状态发生改变时，所有依赖于它的对象都得到通知并自动更新
        /// </summary>
        /// <remarks>
        /// 适用场合：
        ///    1. 当一个抽象模型有俩个方面，其中一个方面依赖于另一个方面，将这俩者封装在独立的对象中以使它们可以各自独立地改变和复用
        ///    2. 当对一个对象的改变需要同时改变其他对象，而不知道具体有多少对象有待改变时。
        ///    3. 当一个对象必须通知其他对象，而它又不能假定其他对象是谁，即不希望这些对象是紧耦合的。
        /// </remarks>
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
                var cat = new Cat();
                var master = new Master();
                var mouse = new Mouse();
                cat.Attach(master);
                cat.Attach(mouse);
                cat.Cry();
                cat.Delete(master);
                cat.Cry();
            }
            {
                var weather = new WeatherData();
                var party1 = new ForcastPartyDisplay();
                var party2 = new ThirdPartyDisplay();
                weather.RegisterObserver(party1);
                weather.RegisterObserver(party2);
                weather._data.Hum = 25;
                weather._data.Tempoerature = 30;
                weather.Notify();

                party1.Display();
                party2.Display();
            }
            {
                var person = new Person();
                var mouse = new 观察者模式.自带的接口.Mouse();
                var cat = new 观察者模式.自带的接口.Cat(new List<IObserver<int>> { person });
                mouse.Subscribe(cat);

                cat.Cry(1);
                mouse.OnCompleted();
                cat.Cry(3);
            }
        }

        /// <summary>
        ///     策略模式 ⭐⭐⭐⭐
        ///     它定义了算法家族，分别封装起来，使得它们之间可以相互替换
        ///     此模式让算法的变化，不会影响到使用该算法的客户
        ///     抽取行为
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
            {
                var duck = new RedDuck();
                duck.PerFormFly();
                duck.PerFormQuack();

                var rubberDuck = new RubberDuck();
                rubberDuck.PerFormFly();
                rubberDuck.PerFormQuack();
            }
            {
                var content = new 策略模式.抽题.GetExamContext(10);
                content.AddStrategy(new GetOneMonthExamStrategy());
                content.AddStrategy(new GetTwoMonthExamStrategy());
                content.GetExam();
            }
        }

        /// <summary>
        ///     模板方法模式 ⭐⭐⭐
        ///     定义一个操作中算法的骨架，而将一些步骤延迟到子类中，模板方法使得子类可以不改变一个算法的结构即可重定义该算法的某些特定步骤
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
        ///     解释器模式 ⭐
        ///     给定一个语言，定义它的文法的一种表示，并定义一个解释器，这个解释器使用该表示来解释语句中的句子
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
                var dir = new Dictionary<string, int>
                {
                    { "a", 1 },
                    { "b", 3 },
                    { "c", 2 }
                };
                var cal = new Calculator(str);
                Console.WriteLine(cal.run(dir));

                var cal1 = new Calculator(str1);
                Console.WriteLine(cal1.run(dir));
            }
        }

        /// <summary>
        ///     中介者模式 ⭐⭐
        ///     用一个中介对象来封装一系列的对象交互。中介者使个对象不需要显示地相互引用，从而使其耦合松散，而且可以独立地改变它们之间的交互
        /// </summary>
        [Test]
        public void MediatorTest()
        {
            {
                var a = new ColleagueA();
                var b = new ColleagueB();

                var mediator = new ConcreteMediator(a, b);
                a.SendMessage("你好", mediator);
                b.SendMessage("我很好，谢谢", mediator);
            }
            {
                var mediator = new NotificateionEventHandler();
                var admin = new 中介者模式.消息通知.Person(mediator, "管理员");
                var user = new 中介者模式.消息通知.Person(mediator, "用户");
                admin.Send("口号？");
                user.Send("芝麻开门");
            }
        }

        /// <summary>
        ///     状态模式 ⭐⭐⭐
        ///     当一个对象的内在状态改变时允许改变其行为，这个对象看起来像是改变了其类
        /// </summary>
        [Test]
        public void StateTest()
        {
            {
                var c = new 状态模式.基本.Context();
                c.Request();
                c.Request();
                c.Request();
            }
            {
                var mach = new GumballMachine();
                mach.InsertQuarter();
                mach.TurnCrank();
                mach.Dispense();
                mach.Dispense();
                mach.Dispense();

                mach.Print();

                mach.InsertQuarter();
                mach.TurnCrank();
                mach.Dispense();

                mach.Print();
            }
        }

        /// <summary>
        ///     访问者模式 ⭐
        ///     表示一个作用于某对象结构中的各元素的操作，它使你可以咋不改变各元素的类的前提下定义作用于这些元素的新操作
        /// </summary>
        [Test]
        public void VisitorTest()
        {
            {
                var str = new ObjectStructure();
                foreach (var element in str.Elements) element.Accept(new ConcreteVisitor());
            }
        }

        /// <summary>
        ///     备忘录模式 ⭐
        ///     在不破坏封装性的前提下，捕捉一个对象的内部状态，并在该对象之外保存这个状态，这样以后就可将该对象恢复到原先保存的状态
        /// </summary>
        [Test]
        public void MementoTest()
        {
            {
                var orig = new Originator();
                orig.Show();

                var caretaker = new Creataker
                {
                    Memento = orig.CreateMemento()
                };

                orig.SetState("2");
                orig.Show();

                orig.RestoreMemento(caretaker.Memento);
                orig.Show();
            }

            {
                var mobileOwner = new MobileOwner();
                mobileOwner.Show();

                var caretaker = new Caretaker
                {
                    ContactM = mobileOwner.CreateMemento()
                };

                mobileOwner.ContactPersons.RemoveAt(1);
                mobileOwner.Show();
                mobileOwner.ContactPersons.Clear();
                mobileOwner.Show();

                mobileOwner.RestoreMemento(caretaker.ContactM);
                mobileOwner.Show();
            }
        }
    }
}