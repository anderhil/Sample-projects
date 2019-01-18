using multiply.Interfaces;
using multiply.Multipliers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace multiply.test
{
    
    
    /// <summary>
    ///This is a test class for DefaultMultiplierTest and is intended
    ///to contain all DefaultMultiplierTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DefaultMultiplierTest
    {
        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for Multiply
        ///</summary>
        [TestMethod()]
        public void MultiplyTest()
        {
            IMultiplier target = new DefaultMultiplier();
            int rows = 2; 
            int columns = 3;
            int[,] expected = new int[2,3] {{1,2,3}, {2,4,6}};
            int[,] actual = target.BuildMultiplierTable(rows, columns);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
