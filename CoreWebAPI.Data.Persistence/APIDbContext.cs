using CoreWebAPI.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreWebAPI.Data.Persistence
{
    public class APIDbContext : DbContext
    {
        public APIDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=LAPTOP-H2AR6E1L; Database=webapi;User Id=api-dba; Password=apidbauser;");
        }

        public DbSet<Book> Bookshelf { get; set; }
    }
}
