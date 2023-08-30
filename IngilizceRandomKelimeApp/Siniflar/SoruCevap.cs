using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IngilizceRandomKelimeApp.Siniflar
{
    public class SoruCevap
    {
        private static string _satir;
        private static string _soruTipi;
        private Random _random;

        public SoruCevap()
        {
            _random = new Random();
        }

        public void SoruyuSec()
        {
            _satir = DosyaIcerik.Icerik[_random.Next(0, DosyaIcerik.Icerik.Count)];
        }

        public string TurkceSoru()
        {
            var turkceSoru = _satir.Split('+')[1];
            turkceSoru = KelimeleriBol(turkceSoru);
            _soruTipi = "Türkçe";
            return turkceSoru;
        }

        public string IngilizceSoru()
        {
            var ingilizceSoru = _satir.Split('+')[0];
            ingilizceSoru = KelimeleriBol(ingilizceSoru);
            _soruTipi = "İngilizce";
            return ingilizceSoru;
        }

        public string KarisikSoru()
        {
            var randomSayi = _random.Next(0,2);
            var karisikSoru = _satir.Split('+')[randomSayi];
            karisikSoru = KelimeleriBol(karisikSoru);
            if (randomSayi == 0)
                _soruTipi = "İngilizce";
            else _soruTipi = "Türkçe";
            return karisikSoru;
        }

        public string KelimeleriBol(string kelimeler)
        {            
            var BolunmusKelime = kelimeler.Split(',');
            var kelime = "";
            if (BolunmusKelime.Length > 1)
                kelime = BolunmusKelime[_random.Next(0, 2)];
            else
                kelime = BolunmusKelime[0];
            return kelime; 
        }

        public string[] SorununCevabi()
        {
            string cevap = "";
            if (_soruTipi == "Türkçe")
                cevap = _satir.Split('+')[0];
            else
                cevap = _satir.Split('+')[1];
            return cevap.Split(',');
        }
    }
}
