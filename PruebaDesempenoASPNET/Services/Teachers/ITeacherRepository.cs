using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaDesempenoASPNET.Models;
using PruebaDesempenoASPNET.Services;
using PruebaDesempenoASPNET.Data;

namespace PruebaDesempenoASPNET.Services.Teachers
{
    public interface ITeacherRepository
    {
        IEnumerable<Teacher> GetAll();
        Teacher GetById(int id);
        void add(Teacher teacher);
        void update(Teacher teacher);
        void Remove( int id );
    }
}