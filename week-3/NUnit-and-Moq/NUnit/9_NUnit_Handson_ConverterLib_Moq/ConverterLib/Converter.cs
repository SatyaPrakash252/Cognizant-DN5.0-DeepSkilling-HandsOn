namespace ConverterLib
{

    public class Converter
    {


        private readonly IDollarToEuroExchangeRateFeed feed;



        public Converter(
        IDollarToEuroExchangeRateFeed feed)
        {

            this.feed = feed;

        }



        public double USDToEuro(
        double dollars)
        {


            return dollars *
            feed.GetActualUSDValue();


        }


    }


}