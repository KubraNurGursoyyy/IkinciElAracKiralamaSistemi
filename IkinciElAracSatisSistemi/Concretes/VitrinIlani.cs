using IkinciElAracSatisSistemi.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace IkinciElAracSatisSistemi.Concretes
{
    public class VitrinIlanlari : Islemler<VitrinIlanlari>
    {
        private IVitrinIlani ivitrinilani;
        
        public VitrinIlanlari(IVitrinIlani _vitrinilani)
        {
            this.ivitrinilani = _vitrinilani;
        }
        public IVitrinIlani VitrinIlaniGoruntule()
        {
            return ivitrinilani;
        }

        public override void Ekle(VitrinIlanlari Entity)
        {
            throw new NotImplementedException();
        }


        public override void Guncelle(int ID, VitrinIlanlari Entity)
        {
            throw new NotImplementedException();
        }

        public override void Sil()
        {
            throw new NotImplementedException();
        }

        public List<VitrinIlanlari> VitrinIlanlariGoruntule()
        {
            throw new NotImplementedException();
        }
    }
}
