using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator.TestAutomation;


namespace Calculator.Tests
{
    [TestClass]
    public class CalcAddWebTests
    {
        [TestInitialize]
        public void Init()
        {
            Driver.Initialize();
        }
        
        [TestMethod]
        public void AddTwoNumbers()
        {
            CalcWebPage.GoTo();
            CalcWebPage.InsertNumbersToAdd(1, 1);
            CalcWebPage.Calculate();
            Assert.AreEqual(2, CalcWebPage.Result());

        }

        [TestCleanup]
        public void Cleanup()
        {
            Driver.Instance.Close();
        }
    }
}