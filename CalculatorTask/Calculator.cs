using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorTask
{
    internal class Calculator
    {
        public double Add(double FirstNumber, double SecondNumber)
        {
            return FirstNumber + SecondNumber;
        }
        public double Subtract(double FirstNumber, double SecondNumber)
        {
            return FirstNumber - SecondNumber;
        }
        public double Multiply(double FirstNumber, double SecondNumber)
        {
            return FirstNumber * SecondNumber;
        }
        public double Divide(double FirstNumber, double SecondNumber)
        {
            return FirstNumber / SecondNumber;
        }
    }
}
