using System;

namespace ClassLibrary2
{
    public class Class1
    {
        public double MinAVG(string[] marks)
        {
            if (marks == null || marks.Length == 0)
            {
                throw new ArgumentException(message: "the agrugment is empty");
            }

            int sum = 0;

            foreach (string mark in marks)
            {
                if (!int.TryParse(s: mark, result: out int parsedMark))
                {
                    throw new ArgumentException(message: $"invalid mark: {mark}");
                }
                sum += parsedMark;
            }
            double average = (double)sum / marks.Length;
            double roundedAverage = Math.Floor(d: average);


            return roundedAverage;
        }
    }
}
