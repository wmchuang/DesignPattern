using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace DesignPattern.结构型.组合模式.基本
{
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
            foreach (var  item in _children)
            {
               item.Display(depth);
            }
            depth--;

        }
    }
}