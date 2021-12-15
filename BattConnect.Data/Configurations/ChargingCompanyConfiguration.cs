using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using BattConnect.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BatConnect.Data.Configurations
{
    public class ChargingCompanyConfiguration : IEntityTypeConfiguration<ChargingCompany>
    {
        public void Configure(EntityTypeBuilder<ChargingCompany> builder)
        {
            builder
            .HasKey(a => a.Id);

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
                .Property(m => m.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .ToTable("ChargingCompanies");
        }
    }
}
