using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.行为型.解释器模式.四则运算
{
    public class VarExpresion : Expression
    {
        public VarExpresion(string key)
        {
            this.key = key;
        }

        private string key { get; set; }

        public override int Interpreter(Dictionary<string, int> dir)
        {
            return dir.First(x => x.Key == key).Value;
        }
    }
}