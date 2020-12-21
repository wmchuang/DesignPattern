using System.Collections.Generic;

namespace DesignPattern.行为型.策略模式.抽题
{
    public interface IGetExamStrategy
    {
        public List<int> GetExam(int count);
    }
}