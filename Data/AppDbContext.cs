using Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace Data
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        private string Path { get; set; }
        public DbSet<ContactEntity> Contacts { get; set; }
        public DbSet<OrganizationEntity> Organizations { get; set; }
        public DbSet<AlbumEntity> Albums { get; set; }
        public AppDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            Path = System.IO.Path.Join(path, "contacts.db");

         }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data source={Path}");
            //optionsBuilder.EnableSensitiveDataLogging();

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            var admin = new IdentityUser()
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "adam",
                NormalizedUserName = "ADAM",
                Email = "adam@wsei.edu.pl",
                NormalizedEmail = "ADAM@WSEI.EDU.PL",
                EmailConfirmed = true,
                
            };

            var user = new IdentityUser()
            {
                Id = Guid.NewGuid().ToString(),
                UserName = "Jakub",
                NormalizedUserName = "JAKUB",
                Email = "jakub@wsei.edu.pl",
                NormalizedEmail = "JAKUB@WSEI.EDU.PL",
                EmailConfirmed = true,
            };
            PasswordHasher<IdentityUser> passwordHasher = new PasswordHasher<IdentityUser>();

            admin.PasswordHash = passwordHasher.HashPassword(admin, "1234Abcd!");
            user.PasswordHash = passwordHasher.HashPassword(user, "1234Abcd!");

            modelBuilder.Entity<IdentityUser>().HasData(admin);
            modelBuilder.Entity<IdentityUser>().HasData(user);

            // tworzenie roli admina
            var adminRole = new IdentityRole()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "admin",
                NormalizedName = "ADMIN"
            };

            adminRole.ConcurrencyStamp = adminRole.Id;
            modelBuilder.Entity<IdentityRole>()
                .HasData(adminRole);

            modelBuilder.Entity<IdentityUserRole<string>>()
                .HasData(
                new IdentityUserRole<string>()
                {
                    RoleId = adminRole.Id,
                    UserId = admin.Id
                }
            );
            

            modelBuilder.Entity<ContactEntity>()
                .HasOne(c => c.Organization)
                .WithMany(o => o.Contacts)
                .HasForeignKey(c => c.OrganizationId);

            modelBuilder.Entity<OrganizationEntity>()
                .HasData(
                new OrganizationEntity()
                {
                    Id = 101,
                    Name = "WSEI",
                    Description = "Uczelnia wyższa",
              
                },
                new OrganizationEntity()
                {
                    Id = 102,
                    Name = "Comarch",
                    Description = "Przedsiębiorstwo IT",
                }
                );
            modelBuilder.Entity<ContactEntity>()
                .HasData(
                new ContactEntity() 
                {
                    ContactId = 1,
                    Name = "Adam",
                    Email = "adam@wsei.edu.pl",
                    Phone = "354353637",
                    Birth = DateTime.Parse("2000-10-10"),
                    OrganizationId = 101
                },
                new ContactEntity()
                {
                    ContactId = 2,
                    Name = "Jakub",
                    Email = "jakubstr@gmail.com",
                    Phone = "123234345",
                    Birth = DateTime.Parse("2002-03-12"),
                    OrganizationId = 102
                }
                );
            
            modelBuilder.Entity<OrganizationEntity>()
                .OwnsOne(o => o.Address)
                .HasData(
                new
                {
                    OrganizationEntityId = 101,
                    City = "Kraków",
                    Street = "św. Filipa 17",
                    PostalCode = "31-150"
                },
                new
                {
                    OrganizationEntityId = 102,
                    City = "Kraków",
                    Street = "Rozwoju 1/4",
                    PostalCode = "36-160"
                }
                );

            modelBuilder.Entity<AlbumEntity>()
                .HasData(
                new AlbumEntity()
                {
                    AlbumId = 1,
                    Name = "...And Justice for All",
                    Band = "Metallica",
                    TrackList = "1.Blackened 2. ...And Justice for All 3. Eye of the Beholder",
                    ReleaseDate = DateTime.Parse("1988-08-25"),
                    Duration = DateTime.Parse("01:05")
                },
                new AlbumEntity()
                {
                    AlbumId = 2,
                    Name = "The Cure Greatest Hits",
                    Band = "The Cure",
                    TrackList = "1. Boys Don't Cry 2. A Forest 3. The Walk",
                    ReleaseDate = DateTime.Parse("2001-01-01"),
                    Duration = DateTime.Parse("01:07")
                },
                new AlbumEntity()
                {
                    AlbumId = 3,
                    Name = "Speak And Spell",
                    Band = "Depeche Mode",
                    TrackList = "1. New Life 2. I Sometimes Wish I Was Dead 3. Puppets",
                    ReleaseDate = DateTime.Parse("1981-11-02"),
                    Duration = DateTime.Parse("01:01") 
                }
                );
        }

    }
}
