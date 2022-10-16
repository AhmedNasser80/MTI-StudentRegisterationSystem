using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registerstion.DAL.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string PictureUrl { get; set; }
        public int Level { get; set; }
        public double GPA { get; set; }
        public int StudentHours { get; set; }
        public bool PaymentStatus { get; set; }
        public Regulation Regulation { get; set; }
        public int RegulationId { get; set; } 
    }
}
