using System;


namespace UtilLib
{
    public class UrlHostNameParser
    {


        public string ParseHostName(string url)
        {


            Uri uri = new Uri(url);


            return uri.Host;


        }


    }
}