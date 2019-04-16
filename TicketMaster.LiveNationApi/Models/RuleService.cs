using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicketMaster.LiveNationApi.Models
{
    public class RuleService
    {
        private readonly List<IRule> rules;

        public RuleService()
        {
            this.rules = new List<IRule>();

            // Add all the rules the service will use
            this.rules.Add(new LiveNationRule()); // This rule takes precedent
            this.rules.Add(new LiveRule());
            this.rules.Add(new NationRule());
        }
        // [1,2,3,4,4,5,5,6]
        //[]
        public ResultModel ApplyRules(string inputsRange) //1,20
        {
            //added this
            var intergerCounter = 0;

            var result = new ResultModel { Result = "" };
            
            // Check empty inputs
            if (string.IsNullOrEmpty(inputsRange))
            {
                result.Result = "invalid inputs";
                return result;
            }

            // create an array from the inputs string using comma as a separator
            var inputList = inputsRange.Split(",");
            var start = Convert.ToInt32(inputList[0]);
            var end = Convert.ToInt32(inputList[1]);

            for (int i = start; i <= end; i++)
            {
                // this is to check if a rule was matched
                var ruleMatched = false;
                              

                // Iterate through the rules to get a rule that matches
                foreach (var rule in this.rules)
                {
                    if(rule.Match(i))
                    {
                        result.Result += " " +rule.PrintWord();
                        rule.Counter++;

                        // a rule is matched
                        ruleMatched = true;

                        // exist the rules iteration
                        break;
                    }
                }

                
                // No rule is mtached so we print the input itself
                if (!ruleMatched)
                {
                    intergerCounter++;
                    result.Result += " " + i;
                }
            }
           
            result.Summary = new SummaryModel();

            foreach (var rule in this.rules)
            {
                // How many input numbers passed the livenation rule
                if (rule.Name == "LiveNation")
                {
                    result.Summary.LiveNation = rule.Counter;
                }

                // How many input numbers passed the nation rule
                if (rule.Name == "Nation")
                {
                    result.Summary.Nation = rule.Counter;
                }

                // How many input numbers passed the live rule
                if (rule.Name == "Live")
                {
                    result.Summary.Live = rule.Counter;
                }
            }

            //here added 
            result.Summary.Integer = intergerCounter;
            
            return result;
        }
    }
}
