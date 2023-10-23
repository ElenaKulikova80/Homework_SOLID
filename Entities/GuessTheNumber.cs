using GuessTheNumber.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber.Entities
{
    public class GuessNumber
    {
        private readonly Settings _settings;
        private readonly Messager _messager;
        private readonly NumberGenerator _numberGenerator;
        private readonly CheckingValueInput _checkingValueInput;

        public GuessNumber(Settings settings, Messager messager, NumberGenerator numberGenerator, CheckingValueInput checkingValueInput)
        {
            _settings = settings;
            _messager = messager;
            _numberGenerator = numberGenerator;
            _numberGenerator.SetNewRangeLimits(settings.MinValue, settings.MaxValue);
            _numberGenerator.NewValueRandom();
            _checkingValueInput = checkingValueInput;
            _checkingValueInput.SetHiddenNumber(_numberGenerator.Value);
        }
        public void Start()
        {
            int counterAttempt = _settings.AttemptsNumber;

            CounterAttempt counter = new CounterAttempt();
            counter.SetCountAttempt(counterAttempt);
            Management management = new Management(counter, _checkingValueInput);
            management.OnMatch += Controller_OnMatch;
            management.OnLower += Controller_OnLower;
            management.OnHigher += Controller_OnHigher;
            management.WhenThereAreNoAttemptst += Controller_WhenThereAreNoAttemptst;

            string input;
            int attemptValue;
            _operationFinishFlag = false;

            for (; ; )
            {

                _messager.PrintMinMaxValue(_settings.MinValue, _settings.MaxValue);
                _messager.PrintNumberInput(counterAttempt);

                input = Console.ReadLine();

                
                if (!ParseInput.TryParse(input))
                {
                    _messager.PrintErrorInputMessage();
                    continue;
                }

                attemptValue = int.Parse(input);
                management.DoIteration(attemptValue);

                if (_operationFinishFlag) break;
                counterAttempt--;
            }
        }

        private bool _operationFinishFlag;

        private void Controller_OnMatch(int currentAttempt)
        {
            _messager.PrintSolutionMessage(currentAttempt);
            _operationFinishFlag = true;
        }

        private void Controller_OnLower(int currentAttempt)
        {
            _messager.PrintNumberLower(currentAttempt);
        }

        private void Controller_OnHigher(int currentAttempt)
        {
            _messager.PrintNumberHigher(currentAttempt);
        }

        private void Controller_WhenThereAreNoAttemptst()
        {
         
            if (_operationFinishFlag == true) return;


            _messager.PrintNoAttemptMessage(_numberGenerator.Value);
            _operationFinishFlag = true;
        }

        private bool CheckWhetherSettingsCorrect(int attemptsCounter)
        {
            if (attemptsCounter < 1)
            {
                Console.WriteLine($"Введено неверное значение попыток ({attemptsCounter})\n." +
                                    "Количество попыток должно быть больше 0. Программа завершает работу");
                return false;
            }

            return true;
        }
    }
}
//}
