using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8asdasda
{
    public class dolgozo
    {
        protected string nev { get; set; }
        private int fizetes { get; set; }

        public dolgozo(string nev, int fizetes)
        {
            this.nev = nev;
            this.fizetes = fizetes;
        }

        public int GetFizetes()
        {
            return fizetes;
        }

        public void FizetesEmeles(int osszeg)
        {
            fizetes += osszeg;
        }
    }

    public class tanar : dolgozo
    {
        public string tantargy { get; set; }

        public tanar(string nev, int fizetes, string tantargy) : base(nev, fizetes)
        {
            this.tantargy = tantargy;
        }

        public string Bemutatkozas()
        {
            return $"{nev} vagyok és {tantargy} tanítok.";
        }
    }
}
