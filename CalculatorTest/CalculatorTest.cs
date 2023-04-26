using net_calculator_tester;

namespace CalculatorTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Calculator calculator = new Calculator();
        }

        [Test]
        [TestCase(2.5F, 6.7F)]
        public void TestAdd(float num1, float num2)
        {
            Assert.DoesNotThrow(() => Calculator.Add(num1, num2));
        }
    }
}