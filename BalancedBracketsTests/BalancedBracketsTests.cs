using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }

        //1. Write a test that returns true when the string is empty
        [TestMethod]

        public void EmptyStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets(""));
        }

        //2. Test returns if string is filled 
        [TestMethod]

        public void FilledStringReturnsTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }

        //3. Test returns true if brackets are correct format ([])
        [TestMethod]

        public void CorrectBracketsReturnTrue()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));
        }


		//4. test if string is just two brackets faced wrong way, return false
		[TestMethod]
		public void TwoOpenBracketsReturnsFalse()
		{
			Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[["));
		}

        //5. test if string is just two brackets faced wrong way, return false
        [TestMethod]
        public void TwoClosedBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]]"));
        }

        

		//5. Test false if string is empty
		[TestMethod]
		public void TooManyBracketsReturnsFalse()
		{
			Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[[]]]["));
		}

        //6. Test false if inversed brackets 
        [TestMethod]
        public void InversedBracketsReturnsFalse()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]["));
        }





    }
}
