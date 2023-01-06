using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Enum
{
    internal class Urun
    {
        public Guid urunKodu { get; set; }
        public string urunAdi { get; set; }
        public decimal fiyat { get; set; }
        public UrunDurum durum{ get; set; }
    }
    internal class Sepet
    {
        public int sepetId { get; set; }
        public Urun urun { get; set; }
        public int adet { get; set; }
    }
    internal class Siparis
    {
        public int siparisKodu { get; set; }
        public List<Urun> urun { get; set; }       
        public DateTime siparisTarihi => DateTime.Now;
        public SiparisDurum durum { get; set; }
    }
    internal class siparisListManager : IListe<Siparis>
    {
        static List<Siparis> siparisListesi = new List<Siparis>();

        public void Ekle(Siparis model)
        {
            if (siparisListesi.Exists(u => u.siparisKodu == model.siparisKodu))
            {
                var bulunanUrun = siparisListesi.Find(y => y.siparisKodu == model.siparisKodu);
               
                bulunanUrun.durum = model.durum;
            }
            else
                siparisListesi.Add(model);
        }

        public List<Siparis> Liste()
        {
            return siparisListesi;
        }
    }
    internal class UrunListManager : IListe<Urun>
    {
        static List<Urun> urunListesi = new List<Urun>();
        public void Ekle(Urun model)
        {
            if (urunListesi.Exists(u => u.urunKodu == model.urunKodu))
            {
                var bulunanUrun= urunListesi.Find(y => y.urunKodu == model.urunKodu);
                bulunanUrun.urunAdi = model.urunAdi;
                bulunanUrun.fiyat=model.fiyat;
                bulunanUrun.durum = model.durum;
            }
            else
            urunListesi.Add(model);
        }

        public List<Urun> Liste()
        {
            return urunListesi;
        }
    }
}
