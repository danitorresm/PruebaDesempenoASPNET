using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PruebaDesempenoASPNET.Models;

namespace PruebaDesempenoASPNET.Data
{
    public class Context:DbContext
    {
        public Context(DbContextOptions<Context>options):base(options){

        }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Enrollement> Enrollements { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
    }
}