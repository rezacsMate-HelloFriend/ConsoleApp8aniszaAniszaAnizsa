using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8asdasda
{
    public class sportolo
    {
        protected string nev { get; set; }
        protected int kor { get; set; }
        private int pontszam { get; set; }

        public sportolo(string nev, int kor, int pontszam)
        {
            this.nev = nev;
            this.kor = kor;
            this.pontszam = pontszam;
        }

        public void PontNovel(int mennyi)
        {
            pontszam += mennyi;
        }

        public int GetPontszam()
        {
            return pontszam;
        }
    }

    public class focista : sportolo
    {
        public int golok { get; set; }

        public focista(string nev, int kor, int pontszam) : base(nev, kor, pontszam)
        {
            this.golok = 0;
        }

        public void GolNovel()
        {
            golok++;
        }

        public int HanyPontKell1000hez()
        {
            return 1000 - GetPontszam();
        }
    }
}
