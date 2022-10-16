using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Registerstion.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registerstion.DAL.Data.Config
{
    public class StudentConfigration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Email).IsRequired().HasMaxLength(50);
            builder.Property(p => p.Password).IsRequired().HasMaxLength(20);
            builder.Property(p => p.PictureUrl).IsRequired();
            builder.Property(p => p.Level).IsRequired();
            builder.Property(p => p.GPA).IsRequired();
            builder.Property(p => p.StudentHours).IsRequired();
            builder.Property(p => p.PaymentStatus).IsRequired();
            builder.Property(p => p.GPA).IsRequired();
            builder.HasOne(p => p.Regulation).WithMany().HasForeignKey(p => p.RegulationId);







        }
    }
}
