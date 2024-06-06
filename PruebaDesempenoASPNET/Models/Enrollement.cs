using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaDesempenoASPNET.Models;

namespace PruebaDesempenoASPNET.Models
{
    public class Enrollement
    {
        
        public int Id { get; set; }
        public DateOnly Date { get; set; }

        public int StudentId { get; set; }
        public Student? Student { get; set; }/*Relacion con tabla Student*/
        public int CourseId { get; set; }
        public Course? Course { get; set; }/*Relacion con tabla Course*/
        public string Status { get; set; }    
    }
}