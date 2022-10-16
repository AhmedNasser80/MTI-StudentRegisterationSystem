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
    public class TimeLineConfigration : IEntityTypeConfiguration<TimeLine>
    {
        public void Configure(EntityTypeBuilder<TimeLine> builder)
        {
            builder.HasOne(p => p.Lecture).WithMany().HasForeignKey(p => p.LectureId);
            builder.HasOne(p => p.Schedule).WithMany().HasForeignKey(p => p.ScheduleId);

            //builder.HasKey(p => new { p.Id, p.LectureId, p.ScheduleId});

        }
    }
}
