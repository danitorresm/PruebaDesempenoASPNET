using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaDesempenoASPNET.Models;
using PruebaDesempenoASPNET.Data;
using PruebaDesempenoASPNET.Services;
using Microsoft.EntityFrameworkCore;

namespace PruebaDesempenoASPNET.Services.Courses
{
    public class CourseRepository : ICourseRepository
    {
        private readonly Context _context;
        public CourseRepository(Context context)
        {
            _context = context;
        }
        /*-----------------------------------------------------*/
        
        public void add(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }
        /*-----------------------------------------------------*/

        public IEnumerable<Course> GetAll()
        {
            return _context.Courses.Include(a => a.Teacher).ToList();
        }
        /*-----------------------------------------------------*/

        public Course GetById(int id)
        {
            return _context.Courses.Find(id);
        }
        /*-----------------------------------------------------*/

        public void Remove(int id)
        {
            var course= _context.Courses.Find(id);
            _context.Courses.Remove(course);
            _context.SaveChanges();
        }
        /*-----------------------------------------------------*/

        public void update(Course course)
        {
            _context.Courses.Update(course);
            _context.SaveChanges();
        }
        /*-----------------------------------------------------*/
    }
}