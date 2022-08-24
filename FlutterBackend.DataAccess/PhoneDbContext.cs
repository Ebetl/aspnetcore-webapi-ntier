using FlutterBackend.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlutterBackend.DataAccess
{
    public class PhoneDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=SQLSERVER; Database=db; uid=name; pwd=password;");

        }

        public DbSet<Phone> phones { get; set; }

        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Phone>().ToView("View");
            base.OnModelCreating(modelBuilder);
        }
    }
}
