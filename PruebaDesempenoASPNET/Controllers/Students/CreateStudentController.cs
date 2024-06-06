using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaDesempenoASPNET.Models;
using PruebaDesempenoASPNET.Services.Students;
using PruebaDesempenoASPNET.Data;

namespace PruebaDesempenoASPNET.Controllers.Students
{
    [ApiController]    
    public class CreateStudentController : ControllerBase
    {
        private readonly IStundentRepository _stundentRepository;
        public CreateStudentController(IStundentRepository stundentRepository)
        {
            _stundentRepository = stundentRepository;
        }
        /*-------------------------------------------------------------------------------
        Utilizamos el metodo POST para crear regitros en la tabla Teachers*/
            [HttpPost("api/students/Create")]//Esta es la ruta que utilizamos
            public IActionResult Post([FromBody] Student student)
            {
                _stundentRepository.add(student);
                return Ok (new{message = "Student cread@ con exitos"});
            }
        /***************************************************************/
    }
}