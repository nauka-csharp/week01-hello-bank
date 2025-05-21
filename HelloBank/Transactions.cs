using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloBank
{

    public record Transaction(decimal Amount, DateTime Date, string Note)
    {
        /// <summary>
        /// Pojedyncza operacja na koncie bankowym (dodatnia = wpłata, ujemna = wypłata).
        /// 
        /// var t = new Transaction(150m, DateTime.UtcNow, "wplata");
        /// var(amt, dt, note) = t;     // deconstruction
        /// var copy = t with { Notes = "poprawka opisu" };  // klon z modyfikacją
        /// 
        /// 
        /// </summary>
        public string Kind => Amount switch
        {
            > 0 => "DEPOSIT",
            < 0 => "WITHDRAWAL",
            _ => "UNKNOWN"
        };
    }
}
