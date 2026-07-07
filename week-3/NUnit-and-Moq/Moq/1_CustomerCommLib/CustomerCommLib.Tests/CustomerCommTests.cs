using NUnit.Framework;
using Moq;
using CustomerCommLib;


namespace CustomerCommLib.Tests
{


    [TestFixture]

    public class CustomerCommTests
    {


        Mock<IMailSender> mock;



        [OneTimeSetUp]

        public void Init()
        {


            mock =
            new Mock<IMailSender>();


        }





        [TestCase]

        public void SendMailToCustomer_ReturnTrue()
        {



            mock.Setup(
                x =>
                x.SendMail(
                    It.IsAny<string>(),
                    It.IsAny<string>()
                )
            )
            .Returns(true);




            CustomerComm customer =
            new CustomerComm(
                mock.Object
            );





            bool result =
            customer.SendMailToCustomer();





            Assert.That(
                result,
                Is.True
            );


        }


    }


}