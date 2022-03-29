using System;
using System.Collections.Generic;
using System.Text;
using IkinciElAracSatisSistemi.Abstracts;

namespace IkinciElAracSatisSistemi.Concretes
{
    public class Arac : Islemler<Arac>
    {
        public List<IAracOzellikleri> AracOzellikleriListesi { get; set; }
        public override void Ekle(Arac Entity)
        {
            throw new NotImplementedException();
        }

        public override void Guncelle(int ID, Arac Entity)
        {
            throw new NotImplementedException();
        }

        public override void Sil()
        {
            throw new NotImplementedException();
        }
    }
}
