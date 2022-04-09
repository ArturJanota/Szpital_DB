using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_Szpital.Models
{
    public class Pozycja
    {
        [Key]
        public int ID { get; set; }
        
        public int Pokoj { get; set; }
        
        public bool Dostepny { get; set; }
        [Required]
        public string Specjalizacja { get; set; }
    }
}
