using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MinimalPath.DataProviders;

namespace MinimalPath.Test
{
    [TestClass]
    public class PerformanceTest
    {
        [TestMethod]
        public void TestPerformance()
        {
            AppFacade facade = new AppFacade();

            Stopwatch watch = Stopwatch.StartNew();

            facade.RunMinimumPathFinding(new RandomDataProvider());

            watch.Stop();

            Assert.IsTrue(watch.Elapsed < TimeSpan.FromMilliseconds(500));
        }

    }
}
