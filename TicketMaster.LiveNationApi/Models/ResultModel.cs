using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketMaster.LiveNationApi.Models
{
    public class ResultModel
    {
        public string Result { get; set; }

        public SummaryModel Summary { get; set; }
    }

    public class SummaryModel
    {
        //my properties used 
        public int Live { get; set; }

        public int Nation { get; set; }

        public int LiveNation { get; set; }

        public int Integer { get; set; }

   
    }
}
