using System;
using System.Linq;

namespace DesignPattern.行为型.责任链模式.抽题
{
    public class HandlerB : ExtractExamAbstractHandler
    {
        public override ExtractExamFlowDto Handle(ExtractExamFlowDto flowDto)
        {
            Console.WriteLine("HandlerB执行");
            var list = Enumerable.Range(6, 3).ToList();
            flowDto.ExamIdList.AddRange(list);

            return ExecuteNextHandler(flowDto);
        }
    }
}