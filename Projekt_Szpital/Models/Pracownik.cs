using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_Szpital.Models
{
    public class Pracownik
    {

        
        public int ID { get; set; }
        [Required]
        [StringLength(20)]
        public string Nazwisko { get; set; }
        [Required]
        [StringLength(20)]
        public string Imie { get; set; }
        [Required]
        public decimal Pensja { get; set; }
        [Key]
        public Pozycja Pozycja { get; set; }


    }
}
