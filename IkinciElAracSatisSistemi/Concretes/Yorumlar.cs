using System;
using System.Collections.Generic;
using System.Text;
using IkinciElAracSatisSistemi.Abstracts;

namespace IkinciElAracSatisSistemi.Concretes
{
    public class Yorumlar: Islemler<Yorumlar>
    {
        public int YorumNo { get; set; }
        public int IlanNo { get; set; }
        public int MusteriNo { get; set; }
        public string Yorum { get; set; }

        public override void Ekle(Yorumlar Entity)
        {
            throw new NotImplementedException();
        }

        public override void Guncelle(int ID, Yorumlar Entity)
        {
            throw new NotImplementedException();
        }

        public override void Sil()
        {
            throw new NotImplementedException();
        }
    }
}
