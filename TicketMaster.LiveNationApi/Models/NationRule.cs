using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketMaster.LiveNationApi.Models
{
    public class NationRule : IRule
    {
        //count x amound of times 
        public int Counter { get; set; }

        public string Name => "Nation";

        // used boolean for question 
        public bool Match(int value)
        {
            var result = value % 5 == 0;
            return result;
        }

        public string PrintWord()
        {
            return " nation";
        }
    }
}
