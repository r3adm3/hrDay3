using Microsoft.VisualStudio.TestTools.UnitTesting;
using HackerRankDay3;

namespace HackerRankDay3.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void IfNIsOneItsWeird()
        {
            //arrange 
            int n = 1;

            //act
            string result = Work.IsItWeird(n);

            //assert
            Assert.AreEqual(result, "Weird");

        }

        [TestMethod]
        public void IfNIsFiveItsWeird()
        {
            //arrange 
            int n = 5;

            //act
            string result = Work.IsItWeird(n);

            //assert
            Assert.AreEqual(result, "Weird");

        }

        [TestMethod]
        public void IfNIsTwoItsNotWeird()
        {
            //arrange 
            int n = 2;

            //act
            string result = Work.IsItWeird(n);

            //assert
            Assert.AreEqual(result, "Not Weird");

        }

        [TestMethod]
        public void IfNIsFourItsNotWeird()
        {
            //arrange 
            int n = 4;

            //act
            string result = Work.IsItWeird(n);

            //assert
            Assert.AreEqual(result, "Not Weird");

        }

        [TestMethod]
        public void IfNIsSixItsWeird()
        {
            //arrange 
            int n = 6;

            //act
            string result = Work.IsItWeird(n);

            //assert
            Assert.AreEqual(result, "Weird");

        }

        [TestMethod]
        public void IfNIsTwentyItsNotWeird()
        {
            //arrange 
            int n = 20;

            //act
            string result = Work.IsItWeird(n);

            //assert
            Assert.AreEqual(result, "Not Weird");

        }

        [TestMethod]
        public void IfNIsTwentyTwoItsNotWeird()
        {
            //arrange 
            int n = 22;

            //act
            string result = Work.IsItWeird(n);

            //assert
            Assert.AreEqual(result, "Not Weird");

        }

        [TestMethod]
        public void IfNIsEighteenItsWeird()
        {
            //arrange 
            int n = 18;

            //act
            string result = Work.IsItWeird(n);

            //assert
            Assert.AreEqual(result, "Weird");

        }
    }
}
