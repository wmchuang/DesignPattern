using System.Collections.Generic;

namespace DesignPattern.行为型.解释器模式.四则运算
{
    /// <summary>
    /// 抽象运算符号解析器
    /// </summary>
    public class SymbolExpression : Expression
    {
        protected Expression left;
        protected Expression right;

        public SymbolExpression(Expression left, Expression right)
        {
            this.left = left;
            this.right = right;
        }

        public override int Interpreter(Dictionary<string, int> dir)
        {
            return 0;
        }
    }
}