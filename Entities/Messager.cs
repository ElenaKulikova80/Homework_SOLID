using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using GuessTheNumber.Interfaces;
using GuessTheNumber.Entities;

namespace GuessTheNumber.Entities
{
    public class Messager : IMessager
    {
        public void PrintMinMaxValue(int minValue, int maxValue)
        {
            Console.WriteLine($"Число загадано от {minValue} до {maxValue}");
        }
        public void PrintNumberInput(int attemptLeft)
        {
            PrintAttemptLeft(attemptLeft);
            Console.WriteLine("Введите ваш вариант числа:\n ");
        }
        private void PrintAttemptLeft(int attemptLeft)
        {
            Console.WriteLine($"У вас есть {attemptLeft} попыток, чтобы угадать загаданное число");
        }
        public void PrintNumberLower(int EnteredValue)
        {
            Console.WriteLine($"Введенное число {EnteredValue} меньше, чем загаданное");
        }
        public void PrintNumberHigher(int EnteredValue)
        {
            Console.WriteLine($"Введенное число {EnteredValue} больше, чем загаданное");
        }
        public void PrintSolutionMessage(int EnteredValue)
        {
            Console.WriteLine($"Число {EnteredValue} угадано!\n");
        }
        public void PrintRetryMessage(int attemptLeft)
        {
            Console.Write("Попробуйте еще раз:");
            PrintNumberInput(attemptLeft);
        }
        public void PrintNoAttemptMessage(int answerValue)
        {
            Console.WriteLine($"Количество попыток закончилось. Число неугадано. Ответ = {answerValue}");
        }
        public void PrintErrorInputMessage()
        {
            Console.WriteLine($"Ошибка формата ввода. Попробуйте снова. \n");
        }
    }
}
