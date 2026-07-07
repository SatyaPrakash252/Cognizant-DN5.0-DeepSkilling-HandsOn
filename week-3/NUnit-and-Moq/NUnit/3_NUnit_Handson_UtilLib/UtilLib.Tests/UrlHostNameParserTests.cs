using NUnit.Framework;
using UtilLib;



namespace UtilLib.Tests
{


    [TestFixture]

    public class UrlHostNameParserTests
    {


        UrlHostNameParser parser;



        [SetUp]

        public void Init()
        {

            parser = new UrlHostNameParser();

        }





        [Test]

        public void ParseHostName_UrlWithWWW_ReturnHostName()
        {

            string result =
            parser.ParseHostName(
                "https://www.google.com/search"
            );



            Assert.That
            (
                result,
                Is.EqualTo("www.google.com")
            );


        }






        [Test]

        public void ParseHostName_UrlWithoutWWW_ReturnHostName()
        {


            string result =
            parser.ParseHostName(
                "https://github.com"
            );



            Assert.That
            (
                result,
                Is.EqualTo("github.com")
            );


        }



    }

}