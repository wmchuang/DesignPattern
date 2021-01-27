using System.Collections.Generic;

namespace DesignPattern.行为型.责任链模式.抽题
{
    public class ExtractExamFlowDto
    {
        /// <summary>
        /// 要抽的总个数
        /// </summary>
        public int TotalCount { get; set; }
        
        /// <summary>
        /// 抽到的试题
        /// </summary>
        public List<int> ExamIdList { get; set; } = new List<int>(0);

        /// <summary>
        /// 还需要抽的题目个数
        /// </summary>
        public int ExtractCount => TotalCount - ExamIdList.Count;
    }
}