using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Enum
{
   public enum SiparisDurum
    {
        SiparisAlindi=0,
        Kargoda=1,
        TeslimEdildi=2,
        İptalEdildi=3
    }
    public enum UrunDurum
    {
        stoktaYok=10,
        StoktaVar=11,
        PasifSatis=12
    }
    public enum CalisanDurum
    {
        AktifGorevde,
        Aktifİzinde,
        İstenAyrildi
    }
    
}
