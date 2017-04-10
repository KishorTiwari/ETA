using Microsoft.EntityFrameworkCore;
using ETA.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;

namespace ETA.Data.DAL
{
    public class ETAContext: DbContext
    {

        public ETAContext(DbContextOptions<ETAContext> options): base(options)
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<Group_User> Group_User { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}
