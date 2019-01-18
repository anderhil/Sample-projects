using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MinimalPath.DataProviders;
using MinimalPath.Exceptions;
using MinimalPath.Triangle;

namespace MinimalPath.Test
{
    [TestClass]
    public class TriangleReadingTest
    {
        [TestMethod]
        public void TestCorrectness()
        {
            var facade = new AppFacade();
            TrianglePath path = facade.RunMinimumPathFinding(new StringDataProvider("7\r\n6 3\r\n3 8 5\r\n11 2 10 9"));

            Assert.AreEqual(path.Sum, 18);
        }

        [TestMethod]
        public void TestCorrectness2()
        {
            var facade = new AppFacade();
            TrianglePath path = facade.RunMinimumPathFinding(new StringDataProvider("5\r\n4 1\r\n6 3 8\r\n8 4 3 9\r\n6 3 1 2 4"));

            Assert.AreEqual(path.Sum, 13);
        }  
        
        [TestMethod]
        public void TestCorrectness3()
        {
            var facade = new AppFacade();
            TrianglePath path = facade.RunMinimumPathFinding(new StringDataProvider("5\r\n4 1\r\n6 3 8\r\n8 4 3 9\r\n6 3 1 2 4\r\n7 7 8 5 3 8"));

            Assert.AreEqual(path.Sum, 17);
        }

        [TestMethod]
        [ExpectedException(typeof(NegativeNumberException))]
        public void TestNegativeNumber()
        {
            var data = new StringDataProvider("1 -2 5 6");
            var t = data.ReadTriangleLines().ToList();
        }

        [TestMethod]
        [ExpectedException(typeof(NotNumberException))]
        public void TestTextInLine()
        {
            var data = new StringDataProvider("1 1 hello 6");
            var t = data.ReadTriangleLines().ToList();
        }

        [TestMethod]
        [ExpectedException(typeof(NotTriangleException))]
        public void TestWrongTriangle()
        {
            var data = new StringDataProvider("1\r\n2 3\r\n4 5 6\r\n1 2 3 4 5");

            TriangleReader reader = new TriangleReader(data);

            reader.ReadTriangle();
        }

        [TestMethod]
        [ExpectedException(typeof(FileNotFoundException))]
        public void TestFileNotFound()
        {
            var data = new FileDataProvider("noFile.txt");

            TriangleReader reader = new TriangleReader(data);

            reader.ReadTriangle();
        }
    }
}
