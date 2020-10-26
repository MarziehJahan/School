using Microsoft.EntityFrameworkCore;
using System;

namespace SchoolData.DAL
{
    public class SchoolContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;initial catalog=School;integrated security=True;");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
