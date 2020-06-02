using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSampleVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad;
            string soyad;
            string adres;

            //Console.Write("Lütfen adınızı yazınız");
            // Console.WriteLine("Lütfen adınızı yazınız");
            //ad= Console.ReadLine();
            // Console.WriteLine("Lütfen soyadınızı yazınız");
            // soyad = Console.ReadLine();
            // Console.WriteLine(ad);
            // Console.WriteLine(soyad);
            // Console.Read();

            //Console.Write()=> bağlı bulunduğu satıra yazar
            //Console.WriteLine()=>değeri ekrana yazar imleci bir satır aşağıya kaydırır.

            //Console.Read()=> Console ekranının kapanmamasını önler.
            //Console.ReadLine()=> bağlı bulunduğu satır değerini okur.

            Console.WriteLine("Adınız: ");
            ad = Console.ReadLine();
            Console.WriteLine("Soyadınız: ");
            soyad = Console.ReadLine();
            Console.WriteLine("Lütfen bekleyin....Bilgilerinizi kontrol ediyorum...");
            Console.Beep(1000, 1000);
            Console.Beep(1500, 1000);
            Console.WriteLine("Adınız: " + ad);
            Console.WriteLine("Soyadınız: " + soyad);
            Console.WriteLine("Başkabir arzunuz var mı?");
            Console.Read();

        }
    }
}
