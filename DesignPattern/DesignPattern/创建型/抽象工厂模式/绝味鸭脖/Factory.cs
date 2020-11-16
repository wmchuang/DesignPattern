namespace DesignPattern.创建型.抽象工厂模式.绝味鸭脖
{
    /// <summary>
    /// 抽象工厂类
    /// </summary>
    public abstract class AbstractFactory
    {
        public abstract YaBo CreateYaBo();
        public abstract YaJia CreateYaJia();
    }

    /// <summary>
    /// 南昌绝味工厂负责制作南昌的鸭脖和鸭架
    /// </summary>
    public class NanChangFactory : AbstractFactory
    {
        // 制作南昌鸭脖
        public override YaBo CreateYaBo()
        {
            return new NanChangYaBo();
        }

        // 制作南昌鸭架
        public override YaJia CreateYaJia()
        {
            return new NanChangYaJia();
        }
    }

    /// <summary>
    /// 上海绝味工厂负责制作上海的鸭脖和鸭架
    /// </summary>
    public class ShangHaiFactory : AbstractFactory
    {
        // 制作上海鸭脖
        public override YaBo CreateYaBo()
        {
            return new ShangHaiYaBo();
        }

        // 制作上海鸭架
        public override YaJia CreateYaJia()
        {
            return new ShangHaiYaJia();
        }
    }
}