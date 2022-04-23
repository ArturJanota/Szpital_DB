using Projekt_Szpital.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_Szpital.BuisnesLayer
{
    interface IUnitOfWork
    {
        public IPozycja Pozycja { get; }
        public IPacjent Pacjent { get; }
             public IZabiegi Zabiegi { get; }
            public IPracownik Pracownik { get; }
    }
}
