using System;
using System.Collections.Generic;
using System.Text;

namespace IkinciElAracSatisSistemi.Abstracts
{
    public abstract class Uye : Islemler<Uye> ,IIletisimBilgileri, IGiris
    {
        public int UyeNo { get; set; }
        public long TelefonNo { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string EPosta { get; set; }
        public string Parola { get; set; }
    }
}
