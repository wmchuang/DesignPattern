namespace DesignPattern.行为型.迭代器模式.基本
{
    /// <summary>
    /// 迭代器抽象类
    /// </summary>
    public interface ITerator
    {
        int First();

        int Next();

        bool IsEnd();

        int CurrentItem();

        void Reset();
    }
}