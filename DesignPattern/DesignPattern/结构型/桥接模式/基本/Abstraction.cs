using System.Net.NetworkInformation;

namespace DesignPattern.结构型.桥接模式.基本
{
    /// <summary>
    /// 抽象类
    /// </summary>
    public abstract class Abstraction
    {
        private Implementor _imMplementor;

        public void SetImplementor(Implementor imMplementor)
        {
            this._imMplementor = imMplementor;
        }

        public virtual void Operation()
        {
            _imMplementor.OperationImp();
        }
    }
}