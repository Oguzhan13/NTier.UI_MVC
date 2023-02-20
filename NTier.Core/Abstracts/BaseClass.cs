namespace NTier.Core.Abstracts
{
    public abstract class BaseClass
    {
        public BaseClass()
        {
            CreatedDate = DateTime.Now;
        }
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public DateTime DeletedDate { get; set; }
        public bool IsActive { get; set; }
    }
}