using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using multiply.OutputFormatters;

namespace multiply.test
{

    [TestClass]
    public class FormattersTest
    {

        [TestMethod]
        public void HtmlFormatterTest()
        {
            HtmlOutputFormatter htmlFormatter = new HtmlOutputFormatter();
            htmlFormatter.WriteResult(new int[,] {{1,2}, {2,4}});
            string actual = htmlFormatter.OutputString;
            string expected =
                "<html><body><table><tr><td></td><td>1</td><td>2</td></tr><tr><td>1</td><td>1</td><td>2</td></tr><tr><td>2</td><td>2</td><td>4</td></tr></table></body></html>";
            Assert.AreEqual(actual, expected);
        }
        
        [TestMethod]
        public void CSVFormatterTest()
        {
            CSVOutputFormatter htmlFormatter = new CSVOutputFormatter(";");
            htmlFormatter.WriteResult(new int[,] {{1,2}, {2,4}});
            string actual = htmlFormatter.OutputString;
            string expected = " ;1;2"+Environment.NewLine+"1;1;2"+Environment.NewLine+"2;2;4" + Environment.NewLine;
            Assert.AreEqual(actual, expected);
        }         
    }
}
