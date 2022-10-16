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
    public class RegulationConfigration : IEntityTypeConfiguration<Regulation>
    {
        public void Configure(EntityTypeBuilder<Regulation> builder)
        {
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.HasOne(p => p.Faculty).WithMany().HasForeignKey(p => p.FacultyId);
        }
    }
}
