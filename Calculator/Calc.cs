using System;

namespace Calculator {
    public class CalculatorEx {
        public double addition (double a, double b) {
            return a + b;
        }
        public double subtract (double a, double b) {
            return a - b;
        }
        public double multiply (double a, double b) {
            return a * b;
        }
        public double power (double a, double b) {
            return Math.Pow (a, b);
        }
        public double div(double a, double b)
        {
            return a / b;
        }

        public double mod(double a, double b)
        {
            return a % b;
        }
    }
}