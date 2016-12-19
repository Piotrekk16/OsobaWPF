using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication14
{
    class Osoba
    {
        private string imie;
        private string nazwisko;

        private DateTime dataurodzenia;

        public Osoba() { }

        public void Ustaw(string imie,string nazw, DateTime data)
        {
            this.imie = imie;
            this.nazwisko = nazw;
            this.dataurodzenia = data;
        }

        public int ObliczWiek()
        {
            return DateTime.Now.Year - dataurodzenia.Year;
        }

        public override string ToString()
        {
            string data3 = dataurodzenia.Day + "." + dataurodzenia.Month + "." + dataurodzenia.Year;
            return imie + "\n" + nazwisko + "\n" + data3+"\n"+ObliczWiek();
        }
    }
}
