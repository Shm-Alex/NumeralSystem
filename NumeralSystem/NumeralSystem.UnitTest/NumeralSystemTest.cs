using System;

namespace NumeralSystem.UnitTest
{
    [TestClass]
    public sealed class NumeralSystemTest
    {
        [ClassCleanup]
        public static void ClassCleanup()
        {
            // This method is called once for the test class, after all tests of the class are run.
        }

        [TestInitialize]
        public void TestInit()
        {
            // This method is called before each test method.
        }

        [TestCleanup]
        public void TestCleanup()
        {
            // This method is called after each test method.
        }

        [TestMethod]
        public void SimpleHexTest()
            
        {
            var ns = new NumeralSystem(new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E','F' });
            Assert.AreEqual("1", ns.ToDigitsStr(1));
            Assert.AreEqual("2", ns.ToDigitsStr(2));
            Assert.AreEqual("3", ns.ToDigitsStr(3));
            Assert.AreEqual("4", ns.ToDigitsStr(4));
            Assert.AreEqual("5", ns.ToDigitsStr(5));
            Assert.AreEqual("6", ns.ToDigitsStr(6));
            Assert.AreEqual("7", ns.ToDigitsStr(7));
            Assert.AreEqual("8", ns.ToDigitsStr(8));
            Assert.AreEqual("9", ns.ToDigitsStr(9));
            Assert.AreEqual("A", ns.ToDigitsStr(10));
            Assert.AreEqual("B", ns.ToDigitsStr(11));
            Assert.AreEqual("C", ns.ToDigitsStr(12));
            Assert.AreEqual("D", ns.ToDigitsStr(13));
            Assert.AreEqual("E", ns.ToDigitsStr(14));
            Assert.AreEqual("F", ns.ToDigitsStr(15));
            Assert.AreEqual("0", ns.ToDigitsStr(0));

        }
        [TestMethod]
        public void SimpleBinaryTest()

        {
            var ns = new NumeralSystem(new char[] { '0', '1' });
            Assert.AreEqual("1", ns.ToDigitsStr(1));
            Assert.AreEqual("10", ns.ToDigitsStr(2));
            Assert.AreEqual("11", ns.ToDigitsStr(3));
            Assert.AreEqual("100", ns.ToDigitsStr(4));
            Assert.AreEqual("101", ns.ToDigitsStr(5));
            Assert.AreEqual("110", ns.ToDigitsStr(6));
            Assert.AreEqual("111", ns.ToDigitsStr(7));
            Assert.AreEqual("1000", ns.ToDigitsStr(8));
            Assert.AreEqual("1001", ns.ToDigitsStr(9));
            Assert.AreEqual("1010", ns.ToDigitsStr(10));
            Assert.AreEqual("1011", ns.ToDigitsStr(11));
            Assert.AreEqual("1100", ns.ToDigitsStr(12));
            Assert.AreEqual("1101", ns.ToDigitsStr(13));
            Assert.AreEqual("1110", ns.ToDigitsStr(14));
            Assert.AreEqual("1111", ns.ToDigitsStr(15));
            Assert.AreEqual("0", ns.ToDigitsStr(0));

        }
        [TestMethod()]
        [DataRow("10", 2u)]
        public void SimpleBinaryTestDataDriven(string expected, uint testData)

        {
            var ns = new NumeralSystem(new char[] { '0', '1' });
            Assert.AreEqual(expected, ns.ToDigitsStr(testData));
        }

        }
}
