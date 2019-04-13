using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator.Pages;


namespace Calculator.Tests
{
    [TestClass]
    public class UnitTestCalc
    {
        [TestMethod]
        public void TestCalcAddTwoNumbers()
        {
            IndexModel indexModel = new IndexModel {firstNumber = 7, secondNumber = 3};
            indexModel.OnPost();
            Assert.AreEqual(10, indexModel.Result);
        }

        [TestMethod]
        public void TestCalcFailingConditon()
        {
            IndexModel indexModel = new IndexModel {firstNumber = 7, secondNumber = 3};
            indexModel.OnPost();
            Assert.AreNotEqual(11, indexModel.Result);
        } 
    }
}