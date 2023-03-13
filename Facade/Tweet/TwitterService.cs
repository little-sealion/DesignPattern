using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPattern.Facade.Tweet
{
    public class TwitterService
    {
        public List<Tweet> GetRecentTweets()
        {
            var oauth = new OAuth();
            var requestToken = oauth.RequestToken("appKey", "secret");
            var accessToken = oauth.GetAccessToken(requestToken);

            var twitterClient = new TwitterClient();
            var tweets = twitterClient.GetRecentTweets(accessToken);
            return tweets;
        }
    }
}