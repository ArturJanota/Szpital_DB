using Projekt_Szpital.Interface;
using Projekt_Szpital.Models;
using Projekt_Szpital.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt_Szpital.BuisnesLayer
{
    public class UnitOfWork
    {
        private BdContext context = new BdContext();
        private IPozycja pozycja;
        private IPacjent pacjent;
        private IZabiegi zabiegi;
        private IPracownik pracownik;
        public IPozycja Pozycja
        {
            get
            {
                if(this.pozycja==null)
                {
                    this.pozycja = new PozycjaRepository(context);
                }
                return this.pozycja;
            }
        }
        public IPacjent Pacjent
        {
            get
            {
                if (this.pacjent == null)
                {
                    this.pacjent = new PozycjaRepository(context);
                }
                return this.pacjent;
            }
        }
        public IZabiegi Zabiegi
        {
            get
            {
                if (this.zabiegi == null)
                {
                    this.zabiegi = new PozycjaRepository(context);
                }
                return this.zabiegi;
            }
        }
        public IPracownik Pracownik
        {
            get
            {
                if (this.pracownik == null)
                {
                    this.pracownik = new PozycjaRepository(context);
                }
                return this.pracownik;
            }
        }
    }
}
