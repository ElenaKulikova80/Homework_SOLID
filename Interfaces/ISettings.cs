using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessTheNumber.Interfaces
{
    public interface ISettings
    {
        int MaxValue { get; set; }
        int MinValue { get; set; }
        int AttemptsNumber { get; set; }
    }
}
