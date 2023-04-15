using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Models;

namespace ContosoUniversity.Data
{
    public class ContosoUniversityContext : DbContext
    {
        public ContosoUniversityContext (DbContextOptions<ContosoUniversityContext> options)
            : base(options)
        {
        }

        public DbSet<Student>? Student { get; set; } = default!;

        public DbSet<Enrollment>? Enrollment { get; set; }

        public DbSet<Course>? Course { get; set; }

        public DbSet<Instructor>? Instructor { get; set; }
    }
}
