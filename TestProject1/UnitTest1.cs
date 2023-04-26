using net_calculator_tester;

namespace TestProject1
{
    public class Tests
    {
        private Calculator calculator;
        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        //SOMMA

            //Risulta 10, GIUSTO
            [Test]
            [TestCase(2.5F, 7.5F)]
            public void Add(float num1, float num2)
            {
                Assert.AreEqual(10, calculator.Add(num1, num2));
            }

            //NON RISULTA 10, ERRATO
            [Test]
            [TestCase(2.3F, 7.5F)]
            public void AddError(float num1, float num2)
            {
                Assert.AreEqual(10, calculator.Add(num1, num2));
            }


        //SOTTRAZIONE
        [Test]
        [TestCase(2.5F, 7.5F)]
        public void Subtract(float num1, float num2)
        {
            float result = calculator.Subtract(num1, num2);
            Assert.AreEqual(-5, result);
        }

        //MOLTIPLICAZIONE
        [Test]
        [TestCase(2.5F, 7.5F)]
        public void Multiply(float num1, float num2)
        {
            float result = calculator.Multiply(num1, num2);
            Assert.AreEqual(18.75f, result);
        }

        //DIVISIONE
            // RISULTA 0.5F, GIUSTO
            [Test]
            [TestCase(2.5F, 5F)]
            public void TestDivideResult(float num1, float num2)
            {
                Assert.AreEqual(0.5F, calculator.Divide(num1, num2));
            }

            // RISULTA ERRORE
            [Test]
            [TestCase(2.5F, 0)]
            public void TestDivideError(float num1, float num2)
            {
                Assert.Throws<Exception>(() => calculator.Divide(num1, num2));
            }

    }
}