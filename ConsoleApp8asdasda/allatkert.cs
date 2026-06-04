using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8asdasda
{
    public class allatkert
    {
        protected string nev { get; set; }
        private int eletkor { get; set; }

        public allatkert(string nev, int eletkor)
        {
            this.nev = nev;
            this.eletkor = eletkor;
        }

        public int GetEletkor()
        {
            return eletkor;
        }

        public virtual string HangotAd()
        {
            return "Valamilyen állathang";
        }
    }

    public class kutyaa : allatkert
    {
        
        public kutyaa(string nev, int eletkor) : base(nev, eletkor)
        {
            
        }

        public override string HangotAd()
        {
            return "Vau";
        }
    }

    public class macska : allatkert
    {
        public macska(string nev, int eletkor) : base(nev, eletkor)
        {

        }

        public override string HangotAd()
        {
            return "Miau";
        }
    }

}
