using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8asdasda
{
    public class konyvek
    {
        // ===============================
        // 5. feladat – Könyvek
        // ===============================

        // Készíts egy Konyv osztályt!
        // Protected adattag:
        // - cim string
        protected string cim { get; set; }
        // Private adattag:
        // - oldalszam int
        private int olddalszam { get; set; }

        // Konstruktor:
        // Paraméterek:
        // - cim string
        // - oldalszam int
        public konyvek(string cim, int oldalszam)
        {
            this.cim = cim;
            this.olddalszam = oldalszam;

        }
        public int GetOldalszam()
        {
            return olddalszam;
        }
        // Függvény:
        // GetOldalszam()
        // Paraméter: nincs
        // Visszatérési típus: int
        // Feladat: adja vissza a könyv oldalszámát.
        public class Regeny : konyvek
        {

            public string mufaj { get; set; }
            public Regeny(string cim, int oldalszam, string mufaj) : base(cim, oldalszam)
            {
                this.mufaj = mufaj;
            }
            public bool HosszuKonyvE()
            {
                return GetOldalszam() > 300 ? true : false;
            }
        }
        // Készíts egy Regeny osztályt, amely a Konyv osztályból származik!
        // Plusz adattag:
        // - mufaj string

        // Függvény:
        // HosszuKonyvE()
        // Paraméter: nincs
        // Visszatérési típus: bool
        // Feladat: adjon vissza true értéket, ha a könyv több mint 300 oldalas,
        // különben false értéket.

    }
}
