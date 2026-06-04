using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8asdasda
{
    public class eloleny
    {
        protected string nev { get; set; }

        public eloleny(string nev)
        {
            this.nev = nev;
        }

        public string GetNev()
        {
            return nev;
        }
    }

    public class alat : eloleny
    {
        protected int kor;

        public alat(string nev, int kor) : base(nev)
        {
            this.kor = kor;
        }

        public int GetKor()
        {
            return kor;
        }
    }

    public class kua : alat
    {
        public string fajta { get; set; }

        public kua(string nev, int kor, string fajta) : base(nev, kor)
        {
            this.fajta = fajta;
        }

        public string OsszesAdat()
        {
            return $"{GetNev()} {GetKor()} {fajta}";
        }
    }
}
