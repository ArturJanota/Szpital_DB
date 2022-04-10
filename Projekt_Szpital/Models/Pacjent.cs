using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_Szpital.Models
{
    public class Pacjent
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int Pesel { get; set; }
        public int Pokoj { get; set; }
        
        public DateTime Data_przyjecia { get; set; }
        
        [StringLength(70)]
        public string Stan_przyjecia { get; set; }

        

        public Pacjent( int pesel, string stan_przyjecia)
        {
          
            Pesel = pesel;
            Stan_przyjecia = stan_przyjecia;
        }
    }
}
