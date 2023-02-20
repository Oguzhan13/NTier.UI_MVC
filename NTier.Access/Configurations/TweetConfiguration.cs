namespace NTier.Access.Configurations
{
    public class TweetConfiguration : BaseConfiguration<Tweet>
    {
        public override void Configure(EntityTypeBuilder<Tweet> builder)
        {
            builder.HasOne(x => x.Person).WithMany(x => x.Tweets).HasForeignKey(x => x.PersonId);

            builder.HasData(
                new Tweet { Id = 1, Content = "Hatay deprem felaketi", Topic = "Deprem", IsActive = true, PersonId = 1 },
                new Tweet { Id = 2, Content = "Kahramanmaraş deprem felaketi", Topic = "Deprem", IsActive = true, PersonId = 1 },
                new Tweet { Id = 3, Content = "Hatay deprem felaketi", Topic = "Deprem", IsActive = true, PersonId = 2 },
                new Tweet { Id = 4, Content = "Hatay deprem felaketi", Topic = "Deprem", IsActive = true, PersonId = 3 }
                );
            base.Configure(builder);
        }
    }
}
