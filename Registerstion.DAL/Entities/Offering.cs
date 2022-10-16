using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registerstion.DAL.Entities
{
    public class Offering
    {
        public int Id { get; set; }
        public Instructor Instructor { get; set; }
        public int InstructorId { get; set; }
        public CourseRegulation courseRegulation { get; set; }
        public int CourseRegId { get; set; }
        public TimeLine TimeLine { get; set; }

        public int TimeLineId { get; set; }
    }
}
