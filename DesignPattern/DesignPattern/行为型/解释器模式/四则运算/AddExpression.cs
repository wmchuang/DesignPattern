using System.Collections.Generic;

namespace DesignPattern.行为型.解释器模式.四则运算
{
    public class AddExpression : SymbolExpression
    {
        public AddExpression(Expression left, Expression right) : base(left, right)
        {
        }
        

        public override int Interpreter(Dictionary<string, int> dir)
        {
            return base.left.Interpreter(dir) + base.right.Interpreter(dir);
        }
    }
}