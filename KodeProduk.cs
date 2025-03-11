using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jurnalmodul4_103022300104
{
    class KodeProduk
    {
        private Dictionary<string, string> kodeProdukTable = new Dictionary<string, string>
        {
            {"Laptop", "E100" },
            {"Smartphone", "E101" },
            {"Tablet", "E102" },
            {"Headset", "E103" },
            {"Keyboard", "E104" },
            {"Mouse", "E105" },
            {"Printer", "E106" },
            {"Monitor", "E107" },
            {"Smartwatch", "E108" },
            {"Kamera", "E109" }
        };

        public string GetKodeProduk(string kodeproduk)
        {
            if (kodeProdukTable.ContainsKey(kodeproduk))
            {
                return kodeProdukTable[kodeproduk];
            }
            else
            {
                return "Kode Produk tidak ditemukan";
            }
        }
    }
}
