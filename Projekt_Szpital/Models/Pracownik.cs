using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_Szpital.Models
{
    public class Pracownik
    {

        [Key]
        public int ID { get; set; }
        [Required]
        [StringLength(20)]
        public string Nazwisko { get; set; }
        [Required]
        [StringLength(20)]
        public string Imie { get; set; }
        
        public decimal Pensja { get; set; }
        
        public Pozycja Pozycja { get; set; }

       


    }
}
