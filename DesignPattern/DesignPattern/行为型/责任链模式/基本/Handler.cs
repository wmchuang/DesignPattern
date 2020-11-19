using System;

namespace DesignPattern.行为型.责任链模式.基本
{
    public abstract class Handler
    {
        public Handler NextHandler;
        public string SetSuccesrror(string str)
        {
            Console.WriteLine(str);
            return "Ok";
        }

        public abstract string HandlerRequest(string str);
    }
}