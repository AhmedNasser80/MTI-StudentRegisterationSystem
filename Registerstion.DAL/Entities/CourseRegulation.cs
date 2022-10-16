using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registerstion.DAL.Entities
{
    public class CourseRegulation
    {
        public int Id { get; set; }
        public Course Course  { get; set; }
        public int CourseId { get; set; }
        public Regulation Regulation { get; set; }
        public int RegulationId { get; set; }

    }
}
