namespace DesignPattern.结构型.桥接模式.基本
{
    /// <summary>
    ///     抽象类
    /// </summary>
    public abstract class Abstraction
    {
        private Implementor _implementor;

        public void SetImplementor(Implementor implementor)
        {
            _implementor = implementor;
        }

        public virtual void Operation()
        {
            _implementor.OperationImp();
        }
    }
}