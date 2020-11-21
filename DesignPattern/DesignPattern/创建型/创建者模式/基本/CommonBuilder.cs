using System.Runtime.InteropServices;

namespace DesignPattern.创建型.创建者模式.基本
{
    /// <summary>
    /// 具体创建者
    /// </summary>
    public class CommonBuilder : Builder
    {

        private Computer _computer = new Computer();

        public override void BuildCPU()
        {
            _computer.CPU = "华为CPU";
        }

        public override void BuildMemory()
        {
            _computer.Memory = "华为Memory";
        }

        public override void BuildHD()
        {
            _computer.HD = "华为HD";
        }

        public override Computer GetComputer()
        {
            return _computer;
        }
    }
}