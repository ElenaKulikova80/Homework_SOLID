using GuessTheNumber.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber.Entities
{
    public class Settings:ISettings
    {
        public Settings(int minValue, int maxValue, int attemptsNumber)
        {
            MinValue = minValue;
            MaxValue = maxValue;
            AttemptsNumber = attemptsNumber;
        }
        public int MinValue { get; set; }
        public int MaxValue { get; set; }
        public int AttemptsNumber { get; set; }
    }
}
