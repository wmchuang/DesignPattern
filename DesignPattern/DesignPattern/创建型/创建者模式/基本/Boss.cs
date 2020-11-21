using System;

namespace DesignPattern.创建型.创建者模式.基本
{
    /// <summary>
    /// Director 指挥
    /// </summary>
    public class Boss
    {
        private Builder _builder;

        public void SetBuilder(Builder builder)
        {
            _builder = builder;
        }

        public Computer GetComputer()
        {
            _builder.BuildCPU();
            _builder.BuildHD();
            _builder.BuildMemory();
            return _builder.GetComputer();
        }

        public void Show(Computer computer)
        {
            Console.WriteLine($"{computer.CPU};{computer.Memory};{computer.HD}");
        }
    }
}