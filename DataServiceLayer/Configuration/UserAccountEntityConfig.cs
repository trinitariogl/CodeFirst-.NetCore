
namespace DataServiceLayer.Configuration
{
    using DataServiceInterfaces.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class UserAccountEntityConfig : IEntityTypeConfiguration<UserAccounts>
    {
        public void Configure(EntityTypeBuilder<UserAccounts> builder)
        {
            builder.ToTable("UserAccount");

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("Id");
            builder.Property(x => x.Username).HasColumnName("Username");
            builder.Property(x => x.Email).HasColumnName("Email");
            builder.Property(x => x.PrefferedLanguage).HasColumnName("PrefferedLanguage");
            builder.Property(x => x.PasswordHash).HasColumnName("PasswordHash");
            builder.Property(x => x.Salt).HasColumnName("Salt");
            builder.Property(x => x.Active).HasColumnName("Active");
            builder.Property(x => x.VerificationToken).HasColumnName("VerificationToken");
            builder.Property(x => x.City).HasColumnName("City");
            builder.Property(x => x.Country).HasColumnName("country").HasMaxLength(100);
        }
    }
}
