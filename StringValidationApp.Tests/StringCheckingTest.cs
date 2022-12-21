using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StringValidationApp.Tests
{
    [TestClass]
    public class StringCheckingTest
    {
        [TestMethod()]
        public void StringChecking_EmptyString_ReturnTrue()
        {
            string inputString = string.Empty;

            bool outputValue = Program.StringChecking(inputString);

            Assert.IsTrue(outputValue);
        }
        [TestMethod()]
        public void StringChecking_StringWithoutBrackets_ReturnTrue()
        {
            string inputString = "Каждый охотник желает знать, где сидит фазан.";

            bool outputValue = Program.StringChecking(inputString);

            Assert.IsTrue(outputValue);
        }
        [TestMethod()]
        public void StringChecking_StringWithCorrectBrackets_ReturnTrue()
        {
            string inputString = "Этот текст (строка) предназначен для тестирования [бы{стр}ой] проверки вхождения скобок {любых [из трех видов]}";

            bool outputValue = Program.StringChecking(inputString);

            Assert.IsTrue(outputValue);
        }
        [TestMethod()]
        public void StringChecking_StringWithoutCorrectBrackets_ReturnFalse()
        {
            string inputString = "[ ] ({}) ) [])";

            bool outputValue = Program.StringChecking(inputString);

            Assert.IsFalse(outputValue);
        }
    }
}
