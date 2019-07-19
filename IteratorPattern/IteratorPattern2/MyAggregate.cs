using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern2
{
    class MyAggregate : IAggregate
    {
        List<string> values_ = null;

        public MyAggregate()
        {
            values_ = new List<string>();
        }

        #region IAggregate Members

        public IIterator GetIterator()
        {
            return new MyIterator(this);
        }

        #endregion

        public void Test(int max)
        {
            var rnd = new Random();
            var nums = new bool[max];
            
            for (var i = 0; i < max; i++)
            {
                var randomNum = rnd.Next(max);
                while (nums[randomNum])
                {
                    randomNum = rnd.Next(max);
                }
                nums[randomNum] = true;
                Console.WriteLine(randomNum);
            }
           

        }

        public IEnumerable<int> GetEvenNums()
        {
            for (var i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                    yield return i;
            }
            yield break;
        }

        public string this[int itemIndex]
        {
            get
            {
                if (itemIndex < values_.Count)
                {
                    return values_[itemIndex];
                }
                else
                {
                    return string.Empty;
                }
            }
            set
            {
                values_.Add(value);
            }
        }

        public int Count
        {
            get
            {
                return values_.Count;
            }
        }
    }
}
