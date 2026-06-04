using static ConsoleApp8asdasda.konyvek;

namespace ConsoleApp8asdasda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, Friend!");
            Console.WriteLine("-----------------------------------");
            kutya dog = new kutya("Bodri", 5, "Labrador");
            dog.AdatokKiirasa();
            Console.WriteLine("-----------------------------------");
            auto cart = new auto("Toyota", 60, 5);
            Console.WriteLine(cart.GyorshajtoE());
            Console.WriteLine("-----------------------------------");
            tanar teach = new tanar("Kovács Béla", 500000, "Matematikát");
            Console.WriteLine(teach.Bemutatkozas());
            Console.WriteLine(teach.GetFizetes());
            teach.FizetesEmeles(50000);
            Console.WriteLine(teach.GetFizetes());
            Console.WriteLine("-----------------------------------");
            focista baller = new focista("Rossi", 25, 800);
            baller.GolNovel();
            baller.PontNovel(100);
            Console.WriteLine(baller.GetPontszam());
            Console.WriteLine(baller.HanyPontKell1000hez());
            Console.WriteLine("-----------------------------------");
            Regeny regenye = new Regeny("something", 500, "ballada");
            Console.WriteLine(regenye.GetOldalszam());
            Console.WriteLine(regenye.HosszuKonyvE());
            Console.WriteLine("-----------------------------------");
            SpecialItems item = new SpecialItems("Majer Agya", -1000, 0) { };
            Console.WriteLine(item.WarrantyEnd(2026));
            Console.WriteLine("-----------------------------------");
            diak diaks = new diak("majer", 18, "11k");
            Console.WriteLine(diaks.Bemutatkozas());
            Console.WriteLine(diaks.ErettsegizhetE());
            Console.WriteLine("-----------------------------------");
            kutyaa kk = new kutyaa("Bodri", 4);
            macska m = new macska("Cirmi", 3);
            Console.WriteLine(kk.HangotAd());
            Console.WriteLine(m.HangotAd());
            Console.WriteLine("-----------------------------------");
            harcos h = new harcos("Thor", 100, 5);
            ijasz i = new ijasz("Legolas", 80, 7);
            varazslo v = new varazslo("Merlin", 60, 10);
            h.Sebzodik(30);
            Console.WriteLine(h.Tamad());
            Console.WriteLine(h.GetSzint());
            kua asd = new kua("Bodri", 5, "Labrador");
            Console.WriteLine(asd.OsszesAdat());
            Console.WriteLine("-----------------------------------");
            autoa a1 = new autoa("Toyota", 80, 5);
            autoa a2 = new autoa("Opel", 60, 3);

            motor m1 = new motor("Yamaha", 120, true);
            motor m2 = new motor("Honda", 90, false);

            kamion k1 = new kamion("Volvo", 70, 15000);
            kamion k2 = new kamion("MAN", 60, 8000);

            a1.Gyorsit(10);

            Console.WriteLine(a1.Hang());
            Console.WriteLine(a1.CsaladiAutoE());

            Console.WriteLine(m1.Hang());
            Console.WriteLine(m1.KellBukosisak());

            Console.WriteLine(k1.Hang());
            Console.WriteLine(k1.NagyTeherbirasuE());

            Console.WriteLine(a2.GetSebesseg());
            Console.WriteLine(k2.GetSebesseg());
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("-----------------------------------");
        }
    }
}
