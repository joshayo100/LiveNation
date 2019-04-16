using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketMaster.LiveNationApi.Models
{
    public class LiveRule : IRule
    {
        public int Counter { get; set; }

        public string Name => "Live";

        //method 
        public bool Match(int value)
        {
            var result = value % 3 == 0;

            return result;
        }

        public string PrintWord()
        {
            return " live";
        }
    }
}
