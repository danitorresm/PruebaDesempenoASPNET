using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaDesempenoASPNET.Models;
using PruebaDesempenoASPNET.Services.Courses;
using PruebaDesempenoASPNET.Services.Teachers;

namespace PruebaDesempenoASPNET.Controllers.Courses
{
    [ApiController]
    
    public class CreateCourseController : ControllerBase
    {
        private readonly ICourseRepository _courseRepository;
        private readonly ITeacherRepository _teacherRepository;

        public CreateCourseController(ICourseRepository courseRepository, ITeacherRepository teacherRepository)
        {
            _courseRepository = courseRepository;
            _teacherRepository = teacherRepository;
        }
        /************************************************
        Utilizamos el metodo POST para crear regitros en la tabla Teachers*/
        [HttpPost("api/courses/Create")]//Esta es la ruta que utilizamos
        public async Task<IActionResult> CreateCourse([FromBody] Course course)
        {
            if (course == null)
            {
                return BadRequest("Datos de Course no validos");
            }
            try
            {
                var CreaCourse = await _courseRepository.CreateCouseAsync(course);
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
    }
}