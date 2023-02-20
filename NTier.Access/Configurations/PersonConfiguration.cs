namespace NTier.Access.Configurations
{
    public class PersonConfiguration : BaseConfiguration<Person>
    {
        public override void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasMany(x => x.Tweets).WithOne(x => x.Person).HasForeignKey(x => x.PersonId);

            builder.HasData(
                new Person { Id = 1, FirstName = "Ali", LastName = "Yılmaz", IsActive = true },
                new Person { Id = 2, FirstName = "Veli", LastName = "Yılmaz", IsActive = false },
                new Person { Id = 3, FirstName = "Ayşe", LastName = "Yılmaz", IsActive = true },
                new Person { Id = 4, FirstName = "Fatma", LastName = "Yılmaz", IsActive = false });

            base.Configure(builder);
        }
    }
}
