using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaDesempenoASPNET.Models;


namespace PruebaDesempenoASPNET.Services.Courses
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetAll();
        
        Course GetById(int id);
        void add(Course course);
        void update(Course course);
        void Remove( int id );
    }
}