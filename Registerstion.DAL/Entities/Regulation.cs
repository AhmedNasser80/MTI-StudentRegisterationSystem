using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registerstion.DAL.Entities
{
    public class Regulation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Faculty Faculty { get; set; }
        public int FacultyId { get; set; }
    }
}
