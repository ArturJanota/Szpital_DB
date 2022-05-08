using Projekt_Szpital.BuisnesLayer;
using Projekt_Szpital.Interface;
using Projekt_Szpital.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_Szpital.Repository
{
    public class ZabiegiRepository :IZabiegi
    {
        private readonly IUnitOfWork context;

        public ZabiegiRepository(IUnitOfWork dbContext)
        {
            context = dbContext;
        }

        public IEnumerable<Pracownik> GetPracownicy(int id)
        {
            return context.Pracownik.getPracownikById(id);
        }

       
        public Zabiegi getZabiegById(int ZabiegID)
        {
            return context.Zabiegi.Where(x => x.id == ZabiegID).Single();
        }

        public void post(Zabiegi zabiegi)
        {
            context.Add(zabiegi);
        }

        public void put(int zabiegID, Pacjent pacjent, Pracownik pracownik)
        {
            Zabiegi z = getZabiegById(zabiegID);
            if (z != null) { z.Pacjent.ID = pacjent.ID; z.Wykonany_przez.Add(pracownik); }
        }
    }
}
