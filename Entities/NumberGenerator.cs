using GuessTheNumber.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber.Entities
{
    public class NumberGenerator : INumberGenerator
    {
        protected int _minValue;
        protected int _maxValue;
        public int Value { get; set; }

        public NumberGenerator(int minValue = 0, int maxValue = 100)
        {
            _minValue = minValue;
            _maxValue = maxValue;
            NewValueRandom();
        }


        public virtual void NewValueRandom()
        {
            Random random = new Random();
            Value = random.Next(_minValue, _maxValue);
        }
        public void SetNewRangeLimits(int minValue, int maxValue)
        {
            _minValue = minValue;
            _maxValue = maxValue;
        }
    }
}
