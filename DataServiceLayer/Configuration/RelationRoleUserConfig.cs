

namespace DataServiceLayer.Configuration
{
    using DataServiceInterfaces.Models;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    public class RelationRoleUserConfig : IEntityTypeConfiguration<UserRoles>
    {
        public void Configure(EntityTypeBuilder<UserRoles> builder)
        {
            builder.HasKey(t => new { t.UserId, t.RoleId });

            builder.HasOne(pt => pt.User)
                   .WithMany(p => p.UserRoles)
                   .HasForeignKey(pt => pt.UserId);

            builder.HasOne(pt => pt.Rol)
                   .WithMany(t => t.UserRoles)
                   .HasForeignKey(pt => pt.RoleId);
        }
    }
}
