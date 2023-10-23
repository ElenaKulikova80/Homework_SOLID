using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber.Interfaces
{
    public interface ICounterAttempt
    {
        void SetCountAttempt(int currentAttempts);
        void ReducingAttempts(); //уменьшение попыток
        event Action WhenThereAreNoAttempts;
    }
}
