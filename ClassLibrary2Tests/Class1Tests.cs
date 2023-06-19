using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.Tests
{
    [TestClass()]
    public class Class1Tests
    {
        [TestMethod()]
        public void MinAVG_ShouldReturnRoundedAverage()
        {
            string[] marks = { "4", "5", "3", "2", "4" };
            double expected = 3.0;

            Class1 calculator = new Class1();

            double result = calculator.MinAVG(marks: marks);

            Assert.AreEqual(expected: expected, actual: result);
        }
        [TestMethod()]
        public void MinAVG_ShouldReturnRoundedAverage1()
        {
            string[] marks = {};
            double expected = 3.0;

            Class1 calculator = new Class1();

            double result = calculator.MinAVG(marks: marks);

            Assert.AreEqual(expected: expected, actual: result);
        }
        [TestMethod()]
        public void MinAVG_ShouldReturnRoundedAverage2()
        {
            string[] marks = { "2", "2", "2", "2", "2" };
            double expected = 2.0;

            Class1 calculator = new Class1();

            double result = calculator.MinAVG(marks: marks);

            Assert.AreEqual(expected: expected, actual: result);
        }
    }
}