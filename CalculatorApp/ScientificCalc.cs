using System;
using System.Runtime.ConstrainedExecution;

namespace Scientific
{
    public class SciCal
    {
        public double Power(double a, double b) => Math.Pow(a, b);
        public double SquareRoot(double a) => Math.Sqrt(a);
        public double Sin(double a)
        {
            double radians = a * Math.PI / 180;
            return Math.Sin(radians);
        } 
        public double Cos(double a)
        {
            double radians = a * Math.PI / 180;
            return Math.Cos(radians);
        }

    }

    
}