using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using TicketMaster.LiveNationApi.Models;

namespace TicketMaster.LiveNationApi.UnitTests
{
    [TestClass]
    public class RuleServiceTests
    {

        //test case
        private RuleService service = new RuleService();

        [TestMethod]
        public void ApplyMethod_Null_Check_Success()
        {
            //apply rule test to see input 
            var result = service.ApplyRules(null);
            Assert.AreEqual(result.Result, "invalid inputs");
        }

        [TestMethod]
        public void ApplyMethod_Empty_Check_Success()
        {
            //apply rule test to see input 
            var result = service.ApplyRules("");
            Assert.AreEqual(result.Result, "invalid inputs");

        }
        //test input string 
        [TestMethod]
        public void String_Input_Test()
        {
            var result = service.ApplyRules("1,20");
            Assert.IsNotNull(result.Result);
        }

    }
}
