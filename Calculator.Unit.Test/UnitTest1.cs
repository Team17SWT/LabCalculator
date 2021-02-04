using NUnit.Framework;

namespace Calculator.Unit.Test
{
    public class CalculatorTest
    {
        private Calculator uut;
        [SetUp]
        public void Setup()
        {
            uut = new Calculator();
        }

        [Test]
        public void Add_AddTwoNumbers_Is7point5()
        {
            //Arrange -- Look at SetUp

            //Act
            var result = uut.Add(5, 2.5);

            //Assert
            Assert.That(result, Is.EqualTo(7.5));
        }
        [Test]
        public void Subtract_SubtractTwoNumbers_Is2()
        {
            //Arrange -- look at setup

            //Act
            var result = uut.Subtract(5, 3);

            //Assert
            Assert.That(result, Is.EqualTo(2));
        }
        [Test]
        public void Multiply_MultiplyTwoNumbers_Is56()
        {
            //Arrange -- look at setup

            //Act
            var result = uut.Multiply(7, 8);

            //Assert
            Assert.That(result, Is.EqualTo(56));
        }
        [Test]
        public void Multiply_PowerANumber_Is25()
        {
            //Arrange -- look at setup

            //Act
            var result = uut.Power(5, 2);

            //Assert
            Assert.That(result, Is.EqualTo(25));
        }

        [Test]

        public void Add_CheckAccumulator_CorrectAmount()
        {

            // Act

            uut.Add(5, 5);
            uut.Add(10, 10);

            // Assert

            Assert.That(uut.Accumulator,Is.EqualTo(20));
        }

        
    }
}