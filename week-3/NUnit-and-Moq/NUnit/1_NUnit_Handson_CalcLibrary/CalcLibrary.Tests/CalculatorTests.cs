using NUnit.Framework;
using CalcLibrary;
using System;

namespace CalcLibrary.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        Calculator calculator;


        [SetUp]
        public void Init()
        {
            calculator = new Calculator();
        }



        [TestCase(20, 10, 10)]
        [TestCase(100, 50, 50)]
        public void Subtraction_Test
        (
            int a,
            int b,
            int expected
        )
        {
            int actual = calculator.Subtraction(a, b);

            Assert.That(actual, Is.EqualTo(expected));
        }




        [TestCase(5, 5, 25)]
        [TestCase(10, 2, 20)]
        public void Multiplication_Test
        (
            int a,
            int b,
            int expected
        )
        {
            int actual = calculator.Multiplication(a, b);

            Assert.That(actual, Is.EqualTo(expected));
        }





        [TestCase(20, 5, 4)]
        [TestCase(100, 10, 10)]
        public void Division_Test
        (
            int a,
            int b,
            int expected
        )
        {
            int actual = calculator.Division(a, b);

            Assert.That(actual, Is.EqualTo(expected));
        }





        [Test]
        public void Division_ByZero_Test()
        {
            try
            {
                calculator.Division(10, 0);

                Assert.Fail("Division by zero");
            }
            catch (ArgumentException ex)
            {
                Assert.That(
                    ex.Message,
                    Is.EqualTo("Division by zero")
                );
            }
        }






        [Test]
        public void TestAddAndClear()
        {
            calculator.Addition(10, 20);


            Assert.That(
                calculator.GetResult,
                Is.EqualTo(30)
            );


            calculator.AllClear();


            Assert.That(
                calculator.GetResult,
                Is.EqualTo(0)
            );

        }





        [TearDown]
        public void Cleanup()
        {
            
        }


    }
}