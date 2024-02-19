using System.Collections.Generic;

namespace blazortweets.Data
{
    public class Store
    {
        public IList<Tweet> Tweets { get; set; } = new List<Tweet>
        {
            new Tweet
            {
                Contents = "One from the backend"
            }
        };

        public void Add(Tweet tweet)
        {
            Tweets.Add(tweet);
        }
    }

    public class Tweet
    {
        public string Contents { get; set; }
    }
}