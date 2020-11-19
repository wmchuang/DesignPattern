namespace DesignPattern.结构型.外观模式.基本
{
    /// <summary>
    /// 外观类
    /// 外观类知道那些子系统负责请求，将客户请求分配到一些合适的一些子系统
    /// </summary>
    public class Facade
    {
        private readonly SubSystemA _subSystemA;
        private readonly SubSystemB _subSystemB;
        private readonly SubSystemC _subSystemC;
        
        public Facade()
        {
            _subSystemA = new SubSystemA();
            _subSystemB = new SubSystemB();
            _subSystemC = new SubSystemC();
        }

        public void Print()
        {
            _subSystemA.Print();
            _subSystemB.Print();
            _subSystemC.Print();
        }

    }
}