using Projekt_Szpital.Interface;
using Projekt_Szpital.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_Szpital.Repository
{
    public class PracownikRepository : IPracownik
    {
        private readonly DbContext context;

        public PracownikRepository(DbContext dbContext)
        {
            context = dbContext;
        }

        public  void deletePracownik(int id)
        {
            context.Pracownik.Where(x => x.id == id).Delete();
        }

       

        public Pracownik getPracownikById(int id)
        {
            
            return context.Pracownik.Where(x => x.id == id).Single();
        }

        public void post(Pracownik pracownik)
        {
            context.Add(pracownik);
        }

        public void put(int pracownikid, string nazwisko, string imie)
        {
            Pracownik p = getPracownikById(pracownikid);
            if (p != null) { p.Nazwisko = nazwisko;p.Imie = imie; }
        }
    }
}
