using System;
using System.Collections.Generic;

namespace DesignPattern.结构型.组合模式.基本
{
    /// <summary>
    ///     复杂容器
    ///     复杂容器可以包含叶节点和其他容器
    /// </summary>
    public class Composite : Component
    {
        private readonly List<Component> _children = new List<Component>();

        public override void Add(Component child)
        {
            _children.Add(child);
        }

        public override void Remove(Component child)
        {
            _children.Remove(child);
        }

        public override void Display(int depth)
        {
            Console.WriteLine("我是组合节点");
            if (depth == 0) return;
            foreach (var item in _children) item.Display(depth);
            depth--;
        }
    }
}