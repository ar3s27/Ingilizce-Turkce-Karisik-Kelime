using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IngilizceRandomKelimeApp.Siniflar;
using System.IO;


namespace IngilizceRandomKelimeApp.Formlar
{
    public partial class OyunaBaslaForm : Form
    {
        private string _dosyaYolu = "";
        public OyunaBaslaForm()
        {
            InitializeComponent();
        }

        private void OyunaBaslaForm_Load(object sender, EventArgs e)
        {
            // Klasördeki tüm txt dosyalarını bulun ve bir drop listesine ekleyin
            //string folderPath = @"C:\Users\TD\Desktop\Masaüstü Programları\IngilizceRandomKelime\IngilizceRandomKelimeApp\Kelimeler";
            string uygulamaDizini = Application.StartupPath;
            string altKlasorAdi = "Kelimeler";
            string folderPath = Path.Combine(uygulamaDizini, altKlasorAdi);
            string[] txtFiles = Directory.GetFiles(folderPath, "*.txt");
            foreach (string file in txtFiles)
            {
                string fileName = Path.GetFileNameWithoutExtension(file);
                comboBox1.Items.Add(fileName);
            }
            btnOyunaBasla.Enabled = false;
            btnEkle.Enabled = false;
        }
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // comboboxtan dosya adını ve yolunu alıyoruz
            string dosyaAdi = comboBox1.SelectedItem.ToString();
            _dosyaYolu = (@"C:\Users\TD\Desktop\Masaüstü Programları\IngilizceRandomKelime\IngilizceRandomKelimeApp\Kelimeler\" + dosyaAdi + ".txt");

            //seçtiğimiz dosyaının yolunu aldıktan sonra readalltext ile içindeki verilere erişiyoruz
            string filePath = Path.Combine(@"C:\Users\TD\Desktop\Masaüstü Programları\IngilizceRandomKelime\IngilizceRandomKelimeApp\Kelimeler", dosyaAdi + ".txt");
            string fileContent = File.ReadAllText(filePath);
            btnOyunaBasla.Enabled = true;
            btnEkle.Enabled = true;

            //_dosyayolu değişkeninin değerini kontrol ediyoruz boş ise meseagebox ile gerekli bildirimi alıyoruz
            if (!string.IsNullOrEmpty(_dosyaYolu))
            {
                DosyaIcerik.Icerik = DosyaIslemleri.ReadLinesOffFile(_dosyaYolu);
                MessageBox.Show("Dosya Başarı İle Eklendi", "Tebrikler");
            }
            else MessageBox.Show("Dosya Ekleyin", "Hata");
            btnOyunaBasla.Enabled = true;
        }

        private void btnOyunaBasla_Click(object sender, EventArgs e)
        {
            if (rBtnTurkce.Checked)
                DosyaIcerik.Sorudili = "Türkçe";
            else if (rBtnIngilizce.Checked)
                DosyaIcerik.Sorudili = "İngilizce";
            else if (rBtnKarisik.Checked)
                DosyaIcerik.Sorudili = "Karışık";

            SoruCevap soruCevap = new SoruCevap();
            soruCevap.SoruyuSec();

            string soru;
            if (DosyaIcerik.Sorudili == "Türkçe")
                soru = soruCevap.TurkceSoru();
            else if (DosyaIcerik.Sorudili == "İngilizce")            
                soru = soruCevap.IngilizceSoru();          
            else
                soru = soruCevap.KarisikSoru();

            var anaForm = (AnaForm)Application.OpenForms["AnaForm"];
            anaForm.lblKelime.Text = soru;
            anaForm.btnOnayla.Enabled = true;
            this.Hide();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        //private void btnDosyaSec_Click(object sender, EventArgs e)
        //{
        //    OpenFileDialog file = new OpenFileDialog
        //    {
        //        Filter = "txt File | *.txt",
        //        Multiselect = false
        //    };

        //    if (file.ShowDialog() == DialogResult.OK)
        //    {
        //        _dosyaYolu = file.FileName;
        //        btnDosyaSec.Text = _dosyaYolu;
        //    }
        //    btnEkle.Enabled = true;
        //}

        //private void btnEkle_Click(object sender, EventArgs e)
        //{
        //    if (!string.IsNullOrEmpty(_dosyaYolu))
        //    {
        //        DosyaIcerik.Icerik = DosyaIslemleri.ReadLinesOffFile(_dosyaYolu);
        //        MessageBox.Show("Dosya Başarı İle Eklendi", "Tebrikler");
        //    }
        //    else MessageBox.Show("Dosya Ekleyin", "Hata");

        //    btnOyunaBasla.Enabled = true;
        //}
    }
}
