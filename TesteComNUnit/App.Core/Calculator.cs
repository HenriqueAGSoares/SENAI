//using System;

namespace App.Core
{
    public class Calculator
    {
        public int Sum(int a, int b) => a + b;
        public int Sub(int a, int b) => a - b;
        public int Mul(int a, int b) => a * b;

        public double Div(int a, int b)
        {
            if (b == 0) throw new DivideByZeroException("Divisor não pode ser zero.");
            return a / b;
        }
    }
}