using System;
using System.Threading.Tasks;
using DesignPattern.创建型.单例模式;
using DesignPattern.创建型.工厂模式.发奖;
using DesignPattern.创建型.工厂模式.饭店做菜;
using DesignPattern.创建型.抽象工厂模式.绝味鸭脖;

namespace DesignPattern
{
    class Program
    {
        static void Main1(string[] args)
        {
            #region 单例模式

            Print("单例模式");
            // {
            //     for (var i = 0; i < 50; i++)
            //     {
            //         Task.Run(() => { Singleton1.GetInstance(); });
            //     }
            // }

            #endregion

            #region 工厂模式

            Print("工厂模式");
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

            #endregion

            #region 抽象工厂模式

            Print("抽象工厂模式");
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

            #endregion
            

            Console.WriteLine("设计模式O(∩_∩)O!");
        }

        private static void Print(string name)
        {
            Console.WriteLine(Environment.NewLine);
            Console.Write("*".PadRight(10, '*'));  
            Console.Write(name);
            Console.Write("*".PadLeft(10, '*'));
            Console.WriteLine(Environment.NewLine);

        }
    }
}