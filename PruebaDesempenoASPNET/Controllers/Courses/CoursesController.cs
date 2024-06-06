using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaDesempenoASPNET.Models;
using PruebaDesempenoASPNET.Services.Courses;


namespace PruebaDesempenoASPNET.Controllers.Courses
{
    [ApiController]
    
    public class CoursesController : ControllerBase
    {
        private readonly ICourseRepository _courseRepository;
        public CoursesController(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        /*Utilizamos el metodo Get para Traer todos los regitros en la tabla Courses*/
            [HttpGet]
            [Route("api/Courses")]
            public IEnumerable<Course> GetCourses(){
                return _courseRepository.GetAll();
            }
        /*******************************************************/
        /*Utilizamos el metodo GET para Traer regitros en la tabla Courses por ID*/
            [HttpGet]
            [Route("api/Courses/{id}")]//Esta es la ruta que utilizariamos
            public Course Details(int id){
                return _courseRepository.GetById(id);
            }
        /*******************************************************/

    }
}