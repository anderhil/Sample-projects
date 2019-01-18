using multiply;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace multiply.test
{
    
    
    /// <summary>
    ///This is a test class for ArgumentParserTest and is intended
    ///to contain all ArgumentParserTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ArgumentParserTest
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

        public ArgumentParser GetParser()
        {
            return new ArgumentParser();
        }


        /// <summary>
        ///A test for Parse
        ///</summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void ParseNullTest()
        {
            ArgumentParser target = GetParser();
            string[] args = null;
            target.Parse(args);
        }        
        
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void ParseFirstArgumentWrongTest()
        {
            ArgumentParser target = GetParser();
            string[] args = new[] {"t"};
            target.Parse(args);
        }        
        
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void ParseSecondArgumentWrongTest()
        {
            ArgumentParser target = GetParser();
            string[] args = new[] {"1", "t"};
            target.Parse(args);
        }        
        
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void ParseThirdArgumentWrongTest()
        {
            ArgumentParser target = GetParser();
            string[] args = new[] {"1", "2", "csv4"};
            target.Parse(args);
        }        
        
        [TestMethod()]
        public void ParseAllValidArgumentTest()
        {
            ArgumentParser target = GetParser();
            string[] args = new[] {"1", "2", "csv"};
            target.Parse(args);
            Assert.AreEqual(target.Rows, 1);
            Assert.AreEqual(target.Columns, 2);
            Assert.AreEqual(target.Format, OutputFormat.CSV);
        }  
        
        [TestMethod()]
        public void ParseTwoValidArgumentTest()
        {
            ArgumentParser target = GetParser();
            string[] args = new[] {"1", "html"};
            target.Parse(args);
            Assert.AreEqual(target.Rows, 1);
            Assert.AreEqual(target.Columns, 1);
            Assert.AreEqual(target.Format, OutputFormat.Html);
        }        
        
        [TestMethod()]
        public void ParseDefaultFormatArgumentTest()
        {
            ArgumentParser target = GetParser();
            string[] args = new[] {"2", "3"};
            target.Parse(args);
            Assert.AreEqual(target.Rows, 2);
            Assert.AreEqual(target.Columns, 3);
            Assert.AreEqual(target.Format, OutputFormat.Console);
        }        
        
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void ParseRangeTest()
        {
            ArgumentParser target = GetParser();
            string[] args = new[] {"21", "1"};
            target.Parse(args);
        }       
        
        [TestMethod()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Parse2RangeTest()
        {
            ArgumentParser target = GetParser();
            string[] args = new[] {"19", "-1"};
            target.Parse(args);
        }
    }
}
