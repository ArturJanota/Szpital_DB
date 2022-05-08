using Projekt_Szpital.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_Szpital.Interface
{
    public interface IZabiegi
    {
        public void post(Zabiegi zabiegi);
        public void put(int zabiegID, Pacjent pacjent,Pracownik pracownik);
        public Zabiegi getZabiegById(int id);

        IEnumerable<Pracownik> GetPracownicy(int id);
    }
}
