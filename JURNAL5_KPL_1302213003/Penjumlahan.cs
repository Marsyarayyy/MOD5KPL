using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JURNAL5_KPL_1302213003
{
    internal class Penjumlahan
    {
        public void JumlahTigaAngka<T> (T input1, T input2, T input3)
        {
            dynamic angka1 = input1;
            dynamic angka2 = input2;
            dynamic angka3 = input3;
            Console.WriteLine("hasil penjumlahan angka: " + (angka1 + angka2 + angka3));

        }
    }
}

