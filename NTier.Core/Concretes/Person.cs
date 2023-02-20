namespace NTier.Core.Concretes
{
    public class Person : BaseClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        // Navigation Property
        public ICollection<Tweet> Tweets { get; set;}
    }
}
