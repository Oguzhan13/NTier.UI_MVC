namespace NTier.Business.Services.TweetServices
{
    public class TweetService : ITweetService
    {
        private readonly ITweetRepository _tweetRepository;                
        public TweetService(ITweetRepository tweetRepository)
        {
            _tweetRepository = tweetRepository;            
        }
        public void Create(Tweet tweet)
        {
            if (tweet != null)
            {      
                Tweet newTweet= new Tweet()
                {
                    Content= tweet.Content,
                    Topic= tweet.Topic,
                    IsActive=tweet.IsActive,                    
                    PersonId=tweet.PersonId,                    
                };
                _tweetRepository.Create(newTweet);
            }            
        }

        public void Delete(int id)
        {
            Tweet passiveTweet = _tweetRepository.GetById(id);
            if (passiveTweet != null)
            {
                passiveTweet.DeletedDate = DateTime.Now;
                passiveTweet.IsActive = false;
                _tweetRepository.Update(passiveTweet);
            }            
        }

        public List<Tweet> GetAllByPersonId(int id)
        {            
            List<Tweet> tweets = _tweetRepository.GetAll();
            return tweets.Where(x => x.PersonId == id).ToList();
        }
        public List<Tweet> GetAll()
        {
            return _tweetRepository.GetAll();
        }

        public Tweet GetById(int id)
        {
            Tweet tweet = _tweetRepository.GetById(id);
            return tweet;
        }

        public void Update(Tweet tweet)
        {
            Tweet tweetUpdate = _tweetRepository.GetById(tweet.Id);
            if (tweetUpdate != null)
            {
                tweetUpdate.ModifiedDate = DateTime.Now;
                tweetUpdate.Content = tweet.Content;
                tweetUpdate.Topic = tweet.Topic;
                tweetUpdate.IsActive = tweet.IsActive;
                _tweetRepository.Update(tweetUpdate);
            }            
        }
    }
}
