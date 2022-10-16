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
    public class CourseConfigration : IEntityTypeConfiguration<Course>
    {
         
        public void Configure(EntityTypeBuilder<Course> builder)
        {
                builder.Property(p => p.Name).IsRequired().HasMaxLength(50);
                builder.Property(p => p.CreditHours).IsRequired();
         
        }
    }
}
