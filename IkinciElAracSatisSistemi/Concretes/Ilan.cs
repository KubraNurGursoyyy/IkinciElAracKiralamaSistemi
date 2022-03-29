using System;
using System.Collections.Generic;
using System.Text;
using IkinciElAracSatisSistemi.Abstracts;

namespace IkinciElAracSatisSistemi.Concretes
{
    public class Ilan : Islemler<Ilan> , IVitrinIlani, IAracOzellikleri, IIletisimBilgileri
    {
        public int IlanNo { get; set; }
        public int Fiyat { get; set; }
        public string Adres { get; set; }
        public string IlanBasligi { get; set; }
        public int Yil { get; set; }
        public long KM { get; set; }
        public DateTime IlanTarihi { get; set; }
        public string AracTuru { get; set; }
        public string YakitTuru { get; set; }
        public int UretimYili { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Motor { get; set; }
        public string Sanziman { get; set; }
        public int Kilometre { get; set; }
        public bool? SisFari { get; set; }
        public bool? CamTavan { get; set; }
        public bool? KatlanabilirAyna { get; set; }
        public bool? ParkSensoru { get; set; }
        public bool? MerkeziKilit { get; set; }
        public long TelefonNo { get; set; }
        public string Ad { get; set ; }
        public string Soyad { get; set; }
        public List<Yorumlar> IlanYorumlari { get; set; }
        public override void Ekle(Ilan Entity)
        {
            throw new NotImplementedException();
        }

        public override void Guncelle(int ID, Ilan Entity)
        {
            throw new NotImplementedException();
        }

        public override void Sil()
        {
            throw new NotImplementedException();
        }
        public Ilan Ara(int ID)
        {
            throw new NotImplementedException();
        }

    }
}
