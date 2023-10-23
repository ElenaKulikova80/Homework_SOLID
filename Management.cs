using GuessTheNumber.Entities;
using GuessTheNumber.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber
{
    public class Management
    {
        private ICounterAttempt _counter;
        private ICheckingValueInput _checker;

        public event Action<int> OnMatch;
        public event Action<int> OnLower;
        public event Action<int> OnHigher;
        public event Action WhenThereAreNoAttemptst;

        public Management(ICounterAttempt counter, ICheckingValueInput checker)
        {
            _counter = counter;
            _checker = checker;
            _counter.WhenThereAreNoAttempts += () => WhenThereAreNoAttemptst();
        }

        public void DoIteration(int currentAttempt)
        {
            int result = _checker.CheckerValue(currentAttempt);


            if (result == 0) OnMatch(currentAttempt);
            else if (result == -1) OnLower(currentAttempt);
            else OnHigher(currentAttempt);

            _counter.ReducingAttempts();
        }
    }
}
