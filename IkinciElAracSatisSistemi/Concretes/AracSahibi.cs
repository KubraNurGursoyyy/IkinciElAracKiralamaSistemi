using System;
using System.Collections.Generic;
using System.Text;
using IkinciElAracSatisSistemi.Abstracts;

namespace IkinciElAracSatisSistemi.Concretes
{
    public class AracSahibi : Uye
    {
        public void YeniAracIlaniGir(IAracOzellikleri ozellikler, IVitrinIlani bilgiler){ }
        public List<IVitrinIlani> MevcutIlanlariGoruntule(){ throw new Exception();}
        public void MevcutIlaniGuncelle(IAracOzellikleri ozellikler, IVitrinIlani bilgiler, int ilanno){ }
        public void MevcutIlaniKaldir(int ilanno){ }
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
