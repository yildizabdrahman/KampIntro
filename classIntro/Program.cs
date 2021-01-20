using System;

namespace classIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.İzlenmeOrani = 70;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Pyhon";
            kurs2.Egitmen = "Serhat Yıldız";
            kurs2.İzlenmeOrani = 170;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.Egitmen = "Yaren Yıldız";
            kurs3.İzlenmeOrani = 40;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "Php";
            kurs4.Egitmen = "Baran Yıldız";
            kurs4.İzlenmeOrani = 140;

            //Console.WriteLine(kurs1.KursAdi+" "+kurs1.Egitmen+" "+kurs1.İzlenmeOrani);
            //Console.WriteLine(kurs2.KursAdi+" "+kurs2.Egitmen+" "+kurs2.İzlenmeOrani);
            //Console.WriteLine(kurs3.KursAdi+" "+kurs3.Egitmen+" "+kurs3.İzlenmeOrani);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+": "+kurs.Egitmen+" izlenme: "+kurs.İzlenmeOrani);
            }

        }

    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int İzlenmeOrani { get; set; }

    }
}
