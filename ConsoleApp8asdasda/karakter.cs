using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8asdasda
{
    public class karakter
    {
        protected string nev { get; set; }
        protected int eletero { get; set; }
        private int szint { get; set; }

        public karakter(string nev, int eletero, int szint)
        {
            this.nev = nev;
            this.eletero = eletero;
            this.szint = szint;
        }

        public void Sebzodik(int sebzes)
        {
            eletero -= sebzes;

            if (eletero < 0)
            {
                eletero = 0;
            }
        }

        public int GetSzint()
        {
            return szint;
        }

        public virtual string Tamad()
        {
            return "A karakter támad.";
        }
    }

    public class harcos : karakter
    {
        public harcos(string nev, int eletero, int szint) : base(nev, eletero, szint)
        {

        }

        public override string Tamad()
        {
            return "A harcos karddal támad.";
        }
    }

    public class ijasz : karakter
    {
        public ijasz(string nev, int eletero, int szint) : base(nev, eletero, szint)
        {

        }

        public override string Tamad()
        {
            return "Az íjász nyíllal támad.";
        }
    }

    public class varazslo : karakter
    {
        public varazslo(string nev, int eletero, int szint) : base(nev, eletero, szint)
        {

        }

        public override string Tamad()
        {
            return "A varázsló tűzgolyót idéz.";
        }
    }
}
