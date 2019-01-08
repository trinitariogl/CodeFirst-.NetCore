
namespace DataServiceLayer.Migrations
{
    using DataServiceInterfaces.Models;
    using Microsoft.EntityFrameworkCore;
    using System;

    public static class Configuration
    {
        public static void Initialize(ModelBuilder builder)
        {
            //context.Database.EnsureCreated();
            //context.Roles.Add(new DataServiceInterfaces.Models.Roles { Id = Guid.NewGuid().ToString(), Name = "Rol Ejemplo" });
            //context.SaveChangesAsync();
            // Add Seed Data...

            builder.Entity<Roles>().HasData(new Roles
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Nombre 1"

            }, new Roles
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Nombre 2"
            },
            new Roles
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Nombre 3"
            },
            new Roles
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Nombre 4"
            },
            new Roles
            {
                Id = Guid.NewGuid().ToString(),
                Name = "Nombre 5"
            });
        }
    }
}
