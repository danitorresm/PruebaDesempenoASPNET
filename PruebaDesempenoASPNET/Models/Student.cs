using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaDesempenoASPNET.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? Names { get; set; }
        public DateOnly? BirthDate { get; set; }
        public string? Address { get; set; }      
        public string? Email { get; set; }
        public List<Enrollement>? Enrollements { get; set; }/*Relacion con tabla Enrollement*/
    }
}