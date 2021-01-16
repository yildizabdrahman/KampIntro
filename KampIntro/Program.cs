using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety - tip güvenliği
            // string  KategoriEtiketi = "Kategoriler"
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool girisYapmismi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (girisYapmismi)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine("\n"+kategoriEtiketi+"\n");

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Düşüş Oku");
            }
            else if (dolarBugun > dolarDun)
            {
                Console.WriteLine("Yükseliş Oku");
            }
            else
            {
                Console.WriteLine("Sabit Oku");
            }

    }
    }                                                                                                                       
}
