using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace DesignPattern.结构型.享元模式.基本
{
    /// <summary>
    /// 享元工厂，负责创建和管理享元对象
    /// </summary>
    public class FlyweightFactory
    {
        private Dictionary<string,FlyWeight> flyweights = new Dictionary<string, FlyWeight>();
        
        public FlyweightFactory()
        {
            flyweights.Add("A", new ConcreteFlyweight());
        }

        public FlyWeight GetFlyweight(string key)
        {
            if (flyweights[key] is FlyWeight flyweight) return flyweight;
            Console.WriteLine("驻留池中不存在字符串" + key);
            flyweight = new ConcreteFlyweight();

            return flyweight;

        }
    }
}