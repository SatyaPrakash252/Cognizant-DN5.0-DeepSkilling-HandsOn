using NUnit.Framework;
using LeapYearCalculatorLib;


namespace LeapYearCalculatorLib.Tests
{


    [TestFixture]

    public class LeapYearCalculatorTests
    {


        LeapYearCalculator calculator;



        [SetUp]

        public void Setup()
        {

            calculator =
            new LeapYearCalculator();

        }








        [TestCase(2000, 1)]

        [TestCase(2024, 1)]

        [TestCase(2023, 0)]

        [TestCase(1700, -1)]

        [TestCase(10000, -1)]



        public void IsLeapYear_InputYear_ReturnExpectedResult
        (
            int year,
            int expected
        )

        {


            int actual =
            calculator.IsLeapYear(year);




            Assert.That
            (
                actual,
                Is.EqualTo(expected)
            );


        }





    }


}