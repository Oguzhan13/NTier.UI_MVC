namespace NTier.Core.Concretes
{
    public class Tweet : BaseClass
    {
        public string Content { get; set; }
        public string Topic { get; set; }
        // Foreign Key property
        public int PersonId { get; set; }
        // Navigation Property
        public Person Person { get; set; }
    }
}
