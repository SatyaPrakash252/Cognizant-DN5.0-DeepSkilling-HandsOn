namespace FourSeasonsLib
{

    public class Season
    {


        public string GetSeason(string month)
        {


            switch (month)
            {


                case "February":
                case "March":

                    return "Spring";



                case "April":
                case "May":
                case "June":

                    return "Summer";



                case "July":
                case "August":
                case "September":

                    return "Monsoon";



                case "October":
                case "November":

                    return "Autumn";



                case "December":
                case "January":

                    return "Winter";



                default:

                    return "Invalid";


            }


        }


    }


}