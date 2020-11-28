using System;

namespace DesignPattern.行为型.备忘录模式.基本
{
    /// <summary>
    /// 发起人角色
    /// 记录当前时刻的内部状态，负责创建和恢复备忘录数据
    /// </summary>
    public class Originator
    {
        private string _state = "1";
        
        /// <summary>
        /// 创建备忘录
        /// </summary>
        /// <returns></returns>
        public Memento CreateMemento()
        {
            return new Memento(_state);
        }
        
        public void SetState(string state) => _state = state;
        
        // 恢复数据
        public void RestoreMemento(Memento memento)
        {
            this._state = memento.GetState();
        }

        public void Show()
        {
            Console.WriteLine($"当前状态{_state}");
        }

    }
}