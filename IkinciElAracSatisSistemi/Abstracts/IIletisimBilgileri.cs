using System;
using System.Collections.Generic;
using System.Text;

namespace IkinciElAracSatisSistemi.Abstracts
{
    public interface IIletisimBilgileri
    {
        long TelefonNo { get; set; }
        string Ad { get; set; }
        string Soyad { get; set; }
    }
}
