using System.Runtime.InteropServices;

namespace DesignPattern.创建型.创建者模式.基本
{
    /// <summary>
    /// 具体创建者
    /// </summary>
    public class SeniorBuilder : Builder
    {

        private Computer _computer = new Computer();

        public override void BuildCPU()
        {
            _computer.CPU = "苹果CPU";
        }

        public override void BuildMemory()
        {
            _computer.Memory = "苹果Memory";
        }

        public override void BuildHD()
        {
            _computer.HD = "苹果HD";
        }

        public override Computer GetComputer()
        {
            return _computer;
        }
    }
}