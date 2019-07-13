using Microsoft.EntityFrameworkCore;
using SqlLiteMobile;
using System;

namespace SqlLiteApp.Standard
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        private readonly string _databasePath;

        public DatabaseContext(string databasePath)
        {
            _databasePath = databasePath;

            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Filename={_databasePath}");
        }
    }
}
