namespace DesignPattern.结构型.组合模式.图形
{
    /// <summary>
    /// 图形抽象类
    /// </summary>
    public abstract class Graphics
    {
        public string Name { get; set; }

        protected Graphics(string name)
        {
            Name = name;
        }

        public abstract void Draw();

        public abstract void Add(Graphics graphics);

        public abstract void Remove(Graphics graphics);
    }
}