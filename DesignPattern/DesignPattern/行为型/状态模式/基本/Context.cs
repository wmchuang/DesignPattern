namespace DesignPattern.行为型.状态模式.基本
{
    public class Context
    {
        public State _state = new StateA();

        public void Request()
        {
            _state.Handle(this);
        }
    }
}