using System;
using System.Linq;
using System.Windows.Forms;
using IngilizceRandomKelimeApp.Siniflar;

namespace IngilizceRandomKelimeApp.Formlar
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            var oyunaBaslaForm = (OyunaBaslaForm)Application.OpenForms["OyunaBaslaForm"];
            if (oyunaBaslaForm == null)
                oyunaBaslaForm = new OyunaBaslaForm();

            oyunaBaslaForm.Show();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            btnOnayla.Enabled = false;
            brnDigerSoru.Enabled = false;
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            lblDogruSayisi.Text = "0";
            lblYanlisSayisi.Text = "0";

            var oyunaBaslaForm = (OyunaBaslaForm)Application.OpenForms["OyunaBaslaForm"];
            if (oyunaBaslaForm == null)
                oyunaBaslaForm = new OyunaBaslaForm();

            oyunaBaslaForm.Show();
        }

        private void txtCevap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bool cevapDogrumu = false;
                var soruCevap = new SoruCevap();
                var sorununCevaplari = soruCevap.SorununCevabi();
                var verilenCevap = txtCevap.Text;
                string dogruCevaplar = "";

                foreach (var cevap in sorununCevaplari)
                {
                    if (cevap.Trim() == verilenCevap.Trim())
                        cevapDogrumu = true;
                }

                if (cevapDogrumu)
                {
                    lblDogruSayisi.Text = (Convert.ToInt32(lblDogruSayisi.Text) + 1).ToString();
                    MessageBox.Show("Cevabınız Doğru","Tebrikler");
                }
                else
                {
                    foreach (var cevap in sorununCevaplari)
                        dogruCevaplar += cevap;

                    lblYanlisSayisi.Text = (Convert.ToInt32(lblYanlisSayisi.Text) + 1).ToString();
                    MessageBox.Show("Cevabınız Yanlış! Doğru Cevap(lar) = " + dogruCevaplar, "Maalesef");
                }

                btnOnayla.Enabled = false;
                brnDigerSoru.Enabled = true;

                soruCevap.SoruyuSec();
                string soru;

                if (DosyaIcerik.Sorudili == "Türkçe")
                    soru = soruCevap.TurkceSoru();
                else if (DosyaIcerik.Sorudili == "İngilizce")
                    soru = soruCevap.IngilizceSoru();
                else
                    soru = soruCevap.KarisikSoru();

                lblKelime.Text = soru;
                btnOnayla.Enabled = true;
                brnDigerSoru.Enabled = false;
                txtCevap.Clear();
            }
        }
        //private void brnDigerSoru_Click(object sender, EventArgs e)
        //{
        //    SoruCevap soruCevap = new SoruCevap();
        //    soruCevap.SoruyuSec();
        //    string soru;

        //    if (DosyaIcerik.Sorudili == "Türkçe")
        //    {
        //        soru = soruCevap.TurkceSoru();
        //    }
        //    else if (DosyaIcerik.Sorudili == "İngilizce")
        //    {
        //        soru = soruCevap.IngilizceSoru();
        //    }
        //    else
        //    {
        //        soru = soruCevap.KarisikSoru();
        //    }

        //    lblKelime.Text = soru;
        //    btnOnayla.Enabled = true;
        //    brnDigerSoru.Enabled = false ;
        //    txtCevap.Clear();
        //}
        //////////////////////////////////////////////////////////////

        //private void btnOnayla_Click(object sender, EventArgs e)
        //{
        //    bool cevapDogrumu = false;
        //    var soruCevap = new SoruCevap();
        //    var sorununCevaplari = soruCevap.SorununCevabi();
        //    var verilenCevap = txtCevap.Text;
        //    string dogruCevaplar = "";

        //    foreach (var cevap in sorununCevaplari)
        //    {
        //        if (cevap.Trim() == verilenCevap.Trim())
        //        {
        //            cevapDogrumu = true;
        //        }
        //    }

        //    if (cevapDogrumu)
        //    {
        //        lblDogruSayisi.Text = (Convert.ToInt32(lblDogruSayisi.Text) + 1).ToString();
        //        MessageBox.Show("Cevabınız Doğru","Tebrikler");
        //    }
        //    else
        //    {
        //        foreach (var cevap in sorununCevaplari)
        //        {
        //            dogruCevaplar += cevap;
        //        }
        //        lblYanlisSayisi.Text = (Convert.ToInt32(lblYanlisSayisi.Text) + 1).ToString();
        //        MessageBox.Show("Cevabınız Yanlış! Doğru Cevap(lar) = " + dogruCevaplar, "Maalesef");
        //    }

        //    btnOnayla.Enabled = false;
        //    brnDigerSoru.Enabled = true;
        //}
    }
}
