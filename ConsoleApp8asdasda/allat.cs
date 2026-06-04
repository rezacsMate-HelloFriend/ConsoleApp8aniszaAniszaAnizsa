using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8asdasda
{
    public class allat
    {
        public string Nev { get; set; }
        public int Kor { get; set; }

        public allat(string Nev, int Kor)
        {
            this.Nev = Nev;
            this.Kor = Kor;
        }
    }

    public class kutya : allat
    {
        public string Fajta { get; set; }

        public kutya(string Nev, int Kor, string Fajta) : base(Nev, Kor)
        {
            this.Fajta = Fajta;
        }

        public void AdatokKiirasa()
        {
            Console.WriteLine($"{Nev} {Kor} {Fajta}");
        }
    }


}
