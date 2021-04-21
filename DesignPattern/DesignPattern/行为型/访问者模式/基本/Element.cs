namespace DesignPattern.行为型.访问者模式.基本
{
    /// <summary>
    /// 抽象元素角色
    /// </summary>
    public abstract class Element
    {
        public abstract void Accept(IVisitor visitor);
        public abstract void Print();
    }
}