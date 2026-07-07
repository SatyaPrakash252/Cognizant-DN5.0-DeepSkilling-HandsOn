using NUnit.Framework;
using UserManagerLib;
using System;



namespace UserManagerLib.Tests
{


    [TestFixture]

    public class UserManagerTests
    {


        UserManager manager;



        [SetUp]

        public void Setup()
        {


            manager =
            new UserManager();


        }








        [Test]

        public void CreateUser_ValidPAN_ReturnSuccess()
        {


            User user =
            new User()
            {
                PANCardNo = "ABCDE1234F"
            };



            string result =
            manager.CreateUser(user);




            Assert.That
            (
                result,
                Is.EqualTo(
                "User Created Successfully"
                )
            );


        }









        [Test]

        public void CreateUser_NullPAN_ThrowsException()
        {


            User user =
            new User()
            {
                PANCardNo = ""
            };




            Assert.Throws<NullReferenceException>
            (
                new TestDelegate
                (
                    () =>
                    {

                        manager.CreateUser(user);

                    }
                )
            );


        }









        [Test]

        public void CreateUser_InvalidLengthPAN_ThrowsException()
        {



            User user =
            new User()
            {
                PANCardNo = "ABC123"
            };




            Assert.Throws<FormatException>
            (
                new TestDelegate
                (
                    () =>
                    {

                        manager.CreateUser(user);

                    }
                )
            );


        }




    }


}