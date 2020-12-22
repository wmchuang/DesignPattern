using System;

namespace DesignPattern.结构型.组合模式.基本
{
    /// <summary>
    /// 简单页节点
    /// </summary>
    public class Leaf : Component
    {

        public override void Add(Component child)
        {
            throw new System.NotImplementedException();
        }

        public override void Remove(Component child)
        {
            throw new System.NotImplementedException();
        }

        public override void Display(int depth)
        {
            Console.WriteLine("我是单个节点");
        }
    }
}