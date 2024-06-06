using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PruebaDesempenoASPNET.Data;
using PruebaDesempenoASPNET.Models;
using PruebaDesempenoASPNET.Services;
using PruebaDesempenoASPNET.Services.Teachers;  
using PruebaDesempenoASPNET.Services.Students;

namespace PruebaDesempenoASPNET.Services.Teachers
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly Context _context;
        public TeacherRepository(Context context)
        {
            _context = context;
        }
        /*-----------------------------------------------------*/        
        public void add(Teacher teacher)
        {
            _context.Teachers.Add(teacher);
            _context.SaveChanges();
        }
        /*-----------------------------------------------------*/
        public IEnumerable<Teacher> GetAll()
        {
            return _context.Teachers.ToList();
        }
        /*-----------------------------------------------------*/
        public Teacher GetById(int id)
        {
            return _context.Teachers.Find(id);
        }
        /*-----------------------------------------------------*/
        public void Remove(int id)
        {
            var teacher= _context.Teachers.Find(id);
            _context.Teachers.Remove(teacher);
            _context.SaveChanges();
        }
        /*-----------------------------------------------------*/
        public void update(Teacher teacher)
        {
            _context.Teachers.Update(teacher);
            _context.SaveChanges();
        }
        /*-----------------------------------------------------*/
    }
}

 


 
        
        
        

       