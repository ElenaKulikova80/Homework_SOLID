using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using GuessTheNumber.Entities;

namespace GuessTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Settings settings = null;
            do
            {
                Console.WriteLine("Введите через запятую следующие данные: \n - минимальное значение числа" +
                                  "\n - максимальное значение числа\n - количество попыток\n");
                string input = Console.ReadLine();
                settings = ParseInput.ParseInputValue(input);
                if (settings == null) Console.WriteLine("\n Введены некорректные значения. Необходимо повторить ввод данных.\n");
            }
            while (settings == null);

            Messager messager = new Messager();
            GuessNumber guessnumber = new GuessNumber(settings, messager, new NumberGenerator(), new CheckingValueInput());
            guessnumber.Start();
            Console.WriteLine("Нажмите Enter, чтобы завершить работу программы");
            Console.ReadLine();
        }
    }
}
