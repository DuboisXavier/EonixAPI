using EonixEF.Configurations;
using EonixEF.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EonixEF
{
    public class PersonneContext : DbContext
    {
        private readonly string _defaultConnectionString = @"Data Source=c:\sql\Eonix.db;Cache=Shared";

        public DbSet<Personnes> Personnes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlite(_defaultConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new PersonneConfig());
        }


    }
}
