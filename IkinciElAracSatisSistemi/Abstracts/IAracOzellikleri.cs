using System;
using System.Collections.Generic;
using System.Text;

namespace IkinciElAracSatisSistemi.Abstracts
{
    public interface IAracOzellikleri
    {
        string AracTuru { get; set; }
        string YakitTuru { get; set; }
        int UretimYili { get; set; }
        string Marka { get; set; }
        string Model { get; set; }
        string Motor { get; set; }
        string Sanziman { get; set; }
        int Kilometre { get; set; }
        bool? SisFari { get; set; }
        bool? CamTavan { get; set; }
        bool? KatlanabilirAyna { get; set; }
        bool? ParkSensoru { get; set; }
        bool? MerkeziKilit { get; set; }
    }
}
