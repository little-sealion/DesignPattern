using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Facade.Tweet
{
    public class TwitterClient
    {
        public List<Tweet> GetRecentTweets(String accessToken)
        {
            System.Console.WriteLine("Getting recent tweets");

            return new List<Tweet>();
        }
    }
}