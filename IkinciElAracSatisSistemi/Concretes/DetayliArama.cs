using System;
using System.Collections.Generic;
using System.Text;
using IkinciElAracSatisSistemi.Abstracts;

namespace IkinciElAracSatisSistemi.Concretes
{
    public static class DetayliArama
    {
        private static List<Filtre> filtreler = new List<Filtre>();

        public static void FiltreEkle(string ozellik, string islem, int deger)
        {
            filtreler.Add(new Filtre(ozellik, islem, deger));
        }
        public static List<Ilan> AramaYap()
        {
            throw new Exception();
        }
    }
}
