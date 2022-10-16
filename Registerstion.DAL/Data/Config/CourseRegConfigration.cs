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
    internal class CourseRegConfigration : IEntityTypeConfiguration<CourseRegulation>
    {
        public void Configure(EntityTypeBuilder<CourseRegulation> builder)
        {
            builder.HasOne(p => p.Regulation).WithMany().HasForeignKey(p => p.RegulationId);
            builder.HasOne(p => p.Course).WithMany().HasForeignKey(p => p.CourseId);
            //builder.HasKey(p => new {p.Id,p.RegulationId,p.CourseId});

        }
    }
}
