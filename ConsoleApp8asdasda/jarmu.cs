using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8asdasda
{
    public class jarmu
    {
        public string Marka { get; set; }
        public int Sebesseg { get; set; }

        public jarmu(string Marka, int Sebesseg)
        {
            this.Marka = Marka;
            this.Sebesseg = Sebesseg;
        }
    }

    public class auto : jarmu
    {
        public int AjtokSzama { get; set; }

        public auto(string Marka, int Sebesseg, int AjtokSzama) : base(Marka, Sebesseg)
        {
            this.AjtokSzama = AjtokSzama;
        }

        public bool GyorshajtoE()
        {
            return Sebesseg > 50;
        }
    }

}
