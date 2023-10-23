using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber.Interfaces
{
    public interface INumberGenerator
    {
        int Value { get; set; }
        void NewValueRandom();
        void SetNewRangeLimits(int newMinValue, int newMaxValue);
    }
}
