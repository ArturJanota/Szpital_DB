using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_Szpital.Models
{
    public class Zabiegi
    {
        [Key]
        public int Id { get; set; }
        
        public DateTime Data_wykonania { get; set; }
        [ForeignKey(nameof(Pracownik))]
        public Pracownik Zlecony_przez { get; set; }
        [Required]
        
        public List<Pracownik> Wykonany_przez { get; set; }    
        
        [StringLength(50)]
        public string Opis_badania { get; set; }
        [Required]
        public Pacjent Pacjent { get; set; }  
    }
}
