using EonixEF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace EonixEF.Configurations
{
    public class PersonneConfig : IEntityTypeConfiguration<Personnes>
    {
        public void Configure(EntityTypeBuilder<Personnes> builder)
        {
            builder.ToTable("Eonix.Personnes");

            builder.Property(i => i.Name).IsRequired().HasMaxLength(50);
            builder.Property(i => i.FirstName).IsRequired().HasMaxLength(50);
        }
    }
}