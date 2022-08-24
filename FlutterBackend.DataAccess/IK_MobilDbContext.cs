using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using FlutterBackend.Entities;

namespace FlutterBackend.DataAccess
{
    public class IK_MobilDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=SQLSERVER; Database=db; uid=name; pwd=password;");
        }

        public DbSet<IK_Mobil> IK_Mobil { get; set; }

    }
}
