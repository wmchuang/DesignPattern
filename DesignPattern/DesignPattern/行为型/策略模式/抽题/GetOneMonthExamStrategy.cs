using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using NUnit.Framework;

namespace DesignPattern.行为型.策略模式.抽题
{
    public class GetOneMonthExamStrategy : IGetExamStrategy
    {
        public List<int> GetExam(int count)
        {
            return Enumerable.Range(1, 2).Take(count).ToList();
        }
    }
}