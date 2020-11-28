namespace DesignPattern.行为型.访问者模式.基本
{
    /// <summary>
    /// 抽象访问者
    /// </summary>
    public interface IVistor
    {
        void Visit(ElementA a);
        void Visit(ElementB b);
    }
}