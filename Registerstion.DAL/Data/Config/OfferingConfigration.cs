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
    public class OfferingConfigration : IEntityTypeConfiguration<Offering>
    {
        public void Configure(EntityTypeBuilder<Offering> builder)
        {
            builder.HasOne(p => p.Instructor).WithMany().HasForeignKey(p => p.InstructorId);
            builder.HasOne(p => p.TimeLine).WithMany().HasForeignKey(p => p.TimeLineId);
            builder.HasOne(p => p.courseRegulation).WithMany().HasForeignKey(p => p.CourseRegId);
            //builder.HasKey(p => new { p.Id, p.InstructorId, p.TimeLineId,p.CourseRegId });




        }
    }
}
