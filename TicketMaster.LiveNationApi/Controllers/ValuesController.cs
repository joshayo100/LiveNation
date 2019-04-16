using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TicketMaster.LiveNationApi.Models;

namespace TicketMaster.LiveNationApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        [Route("livenation")]
        // GET api/values/livenation?inputs=1,20
        public ResultModel LiveNation(string inputs)//1,20
        {
            var service = new RuleService();
            var result = service.ApplyRules(inputs);

            return result;
        }
    }
}
