using Microsoft.VisualStudio.TestTools.UnitTesting;
using gitOrchestrated;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitOrchestrated.Tests
{
    [TestClass()]
    public class BrowserTests
    {
        [TestMethod()]
        public void SayHelloTest()
        {
            //Arrange
            var currentProduct = new Browser();
            currentProduct.Name = "saw";
            currentProduct.Id = 1;
            currentProduct.Description = "smth";
            var expected = "Hello saw (smth) 1";

            //Act
            var actual = currentProduct.SayHello();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}