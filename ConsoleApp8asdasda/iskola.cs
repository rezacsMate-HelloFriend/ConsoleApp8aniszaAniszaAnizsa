using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8asdasda
{
    public class iskola
    {
        // ===============================
        // 7. feladat – Iskola
        // ===============================

        // Készíts egy IskolaiSzemely osztályt!
        // Protected adattagok:
        // - nev string
        // - kor int
        protected string nev { get; set; }
        protected int kor { get; set; }

        // Konstruktor:
        // Paraméterek:
        // - nev string
        // - kor int
        public iskola(string nev, int kor)
        {
            this.nev = nev;
            this.kor = kor;
        }
        // Függvény:
        // Bemutatkozas()
        // Paraméter: nincs
        // Visszatérési típus: string
        // Feladat: adjon vissza egy bemutatkozó szöveget,
        // például: "A nevem Kiss Anna, 17 éves vagyok."
        public string Bemutatkozas()
        {
            return $"{nev}---{kor}";
        }
        // Készíts egy Diak osztályt, amely az IskolaiSzemely osztályból származik!
        // Plusz adattag:
        // - osztaly string

        // Függvény:
        // ErettsegizhetE()
        // Paraméter: nincs
        // Visszatérési típus: bool
        // Feladat: adjon vissza true értéket, ha az osztály neve 12-vel kezdődik,
        // különben false értéket.
    }
    public class diak : iskola
    {
        public string osztaly { get; set; }
        public diak(string nev, int kor, string osztaly) : base(nev, kor)
        {
            this.osztaly = osztaly;
        }
        public bool ErettsegizhetE()
        {
            return osztaly.StartsWith("12") ? false : true;

        }

    }
}
