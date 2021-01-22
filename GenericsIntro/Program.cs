using System;
using System.Collections;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();

            isimler.Add("Baran");
            Console.WriteLine(isimler.Length);

            isimler.Add("Yaren");
            Console.WriteLine(isimler.Length);

            isimler.Add("Serhat");
            Console.WriteLine(isimler.Length);

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }
        }
    }
}
