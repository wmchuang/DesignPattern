using System;
using DesignPattern.结构型.享元模式.基本;
using DesignPattern.结构型.代理模式.基本;
using DesignPattern.结构型.代理模式.带货;
using DesignPattern.结构型.外观模式.选课;
using DesignPattern.结构型.桥接模式.基本;
using DesignPattern.结构型.桥接模式.饮品店;
using DesignPattern.结构型.组合模式.图形;
using DesignPattern.结构型.组合模式.基本;
using DesignPattern.结构型.装饰模式.基本;
using DesignPattern.结构型.装饰模式.手机贴膜;
using DesignPattern.结构型.适配器模式.基本;
using DesignPattern.结构型.适配器模式.对象适配器模式.电源插头;
using DesignPattern.结构型.适配器模式.类适配器模式.电源插头;
using Decorator = DesignPattern.结构型.装饰模式.手机贴膜.Decorator;

namespace DesignPattern.结构型
{
    /// <summary>
    /// 结构型
    /// 用于处理类或对象的组合
    /// 关心类和对象之间怎么组织起来形成大的结构. 主要使用继承来组织接口或实现.
    /// 侧重于接口的使用，它做的一切工作都是对象或是类之间的交互
    /// 结构型模式包容了对很多问题的解决。例如：扩展性（外观、组成、代理、装饰）封装性（适配器，桥接）。
    /// 
    /// </summary>
    public static class StructType
    {
        public static void Run()
        {
            //AdapterTest();

            //  FacadeTest();

            // DecoratorTest();

            //ProxyTest();

            //BridgeTest();

            // CompositeTest();

            FlyweightTest();
        }

        /// <summary>
        /// 适配器模式 ⭐⭐⭐⭐
        /// Adapter模式使原本因为接口不兼容而不能一起工作的那些类可以一起工作
        /// 将一个类的接口转换成客户希望的另外一个接口
        /// </summary>
        private static void AdapterTest()
        {
            {
                ITarget adapter = new Adapter();
                adapter.Request();
            }
            {
                //类适配器模式
                IThreeHole threehole = new PowerAdapter();
                threehole.Request();
            }

            {
                //对象适配器模式
                ThreeHole threehole = new PowerAdapter1();
                threehole.Request();
            }
        }

        /// <summary>
        /// 外观模式 ⭐⭐⭐⭐⭐
        /// 为子系列中的一系列接口提供一个一致的界面，该模式提供了一个高层接口，则个接口使得这一子系列更加容易使用
        /// </summary>
        private static void FacadeTest()
        {
            {
                var facade = new DesignPattern.结构型.外观模式.基本.Facade();
                facade.Print();
            }
            {
                var facade = new Facade();
                if (facade.RegisterCourse("设计模式", "奇奇"))
                {
                    Console.WriteLine("选课成功");
                }
                else
                {
                    Console.WriteLine("选课失败");
                }
            }
        }

        /// <summary>
        /// 装饰模式 ⭐⭐⭐
        /// 动态地给一个对象添加一些额外的职责
        /// 就增加功能来说，装饰模式比添加子类更加灵活
        /// </summary>
        private static void DecoratorTest()
        {
            {
                var m = new ConcreteComponent();
                var decoratorA = new DecoratorA(m);
                // decoratorA.Work();

                var decoratorB = new DecoratorB(decoratorA);
                decoratorB.Work();
            }
            // {
            //     // 我买了个苹果手机
            //     Phone phone = new ApplePhone();
            //
            //     // 现在想贴膜了
            //     var applePhoneWithSticker = new Sticker(phone);
            //     // 扩展贴膜行为
            //     applePhoneWithSticker.Print();
            //     Console.WriteLine("----------------------\n");
            //
            //     // 现在我想有挂件了
            //     var applePhoneWithAccessories = new Accessories(phone);
            //     // 扩展手机挂件行为
            //     applePhoneWithAccessories.Print();
            //     Console.WriteLine("----------------------\n");
            //
            //     // 现在我同时有贴膜和手机挂件了
            //     var sticker = new Sticker(phone);
            //     var applePhoneWithAccessoriesAndSticker = new Accessories(sticker);
            //     applePhoneWithAccessoriesAndSticker.Print();
            // }

            // {
            //     AbstractMessage message = new SqlMessage();
            //     var de = new CheckUserWrapper(message);
            //     Console.WriteLine(de.Get()[0].Message);
            //
            //     var d2 = new CheckInputWrapper(message);
            //     Console.WriteLine(d2.Get()[0].Message);
            //
            //     var m3 = new CheckUserWrapper(message);
            //     var m4 = new CheckInputWrapper(m3);
            //     Console.WriteLine(m4.Get()[0].Message);
            // }
        }

        /// <summary>
        /// 代理模式 ⭐⭐⭐⭐
        /// 为其他对象提供一种代理以控制对该对象的访问
        /// 为客户端提供一种中间层以控制对这个对象的访问
        /// </summary>
        private static void ProxyTest()
        {
            {
                var sub = new Proxy();
                sub.Request();
            }
            {
                Person person = new Friend();
                person.BuyProduct();
            }
        }

        /// <summary>
        /// 桥接模式 ⭐⭐⭐
        /// 将抽象部分与它的实现部分分离，使得它们可以独立地变化
        /// </summary>
        private static void BridgeTest()
        {
            {
                var a = new ConcreteImplementorA();
                var b = new ConcreteImplementorB();

                var ra = new RefinedAbstractionA();
                var rb = new RefinedAbstractionB();
                ra.SetImplementor(a);
                ra.Operation();

                ra.SetImplementor(b);
                ra.Operation();
            }

            {
                var black = new BlackCoffee();
                var white = new WhiteCoffee();

                var large = new LargeCupCoffee(black);
                large.Make();
                large.SetCoffee(white);
                large.Make();

                var medium = new MediumCupCoffee(black);
                medium.Make();
                medium.SetCoffee(white);
                medium.Make();
            }
        }

        /// <summary>
        /// 组合模式 ⭐⭐⭐⭐
        /// 将对象组合成树形结构以表示 “部分-整体" 的层次结构
        /// 组合模式使得用户对单个对象和组合对象的使用具有一致性
        /// </summary>
        private static void CompositeTest()
        {
            {
                var leaf = new Leaf();
                var com = new Composite();
                var compo = new Composite();
                compo.Add(leaf);
                compo.Add(com);
                compo.Display(2);
            }
            {
                var com = new ComplexGraphics("复杂图形");
                var line = new Line("线");
                var circle = new Circle("圆");
                com.Add(line);
                com.Add(circle);
                com.Draw();

                com.Remove(circle);
                com.Draw();
            }
        }

        /// <summary>
        /// 享元模式 ⭐
        /// 运用共享技术有效地支持大量细粒度的对象
        /// </summary>
        private static void FlyweightTest()
        {
            var factory = new FlyweightFactory();
            var m = factory.GetFlyweight("A");
            m.Operation(1);

            var d = factory.GetFlyweight("A");
            Console.WriteLine(d.GetState());
        }
    }
}