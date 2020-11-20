using System;

namespace DesignPattern.结构型.组合模式.图形
{
    public class Circle : Graphics
    {

        public Circle(string name) : base(name)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("画" + Name);
        }

        public override void Add(Graphics graphics)
        {
            throw new Exception("不能向简单图形Circle添加其他图形");
        }

        public override void Remove(Graphics graphics)
        {
            throw new Exception("不能向简单图形Circle移除其他图形");
        }
    }
}