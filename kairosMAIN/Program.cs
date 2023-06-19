using ClassLibrary1;
using System;

namespace kairosMAIN
{
    class Program
    {

        public void MinAVG_ShouldReturnRoundedAverage()
        {
            string[] marks = { "4", "5", "3", "2", "4" };
            double expected = 3.0;

            Class1 calculator = new Class1();

            double result = calculator.MinAVG(marks: marks);

            Assert.AreEquel(expected: expected, actual: result);
        }

    }
}
