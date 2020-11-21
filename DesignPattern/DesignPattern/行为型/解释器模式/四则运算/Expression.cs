using System.Collections.Generic;

namespace DesignPattern.行为型.解释器模式.四则运算
{
    /// <summary>
    /// 抽象表达式类
    /// </summary>
    public abstract class Expression
    {
        public abstract int Interpreter(Dictionary<string, int> dir);
    }
}