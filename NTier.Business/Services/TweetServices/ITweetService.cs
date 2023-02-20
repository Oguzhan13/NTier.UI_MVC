namespace NTier.Business.Services.TweetServices
{
    public interface ITweetService
    {
        void Create(Tweet tweet);
        void Delete(int id);
        void Update(Tweet tweet);
        Tweet GetById(int id);
        List<Tweet> GetAllByPersonId(int id);
        List<Tweet> GetAll();
    }
}
