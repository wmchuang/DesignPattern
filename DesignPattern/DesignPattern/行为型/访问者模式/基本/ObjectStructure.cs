using System;
using System.Collections.Generic;

namespace DesignPattern.行为型.访问者模式.基本
{
    /// <summary>
    ///     对象结构
    /// </summary>
    public class ObjectStructure
    {
        public readonly List<Element> Elements = new List<Element>();

        public ObjectStructure()
        {
            var ran = new Random();
            for (var i = 0; i < 6; i++)
            {
                var ranNum = ran.Next(10);
                if (ranNum > 5)
                    Elements.Add(new ElementA());
                else
                    Elements.Add(new ElementB());
            }
        }
    }
}