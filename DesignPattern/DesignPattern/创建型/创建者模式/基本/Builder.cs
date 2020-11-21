namespace DesignPattern.创建型.创建者模式.基本
{
    /// <summary>
    /// 抽象建造者类
    /// </summary>
    public abstract class Builder
    {
        public abstract void BuildCPU();

        public abstract void BuildMemory();

        public abstract void BuildHD();

        public abstract Computer GetComputer();
    }
}