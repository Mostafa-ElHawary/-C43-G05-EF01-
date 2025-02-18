using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using C43_G05_EF01.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace C43_G05_EF01.Configrations
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {

        public void Configure(EntityTypeBuilder<Employee> entity)
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Name)
                  .IsRequired()
                  .HasMaxLength(50);
            entity.Property(e => e.Age)
                  .IsRequired()
                  .HasDefaultValue(18);
            entity.Property(e => e.Salary)
                  .HasColumnType("decimal(18,2)");
            entity.Property(e => e.Address)
                  .HasMaxLength(100);
        }

    }
}
