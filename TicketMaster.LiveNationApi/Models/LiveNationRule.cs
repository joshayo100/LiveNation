using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketMaster.LiveNationApi.Models
{
    public class LiveNationRule : IRule
    {
        public int Counter { get; set; }
        
        public string Name => "LiveNation";

        public bool Match(int value)
        {
            var result = value % 3 == 0 && value % 5 == 0;

            return result;
        }

        public string PrintWord()
        {
            return " livenation";
        }
    }
}
