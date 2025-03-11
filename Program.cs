using System;

namespace Jurnalmodul4_103022300104
{

    class Program
    {

        static void Main()
        {
            KodeProduk kodeProduk = new KodeProduk();

            Console.Write("Masukkan nama produk: ");
            string kodeproduk = Console.ReadLine();

            string kode = kodeProduk.GetKodeProduk(kodeproduk);
            Console.WriteLine($"Kode produk untuk {kodeproduk} adalah {kode}");
        }
    }
}