namespace PlayersManagerLib
{


    public class PlayerManager
    {


        private readonly IPlayerMapper mapper;



        public PlayerManager(
            IPlayerMapper mapper
        )
        {

            this.mapper = mapper;

        }






        public Player RegisterNewPlayer(
            Player player
        )
        {


            return mapper
            .AddNewPlayer(player);


        }


    }


}