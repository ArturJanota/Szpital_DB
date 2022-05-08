using Projekt_Szpital.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_Szpital.Interface
{
    public interface IPacjent
    {
        public void post(Pacjent pacjent);
        public void put(int pacjentID, int pesel);
        public Pacjent getPacjentById(int id);

        IEnumerable<IPacjent> GetPacjentById();
    }
}
