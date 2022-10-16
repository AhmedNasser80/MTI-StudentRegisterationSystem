using Microsoft.EntityFrameworkCore;
using Registerstion.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Registerstion.DAL.Data
{
    public class StoreContext:DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> options):base(options)
        {
        }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Regulation> Regulations { get; set; }

        public DbSet<Specification> Specifications { get; set; }

        public DbSet<Course> Courses { get; set; }

        public DbSet<CourseRegulation> CourseRegulations { get; set; }

        //public DbSet<Prerequisite> prerequisites { get; set; }

        public DbSet<Student> Students { get; set; }

        public DbSet<Instructor> Instructors { get; set; }

        public DbSet<Lecture> Lectures { get; set; }

        public DbSet<Schedule> Schedules { get; set; }

        public DbSet<TimeLine> TimeLines { get; set; }
        public DbSet<Offering> Offerings { get; set; }
        //public DbSet<StudentOffering> studentOfferings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
