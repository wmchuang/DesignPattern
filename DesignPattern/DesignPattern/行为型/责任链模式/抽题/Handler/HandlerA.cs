using System.Linq;

namespace DesignPattern.行为型.责任链模式.抽题
{
    public class HandlerA : ExtractExamAbstractHandler
    {
        public override ExtractExamFlowDto Handle(ExtractExamFlowDto flowDto)
        {
            var list = Enumerable.Range(1, 5).ToList();
            flowDto.ExamIdList.AddRange(list);

            return ExecuteNextHandler(flowDto);
        }
    }
}