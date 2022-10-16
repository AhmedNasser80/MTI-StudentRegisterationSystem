using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registerstion.DAL.Entities
{
    public class TimeLine
    {
        public int Id { get; set; }
        public Lecture Lecture { get; set; }
        public int LectureId { get; set; }

        public Schedule Schedule { get; set; }
        public int ScheduleId { get; set; }
    }
}
