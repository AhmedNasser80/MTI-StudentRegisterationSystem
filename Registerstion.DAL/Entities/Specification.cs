using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registerstion.DAL.Entities
{
    public class Specification
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Regulation Regulation { get; set; }
        public int RegId { get; set; }
    }
}
