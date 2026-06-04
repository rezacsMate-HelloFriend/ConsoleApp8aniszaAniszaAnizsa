using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8asdasda
{
    public class jarmuv
    {
        protected string marka { get; set; }
        private int kilometerOra { get; set; }

        public jarmuv(string marka, int kilometerOra)
        {
            this.marka = marka;
            this.kilometerOra = kilometerOra;
        }

        public int GetSebesseg()
        {
            return kilometerOra;
        }

        public void Gyorsit(int mennyivel)
        {
            kilometerOra += mennyivel;
        }

        public virtual string Hang()
        {
            return "A jármű hangot ad.";
        }
    }

    public class autoa : jarmuv
    {
        public int ajtokSzama { get; set; }

        public autoa(string marka, int kilometerOra, int ajtokSzama) : base(marka, kilometerOra)
        {
            this.ajtokSzama = ajtokSzama;
        }

        public bool CsaladiAutoE()
        {
            return ajtokSzama >= 4;
        }

        public override string Hang()
        {
            return "Brrr";
        }
    }

    public class motor : jarmuv
    {
        public bool bukosisakKotelezo { get; set; }

        public motor(string marka, int kilometerOra, bool bukosisakKotelezo) : base(marka, kilometerOra)
        {
            this.bukosisakKotelezo = bukosisakKotelezo;
        }

        public bool KellBukosisak()
        {
            return bukosisakKotelezo;
        }

        public override string Hang()
        {
            return "Brumm";
        }
    }

    public class kamion : jarmuv
    {
        public int teherbiras { get; set; }

        public kamion(string marka, int kilometerOra, int teherbiras) : base(marka, kilometerOra)
        {
            this.teherbiras = teherbiras;
        }

        public bool NagyTeherbirasuE()
        {
            return teherbiras > 10000;
        }

        public override string Hang()
        {
            return "Duda";
        }
    }
}
