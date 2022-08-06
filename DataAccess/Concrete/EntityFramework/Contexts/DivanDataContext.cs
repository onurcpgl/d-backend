using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework.Contexts
{
    public class DivanDataContext: DbContext
    {
        public DivanDataContext(DbContextOptions<DivanDataContext> options): base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<User>().HasKey(x => x.Id);
            modelBuilder.Entity<UserGroup>().HasKey(x => x.Id);
            modelBuilder.Entity<Announcement>().HasKey(x => x.Id);
            modelBuilder.Entity<Domain>().HasKey(x => x.Id);

            modelBuilder.Entity<UserGroup>().HasMany(x => x.Domains).WithMany(y => y.UserGroups).UsingEntity(x => x.ToTable("UserGroupDomains"));

            modelBuilder.Entity<UserGroup>()
                .HasMany(ug => ug.User)
                .WithOne(u => u.UserGroup)
                .HasForeignKey(u => u.UserGroupId);

            modelBuilder.Entity<Announcement>()
                 .HasOne(a => a.User)
                 .WithMany(u => u.Announcements)
                 .HasForeignKey(u => u.UserId);



        }

        public DbSet<UserGroup> UserGroups { get; set; }
        public DbSet<Domain> Domains { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<User> Users { get; set; }
    }

    

}
