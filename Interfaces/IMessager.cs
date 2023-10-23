using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber.Interfaces
{
    public interface IMessager
    {
        void PrintMinMaxValue(int minValue, int maxValue);
        void PrintNumberInput(int attemptLeft);
        void PrintNumberLower(int EnteredValue);
        void PrintNumberHigher(int EnteredValue);
        void PrintSolutionMessage(int EnteredValue);
        void PrintRetryMessage(int attemptLeft);
        void PrintNoAttemptMessage(int answerValue);
        void PrintErrorInputMessage();

    }
}
