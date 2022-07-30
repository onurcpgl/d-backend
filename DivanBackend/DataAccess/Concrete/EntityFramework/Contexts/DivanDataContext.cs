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

            modelBuilder.Entity<UserGroup>().HasMany(x => x.Domains).WithMany(y => y.UserGroups).UsingEntity(x => x.ToTable("UserGroupDomains"));
        }

        public DbSet<UserGroup> UserGroups { get; set; }
        public DbSet<Domain> Domains { get; set; }
        public DbSet<Announcements> Announcements { get; set; }
    }

    

}
