using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OtoMoto.Models;

namespace OtoMoto.Database
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                        .Entity<NadwoziePojazdu>()
                        .Property(f => f.Id)
                        .ValueGeneratedOnAdd();      
            
            modelBuilder
                        .Entity<TypPaliwa>()
                        .Property(f => f.Id)
                        .ValueGeneratedOnAdd();

            modelBuilder.Entity<Role>().HasData
            (
                new Role
                {
                    Id = 1,
                    Name = Consts.AdminRoleName
                },
                new Role
                {
                    Id = 2,
                    Name = Consts.UserRoleName
                }
            );        
            
            modelBuilder.Entity<TypPaliwa>().HasData
            (
                new TypPaliwa
                {
                    Id = 1,
                    Nazwa = "Benzyna"
                },
                new TypPaliwa
                {
                    Id = 2,
                    Nazwa = "Olej napędowy"
                }
            );
            

            modelBuilder.Entity<NadwoziePojazdu>().HasData
            (
                new NadwoziePojazdu
                {
                    Id = 1,
                    Nazwa = "Sedan"
                },
                new NadwoziePojazdu
                {
                    Id = 2,
                    Nazwa = "Kombi"
                },
                new NadwoziePojazdu
                {
                    Id = 3,
                    Nazwa = "SUV"
                }
            );

            var hasher = new PasswordHasher<User>();

            var user = new User 
            {
                UserName = "Admin Admin",
                Email = "admin@localhost",
                RoleId = 1
            };

            var hash = hasher.HashPassword(user, "password1");
            user.PasswordHash = hash;

            modelBuilder.Entity<User>().HasData
            (
                user
            );

            base.OnModelCreating(modelBuilder);
        }


        public DbSet<User> Users { get; set; }

        public DbSet<Offer> Offers { get; set; }

        public DbSet<Image> Images { get; set; }

        public DbSet<TypPaliwa> TypyPaliwa { get; set; }

        public DbSet<NadwoziePojazdu> TypyNadwozia { get; set; }

        public DbSet<Role> Roles { get; set; }
    }
}
