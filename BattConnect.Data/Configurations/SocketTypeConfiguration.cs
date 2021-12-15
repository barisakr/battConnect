using BattConnect.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BatConnect.Data.Configurations
{
    public class SocketTypeConfiguration : IEntityTypeConfiguration<SocketType>
    {
        public void Configure(EntityTypeBuilder<SocketType> builder)
        {
            builder
                .HasKey(m => m.Id);

            builder
                .Property(m => m.Id)
                .UseIdentityColumn();

            builder
                .Property(m => m.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .HasOne(m => m.ChargingCompany)
                .WithMany(a => a.SocketTypes)
                .HasForeignKey(m => m.ChargingCompanyId);

            builder
                .ToTable("SocketTypes");
        }
    }
}
