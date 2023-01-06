using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interface_Enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            cmbUrunDurum.DataSource = Enum.GetNames(typeof(UrunDurum));
            cmbSiparisDurum.DataSource = Enum.GetNames(typeof(SiparisDurum));
        }

        UrunListManager urunListManager = new UrunListManager();
        siparisListManager siparisListManager = new siparisListManager();

        Guid yeniUrunKodu;
        private void btnUrunKaydet_Click(object sender, EventArgs e)
        {
            Urun urun = new Urun();
            urun.urunKodu = yeniUrunKodu;
            urun.urunAdi = txtUrunAdi.Text;
            urun.fiyat = Convert.ToDecimal(txtFiyat.Text);
            urun.durum = (UrunDurum)Enum.Parse(typeof(UrunDurum), cmbUrunDurum.SelectedItem.ToString());
            urunListManager.Ekle(urun);
            UrunList();
        }
        void UrunList()
        {
            dgUrunListesi.Rows.Clear();
            foreach (var item in urunListManager.Liste())
            {
                if (cmbUrunDurum.SelectedItem.ToString() == UrunDurum.StoktaVar.ToString())
                    dgUrunListesi.Rows.Add(item.urunKodu, item.urunAdi, item.fiyat, item.durum);
            }
        }

        private void dgUrunListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txtUrunKodu.Text = dgUrunListesi.Rows[row].Cells[0].Value.ToString();
            txtSUrunKodu.Text = dgUrunListesi.Rows[row].Cells[0].Value.ToString();
            txtUrunAdi.Text = dgUrunListesi.Rows[row].Cells[1].Value.ToString();
            txtSUrunAdi.Text = dgUrunListesi.Rows[row].Cells[1].Value.ToString();
            txtFiyat.Text = dgUrunListesi.Rows[row].Cells[2].Value.ToString();
            cmbUrunDurum.SelectedItem = (UrunDurum)dgUrunListesi.Rows[row].Cells[3].Value;
        }

        private void btnYeniUrun_Click(object sender, EventArgs e)
        {
            yeniUrunKodu = Guid.NewGuid();
            txtUrunKodu.Text = yeniUrunKodu.ToString();
        }

        #region sepet
        List<Sepet> sepetList = new List<Sepet>();

        void sepeteEkle(Urun urun, int adet)
        {
            int sepetId = sepetList.Count > 0 ? sepetList.Max(_ => _.sepetId) : 0;
            if (sepetId > 0)
                sepetId++;
            else
                sepetId = 1;
            Sepet spt = new Sepet()
            {
                sepetId = sepetteVarMi(urun) ? sepetList.FirstOrDefault(x => urun.urunKodu == urun.urunKodu).sepetId : sepetId,
                urun = urun,
                adet = adet
            };
            sepetList.Add(spt);
        }
        bool sepetteVarMi(Urun urun)
        {
            return sepetList.Exists(x => x.urun.urunKodu == urun.urunKodu);
        }
        void sepetiTemizle()
        {
            sepetList.Clear();
        }
        #endregion
        #region siparis
        private void btnSiparisTamamla_Click(object sender, EventArgs e)
        {
            List<Urun> sepettekiUrunList = new List<Urun>();
            sepetList.ForEach(x => { sepettekiUrunList.Add(x.urun); });
            
            if (!string.IsNullOrEmpty(txtSiparisKodu.Text))
            {
                Siparis siparis = new Siparis();
                siparis.urun = sepettekiUrunList;
                siparis.siparisKodu = Int32.Parse(txtSiparisKodu.Text);
                siparis.durum = SiparisDurum.SiparisAlindi;
                siparisListManager.Ekle(siparis);
                SiparisList();
            }
            else
                MessageBox.Show("sipariş kodu boş olmaz");
            
        }

        void SiparisList()
        {
            dgSiparisListesi.Rows.Clear();
            foreach (var item in siparisListManager.Liste())
            {
                foreach (var urun in item.urun)
                {
                    dgSiparisListesi.Rows.Add(item.siparisKodu,urun.urunAdi,urun.fiyat, item.durum);
                }

               

            }
        }
        private void btnDegisiklikKaydet_Click(object sender, EventArgs e)
        {

            Siparis mevcutSiparis = siparisListManager.Liste().FirstOrDefault(x => x.siparisKodu == Int32.Parse(txtSiparisKodu.Text));
            mevcutSiparis.durum = (SiparisDurum) Enum.Parse(typeof(SiparisDurum),cmbSiparisDurum.SelectedItem.ToString());
            SiparisList();
        }


        #endregion

        private void nmAdet_ValueChanged(object sender, EventArgs e)
        {
            decimal fiyat = urunListManager.Liste().FirstOrDefault(x => x.urunKodu.ToString() == txtSUrunKodu.Text).fiyat;
            txtTutar.Text = (fiyat * nmAdet.Value).ToString();
        }

        private void dgSiparisListesi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            txtSSiparisKodu.Text = dgSiparisListesi.Rows[row].Cells[0].Value.ToString();
            cmbSiparisDurum.SelectedItem = (SiparisDurum)dgSiparisListesi.Rows[row].Cells[3].Value;
        }

        private void btnSepet_Click(object sender, EventArgs e)
        {
            sepeteEkle(urunListManager.Liste().FirstOrDefault(x => x.urunKodu.ToString() == txtSUrunKodu.Text), Convert.ToInt32(nmAdet.Value));
        }
    }
}
