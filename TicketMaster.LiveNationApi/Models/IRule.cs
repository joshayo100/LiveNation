using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketMaster.LiveNationApi.Models
{
    public interface IRule
    {
        bool Match(int value);

        string PrintWord();

        int Counter { get; set; }

        string Name { get; }
    }
}
