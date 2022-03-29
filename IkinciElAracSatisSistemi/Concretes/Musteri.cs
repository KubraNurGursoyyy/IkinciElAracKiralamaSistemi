using System;
using System.Collections.Generic;
using System.Text;
using IkinciElAracSatisSistemi.Abstracts;

namespace IkinciElAracSatisSistemi.Concretes
{
    public class Musteri : Uye
    {
        public void YorumYap(int ilanno, string yorum) { }
        public override void Ekle(Uye Entity)
        {
            throw new NotImplementedException();
        }

        public override void Guncelle(int ID, Uye Entity)
        {
            throw new NotImplementedException();
        }

        public override void Sil()
        {
            throw new NotImplementedException();
        }
    }
}
