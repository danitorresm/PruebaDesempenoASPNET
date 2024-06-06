using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaDesempenoASPNET.Models;
using PruebaDesempenoASPNET.Services;
using PruebaDesempenoASPNET.Services.Teachers;
using PruebaDesempenoASPNET.Data;


namespace PruebaDesempenoASPNET.Controllers.Teachers
{
    [ApiController]
    public class CreateTeacherController : ControllerBase
    {
        private readonly ITeacherRepository _teacherRepository;
        public CreateTeacherController(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }
        /************************************************
        Utilizamos el metodo POST para crear regitros en la tabla Teachers*/
            [HttpPost("api/teachers/Create")]//Esta es la ruta que utilizamos
            public IActionResult Post([FromBody] Teacher teacher)
            {
                _teacherRepository.add(teacher);
                return Ok (new{message = "Teacher cread@ con exitos"});
            }
        /*-------------------------------------------------------*/
    }
}