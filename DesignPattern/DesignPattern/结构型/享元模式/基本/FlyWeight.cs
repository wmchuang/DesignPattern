namespace DesignPattern.结构型.享元模式.基本
{
    /// <summary>
    /// 享元抽象类
    /// </summary>
    public abstract class FlyWeight
    {
        public abstract void Operation(int extrinsicstate);
        
        public abstract int GetState();
    }
}