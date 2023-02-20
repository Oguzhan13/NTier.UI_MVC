namespace NTier.Access.Repositories.Concretes
{
    public class TweetRepository : BaseRepository<Tweet>, ITweetRepository
    {
        public TweetRepository(AppDbContext _db) : base(_db)
        {

        }
    }
}
