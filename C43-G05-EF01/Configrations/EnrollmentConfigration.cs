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
    internal class EnrollmentConfigration : IEntityTypeConfiguration<Enrollment>
    {
        public void Configure(EntityTypeBuilder<Enrollment> entity)
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.StudentId).IsRequired();
            entity.Property(e => e.CourseId).IsRequired();
            entity.Property(e => e.Date).IsRequired();
        }
    }
}
