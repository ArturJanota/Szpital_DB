using Projekt_Szpital.Interface;
using Projekt_Szpital.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_Szpital.Repository
{
    public class PacjentRepository:IPacjent
    {
        private readonly DbContext context;

        public IReadOnlyList<IPacjent> pacjents = new List<IPacjent>;

        public PacjentRepository(DbContext dbContext)
        {
            context = dbContext;
        }
        public void post(Pacjent pacjent)
        {
            context.Add(pacjent);
        }
        public void put(int PacjentId,int pesel)
        {
            Pacjent p = getPacjentById(PacjentId);
            if (p != null) { p.Pesel = pesel; }
        }
        public Pacjent getPacjentById(int PacjentId)
        {
            return context.Pacjent.Where(x => x.id == PacjentId).Single();
        }

        
    }
}
