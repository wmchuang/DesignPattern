using System;
using DesignPattern.结构型.外观模式.选课;
using DesignPattern.结构型.装饰模式.手机贴膜;
using DesignPattern.结构型.装饰模式.扩展操作;
using DesignPattern.结构型.适配器模式.对象适配器模式.电源插头;
using DesignPattern.结构型.适配器模式.类适配器模式.电源插头;

namespace DesignPattern.结构型
{
    /// <summary>
    /// 结构型
    /// 用于处理类或对象的组合
    /// </summary>
    public static class StructType
    {
        public static void Run()
        {
            // AdapterTest();
            //
            // FacadeTest();

            DecoratorTest();
        }

        /// <summary>
        /// 适配器模式
        /// Adapter模式使原本因为接口不兼容而不能一起工作的那些类可以一起工作
        /// 将一个类的接口转换成客户希望的另外一个接口
        /// </summary>
        private static void AdapterTest()
        {
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
        /// 外观模式
        /// 为子系列中的一系列接口提供一个一致的界面，该模式提供了一个高层接口，则个接口使得这一子系列更加容易使用
        /// </summary>
        private static void FacadeTest()
        {
            {
                var facade = new Facade();
                if (facade.RegisterCourse("设计模式", "Learning Hard"))
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
        /// 装饰模式
        /// 动态地给一个对象添加一些额外的职责
        /// 就增加功能来说，装饰模式比添加子类更加灵活
        /// </summary>
        private static void DecoratorTest()
        {
            // {
            //     // 我买了个苹果手机
            //     Phone phone = new ApplePhone();
            //
            //     // 现在想贴膜了
            //     Decorator applePhoneWithSticker = new Decorator.Sticker(phone);
            //     // 扩展贴膜行为
            //     applePhoneWithSticker.Print();
            //     Console.WriteLine("----------------------\n");
            //
            //     // 现在我想有挂件了
            //     Decorator applePhoneWithAccessories = new Decorator.Accessories(phone);
            //     // 扩展手机挂件行为
            //     applePhoneWithAccessories.Print();
            //     Console.WriteLine("----------------------\n");
            //
            //     // 现在我同时有贴膜和手机挂件了
            //     var sticker = new Decorator.Sticker(phone);
            //     var applePhoneWithAccessoriesAndSticker = new Decorator.Accessories(sticker);
            //     applePhoneWithAccessoriesAndSticker.Print();
            // }

            {
                AbstractMessage message = new SqlMessage();
                var de = new CheckUserWrapper(message);
                Console.WriteLine(de.Get()[0].Message);
                
                var d2 = new CheckInputWrapper(message);
                Console.WriteLine(d2.Get()[0].Message);
                
                var m3 = new CheckUserWrapper(message);
                var m4 = new CheckInputWrapper(m3);
                Console.WriteLine(m4.Get()[0].Message);
            }
        }
    }
}