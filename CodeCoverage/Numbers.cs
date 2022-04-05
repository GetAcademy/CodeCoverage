using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCoverage
{
    public class Numbers
    {
        private readonly List<int> _numbers;

        public Numbers()
        {
            _numbers = new List<int>();
        }

        public void Add(int number)
        {
            _numbers.Add(number);
        }

        public int GetSum()
        {
            return _numbers.Sum();
        }

        public double GetMean()
        {
            return _numbers.Average();
        }

        public double? GetMedian()
        {
            var count = _numbers.Count;
            if (count == 0) return null;
            if (count % 2 == 1) return _numbers[count / 2];
            var index = count / 2;
            return (_numbers[index] + _numbers[index - 1]) / 2.0;
        }

        public double? GetMedian2()
        {
            var count = _numbers.Count;
            if (count % 2 == 1) return _numbers[count / 2];
            var index = count / 2;
            return (_numbers[index] + _numbers[index - 1]) / 2;
        }

        public double? GetMedian3()
        {
            try
            {
                var count = _numbers.Count;
                if (count % 2 == 1) return _numbers[count / 2];
                var index = count / 2;
                return (_numbers[index] + _numbers[index - 1]) / 2;
            }
            catch
            {
                return null;
            }
        }

        /*
         Tom liste: null    
         1 2 30 => median 2
         1 4 16 50 => snittet av 4 og 16
         */
    }
}
