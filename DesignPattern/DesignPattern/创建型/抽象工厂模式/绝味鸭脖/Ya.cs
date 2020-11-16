using System;

namespace DesignPattern.创建型.抽象工厂模式.绝味鸭脖
{
    /// <summary>
    /// 鸭脖抽象类
    /// </summary>
    public abstract class YaBo
    {
        public abstract void Print();
    }

    /// <summary>
    /// 鸭架抽象类
    /// </summary>
    public abstract class YaJia
    {
        public abstract void Print();
    }

    public class NanChangYaBo : YaBo
    {
        public override void Print()
        {
            Console.WriteLine("南昌鸭脖");
        }
    }

    public class ShangHaiYaBo : YaBo
    {
        public override void Print()
        {
            Console.WriteLine("上海鸭脖");
        }
    }

    public class NanChangYaJia : YaJia
    {
        public override void Print()
        {
            Console.WriteLine("南昌鸭架");
        }
    }

    public class ShangHaiYaJia : YaJia
    {
        public override void Print()
        {
            Console.WriteLine("上海鸭架");
        }
    }
}