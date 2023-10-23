using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber.Entities
{
    internal class CheckingValueInputLickov: CheckingValueInput
    {
        public int GetHiddenNumber => _randomNumber;
    }
}
