using System.Collections.Generic;
using DesignPattern.结构型.代理模式.基本;

namespace DesignPattern.结构型.组合模式.图形
{
    public class ComplexGraphics : Graphics
    {

        private readonly List<Graphics> _graphicses = new List<Graphics>();
        public ComplexGraphics(string name) : base(name)
        {
        }

        public override void Draw()
        {
            _graphicses.ForEach(item =>
            {
                item.Draw();
            });
        }

        public override void Add(Graphics graphics)
        {
            _graphicses.Add(graphics);
        }

        public override void Remove(Graphics graphics)
        {
            _graphicses.Remove(graphics);
        }
    }
}