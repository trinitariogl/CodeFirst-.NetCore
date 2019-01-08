
namespace DataServiceLayer.Context
{
    using DataServiceInterfaces.Models;
    using DataServiceLayer.Configuration;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;

    public class SecurityContext : DbContext
    {
        public SecurityContext()
        {
        }

        public SecurityContext(DbContextOptions<SecurityContext> options) : base(options)
        {
            
        }

        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<UserAccounts> UserAccounts { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                            .AddJsonFile("appsettings.json")
                            .Build();

            var connectionString = config["Data:main"];

            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            
            builder.ApplyConfiguration(new RoleEntityConfig());
            builder.ApplyConfiguration(new UserAccountEntityConfig());
            builder.ApplyConfiguration(new RelationRoleUserConfig());

            Migrations.Configuration.Initialize(builder);
        }
    }
}
