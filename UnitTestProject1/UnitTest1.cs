using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using System;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        
            public void MinAVG_ShouldReturnRoundedAverage()
            {
                string[] marks = { "4", "5", "3", "2", "4" };
                double expected = 3.0;

                Class1 calculator = new Class1();

                double result = calculator.MinAVG(marks: marks);

                Assert.AreEqual(expected: expected, actual: result);
            }
        
    }
}
