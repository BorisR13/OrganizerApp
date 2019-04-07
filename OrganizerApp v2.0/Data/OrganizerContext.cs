using Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class OrganizerContext : DbContext
    {
        public OrganizerContext() { }

        public OrganizerContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Week> Weeks { get; set; }
        public DbSet<Month> Months { get; set; }
        public DbSet<Day> Days { get; set; }
        public DbSet<ToDoActivity> Activities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Configuration.conncetion_string);
            }
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
