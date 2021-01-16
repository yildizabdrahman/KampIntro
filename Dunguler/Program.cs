using System;

namespace Dunguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = new string[]
            {
               "Yazılım geliştirme kursu",
               "Php",
               "C#",
               "Java"
            };

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("\nfor end\n");

            foreach (string item in kurslar)
            {
                Console.WriteLine(item);
            }
          
        }
    }
}
