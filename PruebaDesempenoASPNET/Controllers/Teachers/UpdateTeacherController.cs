using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PruebaDesempenoASPNET.Models;
using PruebaDesempenoASPNET.Services;
using PruebaDesempenoASPNET.Services.Teachers;
using Microsoft.EntityFrameworkCore;

namespace PruebaDesempenoASPNET.Controllers.Teachers
{
    public class UpdateTeacherController:ControllerBase
    {
        private readonly ITeacherRepository _teacherRepository;
        public UpdateTeacherController(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }
        /*Utilizamos el metodo PUT para realizar actualizacion en la tabla Teachers*/
            [HttpPut]
            [Route("api/Update/id")]
            public ActionResult Update(int id,[FromBody] Teacher teacher)
            {
                var teacherExixtente = _teacherRepository.GetById(id);

                teacherExixtente.Id=teacher.Id;           
                teacherExixtente.Names = teacher.Names;
                teacherExixtente.Speciality = teacher.Speciality;
                teacherExixtente.Phone = teacher.Phone;
                teacherExixtente.Email = teacher.Email;
                teacherExixtente.YearsExperience = teacher.YearsExperience;

            


                _teacherRepository.update(teacherExixtente);
                return Ok(new{message = "Teacher actualizado con exitos"});
            }
        /******************************************************************/
    }
}