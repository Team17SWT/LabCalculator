using NUnit.Framework;
using System;

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

        public void Add_AddTwoMinusNumbers_IsMinus11()
        {
            //Arrange -- Look at SetUp

            //Act

            var result = uut.Add(-5, -6);

            //Assert
            Assert.That(result, Is.EqualTo(-11));
        }

        [Test]

        public void Add_AddTwoNumbers_Is25()
        {
            //Arrange -- Look at SetUp

            //Act

            var result = uut.Add(10, 15);

            Assert.That(result, Is.EqualTo(25));
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

        public void Subtract_SubtractTwoMinusNumbers_Is1()
        {
            //Arrange -- Look at setup

            //Act
            var result = uut.Subtract(-15, -16);

            //Assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Subtract_SubtractTwoNumbersNegativeAndPositive_Is15()
        {
            //Arrange -- Look at setup

            //Act
            var result = uut.Subtract(15, -3);

            //Assert
            Assert.That(result, Is.EqualTo(18));
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

        public void Multiply_MultiplyTwoNegativeNumbers_Is25()
        {
            //Arrange -- look at setup

            //Act
            var result = uut.Multiply(-5, -5);

            //Assert
            Assert.That(result, Is.EqualTo(25));
        }

        [Test]

        public void Multiply_MultiplyNegativeAndPositiveNumbers_Minus36()
        {
            //Arrange -- look at setup

            //Act
            var result = uut.Multiply(-6, 6);

            //Assert
            Assert.That(result, Is.EqualTo(-36));
        }

        [Test]
        public void Power_PowerANumber_Is25()
        {
            //Arrange -- look at setup

            //Act
            var result = uut.Power(5, 2);

            //Assert
            Assert.That(result, Is.EqualTo(25));
        }

        [Test]

        public void Power_PowerANegativeNumber_Is25()
        {
            //Arrange -- look at setup

            //Act
            var result = uut.Power(-5, 2);

            //Assert
            Assert.That(result, Is.EqualTo(25));
        }

        [Test]

        public void Power_PowerANumberWithNegative_Is0point2()
        {
            //Arrange -- look at setup

            //Act
            var result = uut.Power(5, -1);

            //Assert
            Assert.That(result,Is.EqualTo(0.2));
        }

        [Test]

        public void Accumulator_AddTwoItems_AccumulatorIsLastItem()
        {
            //Arrange -- look at SetUp

            // Act

            uut.Add(5, 5);
            uut.Add(10, 10);

            // Assert

            Assert.That(uut.Accumulator,Is.EqualTo(20));
        }

        [Test]
        public void Accumulator_SubtractThreeNumbers_IsLastItem()
        {
            //Arrange -- look at SetUp

            // Act

            uut.Subtract(5, 5);
            uut.Subtract(10, 10);
            uut.Subtract(7, 2);

            // Assert

            Assert.That(uut.Accumulator, Is.EqualTo(5));
        }
        [Test]
        public void Accumulator_AddAndMultiplyTwoItems_IsLastItem()
        {
            //Arrange -- look at SetUp

            // Act

            uut.Add(5, 5);
            uut.Multiply(10, 10);
           

            // Assert
            Assert.That(uut.Accumulator, Is.EqualTo(100));
        }

        [Test]
        public void Divide_DivideTwoNumbers_Is3()
        {
            //Arrange -- look at setup

            //Act
            var result = uut.Divide(6, 2);

            //Assert
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Divide_DivideTwoNumbers_Is3point33()
        {
            //Arrange -- look at setup

            //Act
            var result = uut.Divide(10, 3);

            //Assert
            Assert.That(result, Is.EqualTo(3.33).Within(3));
        }

        [Test]
        public void Divide_DivideTwoNumbers_Is5()
        {

            //Arrange -- look at setup

            //Act
            var result = uut.Divide(25, 5);

            //Assert
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Divide_DivideByZero_ThrowsDivideByZeroException()
        {
            //Arrange -- Look at setup

            //act

            //Assert
            Assert.That(() => uut.Divide(7,0), Throws.TypeOf<DivideByZeroException>());

        }
    }
}