using System.Collections;
using System.Collections.Generic;

namespace DesignPattern.行为型.解释器模式.四则运算
{
    public class Calculator
    {
        private Expression _expression;

        public Calculator(string str)
        {
            var charArray = str.ToCharArray();
            var stack = new Stack();

            Expression left = null;
            Expression right = null;
            for (var i = 0; i < charArray.Length; i++)
            {
                switch (charArray[i])
                {
                    case '+': //加法
                        left = (Expression) stack.Pop();
                        right = new VarExpresion(charArray[++i].ToString());
                        stack.Push(new AddExpression(left, right));
                        break;
                    case '-': //减法
                        left = (Expression) stack.Pop();
                        right = new VarExpresion(charArray[++i].ToString());
                        stack.Push(new SubExpression(left, right));
                        break;
                    default: //公式中的变量
                        stack.Push(new VarExpresion(charArray[i].ToString()));
                        break;
                }
            }

            this._expression = (Expression) stack.Pop();
        }

        public int run(Dictionary<string, int> dir)
        {
            return _expression.Interpreter(dir);
        }
    }
}