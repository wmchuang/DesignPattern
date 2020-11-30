using System;
using System.Threading.Tasks;
using DesignPattern.创建型.创建者模式.基本;
using DesignPattern.创建型.单例模式;
using DesignPattern.创建型.原型模式.基本;
using DesignPattern.创建型.工厂模式.发奖;
using DesignPattern.创建型.工厂模式.基本;
using DesignPattern.创建型.工厂模式.饭店做菜;
using DesignPattern.创建型.抽象工厂模式.绝味鸭脖;
using NUnit.Framework;

namespace DesignPattern.创建型
{
    /// <summary>
    /// 创建型
    /// 主要用于创建对象
    /// 所要表现的是对象的创建过程及和用户所使用的对象之间的关系.
    /// </summary>
    public class CreateType
    {
        /// <summary>
        /// 单例模式 ⭐⭐⭐⭐
        /// 保证一个类仅有一个实例，并提供ige访问它的全局访问点
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            for (var i = 0; i < 50; i++)
            {
                Task.Run(() => { LazySingleton.Instance.Print(); });
            }
        }

        /// <summary>
        /// 工厂模式 ⭐⭐⭐⭐⭐
        /// 定义一个用于创建对象的接口，让子类决定实例化那个类
        /// 工厂方法使一个类的实例化延迟到子类
        /// </summary>
        [Test]
        public void FactoryTest()
        {
            {
                // 开始做西红柿炒蛋
                Creator factory = new ShreddedPorkWithPotatoesFactory();
                var tomatoScrambleEggs = factory.CreateFoddFactory();
                tomatoScrambleEggs.Print();
                factory = new TomatoScrambledEggsFactory();

                //开始做土豆肉丝
                var shreddedPorkWithPotatoes = factory.CreateFoddFactory();
                shreddedPorkWithPotatoes.Print();
            }

            {
                var factory = new StoreFactory();
                var commodity = factory.GetCommodity(1);
                commodity.SendCommodity("1", "2");
                commodity = factory.GetCommodity(2);
                commodity.SendCommodity("1", "2");
            }
            {
                var a = new AFactory().CreateProdcut();
                a.Show();
                var b = new BFactory().CreateProdcut();
                b.Show();
            }
        }

        /// <summary>
        /// 抽象工厂模式 ⭐⭐⭐⭐⭐
        /// 提供一个创建一系列相关或相互依赖对象的接口，而无需指定它们具体的类
        /// </summary>
        [Test]
        public void AbstractFactoryTest()
        {
            {
                AbstractFactory nanChangFactory = new NanChangFactory();
                YaBo nanChangYabo = nanChangFactory.CreateYaBo();
                nanChangYabo.Print();
                YaJia nanChangYajia = nanChangFactory.CreateYaJia();
                nanChangYajia.Print();

                // 上海工厂制作上海的鸭脖和鸭架
                AbstractFactory shangHaiFactory = new ShangHaiFactory();
                shangHaiFactory.CreateYaBo().Print();
                shangHaiFactory.CreateYaJia().Print();
            }
        }

        /// <summary>
        /// 创建者模式⭐⭐
        /// 将一个负责对象的常见与它的表示分离，使得同样的构建过程可以创建不同的表示
        /// </summary>
        [Test]
        public void BuilderTest()
        {
            {
                var boss = new Boss();
                var builder1 = new CommonBuilder();
                var builder2 = new SeniorBuilder();
                boss.SetBuilder(builder1);

                var computer = boss.GetComputer();
                boss.Show(boss.GetComputer());
                boss.SetBuilder(builder2);
                boss.Show(boss.GetComputer());
            }
        }

        /// <summary>
        /// 原型模式 ⭐⭐⭐
        /// 用原实例指向创建对象的种类，并且通过拷贝这些原型创建新的对象
        /// </summary>
        [Test]
        public void PrototypeTest()
        {
            var prototype = new ConcretePrototype1("1", 2);
            Console.WriteLine($"{prototype.Id}{prototype.IntId}");
            var clone = prototype.Clone();
            Console.WriteLine($"{clone.Id}{clone.IntId}");
        }

    }
}