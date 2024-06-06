using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaDesempenoASPNET.Models;
using PruebaDesempenoASPNET.Services.Students;
using Microsoft.EntityFrameworkCore;

namespace PruebaDesempenoASPNET.Controllers.Students
{
    [ApiController]

    public class StudentController : ControllerBase
    {
        private readonly IStundentRepository _stundentRepository;
        public StudentController(IStundentRepository stundentRepository)
        {
            _stundentRepository = stundentRepository;
        }
        /*Utilizamos el metodo Get para Traer todos los regitros en la tabla Students*/
        [HttpGet]
        [Route("api/Students")]
        public IEnumerable<Student> GetStudents(){
            return _stundentRepository.GetAll();
        }
        /*******************************************************/

        /*Utilizamos el metodo GET para Traer regitros en la tabla Students por ID*/
        [HttpGet]
        [Route("api/Students/{id}")]
        public Student Details(int id){
            return _stundentRepository.GetById(id);
        }
        /*************************************************************************/


    }
}