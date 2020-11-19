using System;

namespace DesignPattern.结构型.适配器模式.基本
{
    /// <summary>
    /// 客户希望的接口，可以是类、抽象类或者接口
    /// </summary>
    public interface ITarget
    {
        public void Request();
    }
}