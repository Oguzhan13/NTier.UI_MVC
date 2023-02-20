namespace NTier.Access.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Tweet> Tweets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Other Seed Data methods 
            //modelBuilder.Entity<Person>().HasData(
            //    new Person { Id = 1, FirstName = "Ali", LastName = "Yılmaz", IsActive = true },
            //    new Person { Id = 2, FirstName = "Veli", LastName = "Yılmaz", IsActive = false },
            //    new Person { Id = 3, FirstName = "Ayşe", LastName = "Yılmaz", IsActive = true },
            //    new Person { Id = 4, FirstName = "Fatma", LastName = "Yılmaz", IsActive = false });

            //modelBuilder.Entity<Tweet>().HasData(
            //    new Tweet { Id = 1, Content = "Hatay deprem felaketi", Topic = "Deprem", IsActive = true, PersonId = 1 },
            //    new Tweet { Id = 2, Content = "Kahramanmaraş deprem felaketi", Topic = "Deprem", IsActive = true, PersonId = 1 },
            //    new Tweet { Id = 3, Content = "Hatay deprem felaketi", Topic = "Deprem", IsActive = true, PersonId = 2 },
            //    new Tweet { Id = 4, Content = "Hatay deprem felaketi", Topic = "Deprem", IsActive = true, PersonId = 3 }
            //    );
            #endregion

            modelBuilder.ApplyConfiguration(new PersonConfiguration());
            modelBuilder.ApplyConfiguration(new TweetConfiguration());

            base.OnModelCreating(modelBuilder);            
        }       
    }
}