using System;
using System.Collections.Generic;
using System.Text;

namespace IkinciElAracSatisSistemi.Abstracts
{
    public abstract class Islemler<T> where T : class
    {
        public abstract void Ekle(T Entity);
        public abstract void Guncelle(int ID, T Entity);
        public abstract void Sil();

    }
}
