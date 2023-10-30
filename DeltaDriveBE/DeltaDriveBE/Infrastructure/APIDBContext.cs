﻿using DeltaDriveBE.DatabaseConfiguration;
using DeltaDriveBE.Models;
using Microsoft.EntityFrameworkCore;

namespace DeltaDriveBE.Infrastructure
{
    public class APIDBContext : DbContext
    {
        public DbSet<Passanger> Passangers { get; set; }

        public APIDBContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new PassangerConfig());
        }
    }
}
