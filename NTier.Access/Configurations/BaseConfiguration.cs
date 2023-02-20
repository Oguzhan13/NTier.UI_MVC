namespace NTier.Access.Configurations
{
    public class BaseConfiguration<T> : IEntityTypeConfiguration<T> where T : BaseClass
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.IsActive).IsRequired().HasColumnType("bit");
            builder.HasKey(x => x.Id);
        }
    }
}
