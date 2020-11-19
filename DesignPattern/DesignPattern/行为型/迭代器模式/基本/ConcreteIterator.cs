using System;

namespace DesignPattern.行为型.迭代器模式.基本
{
    public class ConcreteIterator : ITerator
    {
        private ConcreteAggregate _aggregate;
        private int _index;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            _aggregate = aggregate;
            _index = 0;
        }

        public int First()
        {
            return _aggregate.GetElement(0);
        }

        public int Next()
        {
            if (_index < _aggregate.Length)
            {
                var m = _aggregate.GetElement(_index);
                _index++;
                return m;
            }
            throw new Exception("最后一个了");
        }

        public bool IsEnd()
        {
            return _index == _aggregate.Length;
        }

        public int CurrentItem()
        {
            return  _aggregate.GetElement(_index);
        }

        public void Reset()
        {
            _index = 1;
        }
    }
}