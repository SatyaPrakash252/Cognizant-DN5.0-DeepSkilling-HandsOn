using NUnit.Framework;
using Moq;
using PlayersManagerLib;



namespace PlayersManagerLib.Tests
{


    [TestFixture]

    public class PlayerManagerTests
    {



        [Test]

        public void RegisterNewPlayer_ReturnPlayer()
        {



            Player player =
            new Player()
            {
                Id = 1,
                Name = "Virat",
                Age = 35
            };





            Mock<IPlayerMapper> mock =
            new Mock<IPlayerMapper>();





            mock.Setup(
                x =>
                x.AddNewPlayer(
                    It.IsAny<Player>()
                )
            )
            .Returns(player);





            PlayerManager manager =
            new PlayerManager(
                mock.Object
            );






            Player result =
            manager.RegisterNewPlayer(
                player
            );






            Assert.That(
                result.Id,
                Is.EqualTo(1)
            );


            Assert.That(
                result.Name,
                Is.EqualTo("Virat")
            );


            Assert.That(
                result.Age,
                Is.EqualTo(35)
            );


        }



    }


}