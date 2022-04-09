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
        private readonly DbContext context;

        public ZabiegiRepository(DbContext dbContext)
        {
            context = dbContext;
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
