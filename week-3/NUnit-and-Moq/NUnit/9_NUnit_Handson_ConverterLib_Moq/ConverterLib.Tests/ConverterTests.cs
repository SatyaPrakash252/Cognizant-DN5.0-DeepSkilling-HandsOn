using NUnit.Framework;
using Moq;
using ConverterLib;


namespace ConverterLib.Tests
{


    [TestFixture]

    public class ConverterTests
    {


        [Test]

        public void USDToEuro_InputDollar_ReturnEuro()
        {


            var mock =
            new Mock
            <IDollarToEuroExchangeRateFeed>();



            mock.Setup(
            x => x.GetActualUSDValue()
            )
            .Returns(0.85);





            Converter converter =
            new Converter(
            mock.Object
            );




            double result =
            converter.USDToEuro(100);





            Assert.That
            (
                result,
                Is.EqualTo(85)
            );


        }


    }


}