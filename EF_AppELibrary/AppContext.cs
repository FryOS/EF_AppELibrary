using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_AppELibrary
{
    class AppContext : DbContext
    {
        // Объекты таблицы Users
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Writer> Writers { get; set; }
        public DbSet<SortBook> SortBooks { get; set; }


        public AppContext()
        {
            Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.
                UseSqlServer(
                @"Data Source=.\SQLEXPRESS;Database=ELibrary;Trusted_Connection=True;");
        }
    }
}
