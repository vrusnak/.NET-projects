using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment_6_lvl2;

namespace InvoiceTest
{
    [TestClass]
    public class Assignment_6_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            var p = new Product();
            p.Hej(5);
        }
    }
}
