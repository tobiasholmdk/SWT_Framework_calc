using Calculator;
using NUnit.Framework;

namespace CalculatorTest
{
    [TestFixture]
    public class Test
    {
            
        private CalculatorEx _cal;
        [SetUp]
        public void Init()
        {
            _cal = new CalculatorEx();
        }
        [TestCase(2,5,7)]
        [TestCase(-2,5,3)]
        [TestCase(200,5000,5200)]
        public void Addition(double a, double b, double x)
        {
            Assert.That(_cal.addition(a,b),Is.EqualTo(x));
        }

        [TestCase(2,5,-3)]
        [TestCase(-2,5,-7)]
        [TestCase(200,5000,-4800)]

        public void Subtraction(double a, double b, double x)
        {
            Assert.That(_cal.subtract(a,b).Equals(x));
        }
        [TestCase(2,5,10)]
        [TestCase(-2,5,-10)]
        [TestCase(200,5000,1000000)]
        public void Multiply(double a, double b, double x)
        {
            Assert.That(_cal.multiply(a,b),Is.EqualTo(x));
        }

        [TestCase(2, 3, 8)]
        [TestCase(2, 5, 32)]
        [TestCase(3, 3, 27)]
        public void Power(double a, double b, double x)
        {
            Assert.That(_cal.power(a,b).Equals(x));
        }
        [TestCase(10,5,2)]
        [TestCase(100,20,5)]
        [TestCase(5000,200,25)]
        public void Div(double a, double b, double x)
        {
            Assert.That(_cal.div(a,b),Is.EqualTo(x));
        }
        [TestCase(5,2,1)]
        [TestCase(8,4,0)]
        [TestCase(200,5000,200)]
        public void Mod(double a, double b, double x)
        {
            Assert.That(_cal.mod(a,b),Is.EqualTo(x));
        }
    }
}