using System.Threading.Tasks;
using DesignPattern.创建型.单例模式;
using DesignPattern.创建型.工厂模式.发奖;
using DesignPattern.创建型.工厂模式.饭店做菜;
using DesignPattern.创建型.抽象工厂模式.绝味鸭脖;

namespace DesignPattern.创建型
{
    /// <summary>
    /// 创建型
    /// 主要用于创建对象
    /// </summary>
    public static class CreateType
    {
        public static void Run()
        {
            InstanceTest();

            FactoryTest();

            AbstractFactoryTest();
        }

        /// <summary>
        /// 单例模式
        /// 保证一个类仅有一个实例，并提供ige访问它的全局访问点
        /// </summary>
        private static void InstanceTest()
        {
            for (var i = 0; i < 50; i++)
            {
                Task.Run(() => { LazySingleton.Instance.Print(); });
            }
        }
        
        /// <summary>
        /// 工厂模式
        /// 定义一个用于创建对象的接口，让子类决定实例化那个类
        /// 工厂方法使一个类的实例化延迟到子类
        /// </summary>
        private static void FactoryTest()
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
        }

        /// <summary>
        /// 抽象工厂模式
        /// 提供一个创建一系列相关或相互依赖对象的接口，而无需指定它们具体的类
        /// </summary>
        private static void AbstractFactoryTest()
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
    }
}