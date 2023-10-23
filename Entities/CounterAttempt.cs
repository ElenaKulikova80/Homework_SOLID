using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuessTheNumber.Interfaces;

namespace GuessTheNumber.Entities
{
    public class CounterAttempt:ICounterAttempt
    {
        private int _attemptPassed; //прошло попыток

        public void SetCountAttempt(int currAttempt)
            => _attemptPassed = currAttempt;

        public void ReducingAttempts()
        {
            _attemptPassed -=1;
            if (_attemptPassed < 1) WhenThereAreNoAttempts();
        }

        public event Action WhenThereAreNoAttempts;
    }
}
