using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPattern.行为型.责任链模式.抽题
{
    public class GetExamContext
    {
        /// <summary>
        /// 抽取试题Id
        /// </summary>
        /// <param name="flowQueue"></param>
        /// <returns></returns>
        public List<int> GetExamIdList(Queue<HandlerEnum> flowQueue)
        {
            var flowDto = new ExtractExamFlowDto()
            {
                TotalCount =  10
            };
            if (flowQueue.Count == 0) return flowDto.ExamIdList;

            var firstHandler = GetNextHandler(flowQueue.Dequeue());

            foreach (var nextHandler in flowQueue.Select(GetNextHandler))
            {
                SetNextHandler(firstHandler, nextHandler);
            }

            return firstHandler.Handle(flowDto).ExamIdList.Take(flowDto.TotalCount).ToList();
        }

        /// <summary>
        /// 递归设置职责链流程
        /// </summary>
        /// <param name="handler"></param>
        /// <param name="nextHandler"></param>
        private void SetNextHandler(ExtractExamAbstractHandler handler, ExtractExamAbstractHandler nextHandler)
        {
            if (handler.NextHandler != null)
            {
                SetNextHandler(handler.NextHandler, nextHandler);
                return;
            }

            handler.NextHandler = nextHandler;
        }

        /// <summary>
        /// 获取下一流程
        /// </summary>
        /// <param name="nextHandler"></param>
        /// <returns></returns>
        private ExtractExamAbstractHandler GetNextHandler(HandlerEnum nextHandler)
        {
            return nextHandler switch
            {
                HandlerEnum.A => new HandlerA(),
                HandlerEnum.B => new HandlerB(),
                HandlerEnum.C => new HandlerC(),
                _ => throw new ArgumentOutOfRangeException(nameof(nextHandler), nextHandler, null)
            };
        }
    }
}