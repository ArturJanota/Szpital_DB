using Projekt_Szpital.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_Szpital.Interface
{
    public interface IPracownik
    {
        public void post(Pracownik pracownik);
        public void put(int pracownikid,string nazwisko,string imie);
        public Pracownik getPracownikById(int id);
        public void  deletePracownik(int id);
    }
}
