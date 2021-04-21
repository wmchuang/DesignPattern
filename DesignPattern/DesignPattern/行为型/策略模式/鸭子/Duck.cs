namespace DesignPattern.行为型.策略模式.鸭子
{
    /// <summary>
    ///     鸭子抽象类
    /// </summary>
    public abstract class Duck
    {
        protected IFlyBehavior _flyBehavior;
        protected IQuackInterface _quackInterface;

        public abstract void Display();

        public void SetFlyBehavior(IFlyBehavior flyBehavior)
        {
            _flyBehavior = flyBehavior;
        }

        public void SetQuackInterface(IQuackInterface quackInterface)
        {
            _quackInterface = quackInterface;
        }

        public void PerFormFly()
        {
            _flyBehavior.Fly();
        }

        public void PerFormQuack()
        {
            _quackInterface.Quack();
        }
    }
}