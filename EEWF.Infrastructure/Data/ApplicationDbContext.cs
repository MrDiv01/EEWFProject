using EEWF.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EEWF.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Carusel> Carusels { get; set; }
        public DbSet<About> About { get; set; }
        public DbSet<Catagory> Catagories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<CourseGategory> CoursCategories { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<EducationAbout> EducationsAbout { get; set; }
        public DbSet<Graduate> Graduates { get; set; }
        public DbSet<Support> Support { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}
