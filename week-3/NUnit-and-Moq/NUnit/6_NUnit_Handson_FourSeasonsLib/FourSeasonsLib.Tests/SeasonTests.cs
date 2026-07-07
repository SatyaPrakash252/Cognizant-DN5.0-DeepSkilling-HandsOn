using NUnit.Framework;
using FourSeasonsLib;
using System.Collections.Generic;


namespace FourSeasonsLib.Tests
{


    [TestFixture]

    public class SeasonTests
    {


        Season season;




        [SetUp]

        public void Setup()
        {

            season =
            new Season();

        }







        public static IEnumerable<TestCaseData>
        SeasonData()
        {


            yield return new TestCaseData(
                "February",
                "Spring"
            );



            yield return new TestCaseData(
                "April",
                "Summer"
            );



            yield return new TestCaseData(
                "July",
                "Monsoon"
            );



            yield return new TestCaseData(
                "October",
                "Autumn"
            );



            yield return new TestCaseData(
                "December",
                "Winter"
            );


        }








        [TestCaseSource(
            nameof(SeasonData)
        )]


        public void GetSeason_InputMonth_ReturnSeason
        (
            string month,
            string expected
        )
        {


            string actual =
            season.GetSeason(month);



            Assert.That
            (
                actual,
                Is.EqualTo(expected)
            );


        }



    }


}