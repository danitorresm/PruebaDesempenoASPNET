using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json.Serialization;
namespace PruebaDesempenoASPNET.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int TeacherId { get; set; }
        public Teacher? Teacher { get; set; }/*Relacion con tabla Teacher*/
        [JsonIgnore]
        public List<Enrollement>? Enrollements { get; set; }/*Relacion con tabla Enrollement*/
        public string?  Schedule { get; set; }
        public string? Duration { get; set; }
        public int? Capacity { get; set; }

    }
}