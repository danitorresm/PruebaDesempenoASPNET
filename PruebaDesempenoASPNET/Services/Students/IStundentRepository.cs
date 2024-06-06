using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaDesempenoASPNET.Models;
using PruebaDesempenoASPNET.Services;
using PruebaDesempenoASPNET.Data;


namespace PruebaDesempenoASPNET.Services.Students
{
    public interface IStundentRepository
    {
        IEnumerable<Student> GetAll();
        Student GetById(int id);
        void add(Student student);
        void update(Student student);
        void Remove( int id );
    }
}