using BatConnect.Data.Configurations;
using BattConnect.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BatConnect.Data
{
    public class BattConnectDbContext : DbContext
    {
        public DbSet<ChargingCompany> ChargingCompanies { get; set; }
        public DbSet<SocketType> SocketTypes { get; set; }

        public BattConnectDbContext(DbContextOptions<BattConnectDbContext> options)
               : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .ApplyConfiguration(new ChargingCompanyConfiguration());

            builder
                .ApplyConfiguration(new SocketTypeConfiguration());
        }
    }
}
