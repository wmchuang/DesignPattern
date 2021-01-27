using System;
using System.Threading.Tasks;

namespace DesignPattern.行为型.责任链模式.抽题
{
    public abstract class ExtractExamAbstractHandler
    {
        public ExtractExamAbstractHandler NextHandler { get; set; }


        public abstract ExtractExamFlowDto Handle(ExtractExamFlowDto flowDto);

        /// <summary>
        /// 执行下一流程
        /// </summary>
        /// <param name="flowDto"></param>
        /// <returns></returns>
        protected ExtractExamFlowDto ExecuteNextHandler(ExtractExamFlowDto flowDto)
        {
            if (flowDto.ExtractCount <= 0 || NextHandler == null)
                return flowDto;

            return NextHandler.Handle(flowDto);
        }
    }
}