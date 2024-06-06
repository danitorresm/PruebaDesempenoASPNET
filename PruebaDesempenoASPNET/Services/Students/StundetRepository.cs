using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaDesempenoASPNET.Models;
using PruebaDesempenoASPNET.Services;
using PruebaDesempenoASPNET.Data;
using PruebaDesempenoASPNET.Services.Students;

namespace PruebaDesempenoASPNET.Services.Students
{
    public class StundetRepository : IStundentRepository
    {
        private readonly Context _context;
        public StundetRepository(Context context)
        {
            _context = context;
        }
        /*-------------------------------------------------------------------------------*/
        
        public void add(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }
        /*-------------------------------------------------------------------------------*/

        public IEnumerable<Student> GetAll()
        {
            return _context.Students.ToList();
        }
        /*-------------------------------------------------------------------------------*/

        public Student GetById(int id)
        {
            return _context.Students.Find(id);
        }
        /*-------------------------------------------------------------------------------*/

        public void Remove(int id)
        {
            var student= _context.Students.Find(id);
            _context.Students.Remove(student);
            _context.SaveChanges();
        }
        /*-------------------------------------------------------------------------------*/

        public void update(Student student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();
        }
        /*-------------------------------------------------------------------------------*/
    }


}