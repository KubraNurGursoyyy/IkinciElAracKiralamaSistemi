using System;
using System.Collections.Generic;
using System.Text;

namespace IkinciElAracSatisSistemi.Abstracts
{
    public interface IVitrinIlani
    {
        string IlanBasligi { get; set; }
        int Fiyat { get; set; }
        DateTime IlanTarihi { get; set; }
        string Adres { get; set; }
    }
}
