using System.Linq;

namespace DesignPattern.行为型.责任链模式.抽题
{
    public class HandlerC : ExtractExamAbstractHandler
    {
        public override ExtractExamFlowDto Handle(ExtractExamFlowDto flowDto)
        {
            var list = Enumerable.Range(8, 50).ToList();
            flowDto.ExamIdList.AddRange(list);

            return ExecuteNextHandler(flowDto);
        }
    }
}