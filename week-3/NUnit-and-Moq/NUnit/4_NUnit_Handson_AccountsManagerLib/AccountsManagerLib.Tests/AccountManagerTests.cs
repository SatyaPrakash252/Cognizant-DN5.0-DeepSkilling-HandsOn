using NUnit.Framework;
using AccountsManagerLib;
using System;


namespace AccountsManagerLib.Tests
{

    [TestFixture]

    public class AccountManagerTests
    {


        AccountManager manager;



        [SetUp]

        public void Setup()
        {

            manager = new AccountManager();

        }





        [TestCase(
            "user_11",
            "secret@user11",
            "Welcome user_11!!!"
        )]


        [TestCase(
            "user_22",
            "secret@user22",
            "Welcome user_22!!!"
        )]


        public void Login_ValidUser_ReturnWelcomeMessage
        (
            string userId,
            string password,
            string expected
        )
        {


            string actual =
            manager.Login(
                userId,
                password
            );



            Assert.That
            (
                actual,
                Is.EqualTo(expected)
            );


        }








        [Test]

        public void Login_InvalidUser_ReturnError()
        {


            string actual =
            manager.Login(
                "wrong",
                "wrong"
            );



            Assert.That
            (
                actual,
                Is.EqualTo(
                    "Invalid user id/password"
                )
            );


        }








        [Test]

        public void Login_EmptyValue_ThrowException()
        {


            Assert.Throws<ArgumentException>
            (
                new TestDelegate
                (
                    () =>
                    {

                        manager.Login(
                            "",
                            ""
                        );

                    }
                )
            );


        }





        [TearDown]

        public void Cleanup()
        {


        }


    }


}