using GuessTheNumber.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber.Entities
{
    public class CheckingValueInput:ICheckingValueInput
    {
        protected int _randomNumber;
        public int CheckerValue (int inputValue)
        {
            return inputValue.CompareTo(_randomNumber); //hiddenNumber
        }
        public void SetHiddenNumber(int randomNumber)
        {
            _randomNumber = randomNumber;
        }
    }
}
