using System;
using System.Collections.Generic;
using System.Text;
using IkinciElAracSatisSistemi.Abstracts;

namespace IkinciElAracSatisSistemi.Concretes
{
    public class OnayBekleyenIslemler : Islemler<OnayBekleyenIslemler>
    {
        public int IslemNo { get; set; }
        private IIletisimBilgileri IslemYapanUye { get; set; }
        private IAracOzellikleri IslemBekleyenIlanArac { get; set; }
        private IVitrinIlani IslemBekleyenIlanBilgileri { get; set; }
        public OnayBekleyenIslemler(IIletisimBilgileri musteri, IAracOzellikleri arac, IVitrinIlani bilgiler)
        {
            IslemYapanUye = musteri;
            IslemBekleyenIlanArac = arac;
            IslemBekleyenIlanBilgileri = bilgiler;
        }
        public OnayBekleyenIslemler OnayBekleyenIslemleriGoruntule()
        {
            return this;
        }
        public override void Ekle(OnayBekleyenIslemler Entity)
        {
            throw new NotImplementedException();
        }

        public override void Guncelle(int ID, OnayBekleyenIslemler Entity)
        {
            throw new NotImplementedException();
        }

        public override void Sil()
        {
            throw new NotImplementedException();
        }
    }
}
