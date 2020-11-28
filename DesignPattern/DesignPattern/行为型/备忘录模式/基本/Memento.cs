namespace DesignPattern.行为型.备忘录模式.基本
{
    /// <summary>
    /// 备忘录角色
    /// 负责存储发起人对象的内部状态
    /// </summary>
    public class Memento
    {
        private string _state;

        public Memento(string state)
        {
            _state = state;
        }

        public string GetState() => _state;

        public void SetState(string state) => _state = state;
    }
}