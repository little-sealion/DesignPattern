using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Facade.Tweet
{
    public class OAuth
    {
        public String RequestToken(String appKey, String appSecret)
        {
            System.Console.WriteLine("Get a request token");
            return "requestToken";
        }

        public String GetAccessToken(String requestToken)
        {
            System.Console.WriteLine("Get an access token");
            return "accessToken";
        }
    }
}