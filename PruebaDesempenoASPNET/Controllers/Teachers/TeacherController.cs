using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaDesempenoASPNET.Models;
using PruebaDesempenoASPNET.Services.Teachers;


namespace PruebaDesempenoASPNET.Controllers.Teachers
{
    [ApiController]
    
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherRepository _teacherRepository;
        public TeacherController(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }


        /*Utilizamos el metodo Get para Traer todos los regitros en la tabla Teachers*/
            [HttpGet]
            [Route("api/Teachers")]
            public IEnumerable<Teacher> GetTeachers(){
                return _teacherRepository.GetAll();
            }
        /************************************************/


        /*Utilizamos el metodo GET para Traer regitros en la tabla Teachers por ID*/
            [HttpGet]
            [Route("api/Teachers/{id}")]//Esta es la ruta que utilizariamos
            public Teacher Details(int id){
                return _teacherRepository.GetById(id);
            }
        /************************************************/
    }
}

