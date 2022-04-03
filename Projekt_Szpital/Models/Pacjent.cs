using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_Szpital.Models
{
    public class Pacjent
    {

        public int ID { get; set; }
        [Required]
        public int Pesel { get; set; }
        public int Pokoj { get; set; }
        [Required]
        public DateTime Data_przyjecia { get; set; }
        [Required]
        [StringLength(70)]
        public string Stan_przyjecia { get; set; }
    }
}
