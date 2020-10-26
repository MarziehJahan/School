using Microsoft.EntityFrameworkCore;
using System;
using static School.DAL.School;

namespace School.DAL
{
    public partial class School:DbContext
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