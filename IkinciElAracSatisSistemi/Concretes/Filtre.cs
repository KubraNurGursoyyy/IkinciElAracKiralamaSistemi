using System;
using System.Collections.Generic;
using System.Text;
using IkinciElAracSatisSistemi.Abstracts;

namespace IkinciElAracSatisSistemi.Concretes
{
    public class Filtre
    {
        private string Ozellik { get; set; }
        private string Islem { get; set; }
        private int Deger { get; set; }
        public Filtre(string ozellik, string islem, int deger)
        {
            this.Ozellik = ozellik;
            this.Islem = islem;
            this.Deger = deger;
        }
    }
}
