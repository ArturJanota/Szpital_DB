using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_Szpital.Models
{
    public class Zabiegi
    {
        public int Id { get; set; }
        [Required]
        public DateTime Data_wykonania { get; set; }
        public Pracownik Zlecony_przez { get; set; }
        [Required]
        public Pracownik Wykonany_przez { get; set; }
        [Required]
        [StringLength(50)]
        public string Opis_badania { get; set; }
        [Required]
        public Pacjent Pacjent { get; set; }  
    }
}
