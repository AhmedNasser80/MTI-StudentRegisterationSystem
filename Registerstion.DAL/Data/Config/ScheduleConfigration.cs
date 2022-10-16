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
    internal class ScheduleConfigration : IEntityTypeConfiguration<Schedule>
    {
        public void Configure(EntityTypeBuilder<Schedule> builder)
        {
            builder.Property(p => p.Day).IsRequired().HasMaxLength(50);
            builder.Property(p => p.Duration).IsRequired().HasMaxLength(50);
            //builder.HasKey(p => new { p.Id, p.Day, p.Duration });


        }
    }
}
