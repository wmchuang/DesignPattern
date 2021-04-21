namespace DesignPattern.结构型.组合模式.基本
{
    public abstract class Component
    {
        public string Name { get; set; }

        public abstract void Add(Component child);

        public abstract void Remove(Component child);

        public abstract void Display(int depth);
    }
}