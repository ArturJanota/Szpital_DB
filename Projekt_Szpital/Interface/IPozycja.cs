using Projekt_Szpital.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_Szpital.Interface
{
    public interface IPozycja
    {
        public void post(Pozycja pozycja,Pracownik pracownik);
        public void put(Pracownik pracownik,string spec);
        public Pozycja GetPracownikById(int id);
    }
}
