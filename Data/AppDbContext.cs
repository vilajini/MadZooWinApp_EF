using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MadZooWinApp_EF.Models;
using Microsoft.EntityFrameworkCore;


namespace MadZooWinApp_EF.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Set SQLite database file path
            optionsBuilder.UseSqlite("Data Source=madzoo1.db");
        }
    }
}