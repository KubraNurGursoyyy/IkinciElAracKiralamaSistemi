using System;
using System.Collections.Generic;
using System.Text;
using IkinciElAracSatisSistemi.Abstracts;

namespace IkinciElAracSatisSistemi.Concretes
{
    public class SistemYoneticisi : Islemler<SistemYoneticisi> , IGiris
    {
        public int AdminNo { get; set; }
        public string EPosta { get; set; }
        public string Parola { get; set; }

        public List<OnayBekleyenIslemler> BekleyenIslemleriGor() { throw new Exception(); }
        public void OnaylaVeYayinla(int islemno) { }
        public void ReddetVeSil(int islmeno) { }

        public override void Ekle(SistemYoneticisi Entity)
        {
            throw new NotImplementedException();
        }

        public override void Guncelle(int ID, SistemYoneticisi Entity)
        {
            throw new NotImplementedException();
        }

        public override void Sil()
        {
            throw new NotImplementedException();
        }
    }
}
