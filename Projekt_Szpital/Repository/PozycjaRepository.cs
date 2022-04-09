using Projekt_Szpital.Interface;
using Projekt_Szpital.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_Szpital.Repository
{
    public class PozycjaRepository : IPozycja
    {
        private readonly DbContext context;
        public PozycjaRepository(DbContext dbContext)
        {
            context = dbContext;
        }

        public Pozycja GetPracownikById(int id)
        {
            return context.Pracownik.Where(x => x.id == id).Single();
        }

        public void post(Pozycja pozycja, Pracownik pracownik)
        {
            Pracownik p = pracownik;
            if (p != null) { p.Pozycja = pozycja; }
        }

        public void put(Pracownik pracownik, string spec)
        {
            Pracownik p = pracownik;
            if (p != null) { p.Pozycja.Specjalizacja = spec;}
        }
    }
}
