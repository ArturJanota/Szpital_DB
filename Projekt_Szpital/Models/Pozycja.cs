using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_Szpital.Models
{
    public class Pozycja
    {
        public int ID { get; set; }
        [Required]
        public int Pokoj { get; set; }
        [Required]
        public bool Dostepny { get; set; }
        [Required]
        public string Specjalizacja { get; set; }
    }
}
