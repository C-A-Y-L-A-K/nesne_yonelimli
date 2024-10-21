using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracYonetimSistemi
{
    public class Arac
    {
        public string SaseNo, Model, Marka, EdinmeTarihi;
        public int Yil, Fiyat;
        public List<string> OncekiSahibi;

        public Arac(string saseNo, string model, int yil, string marka, string edinmeTarihi, int fiyat, List<string> oncekiSahibi)
        {
            SaseNo = saseNo;
            Model = model;
            Yil = yil;
            Marka = marka;
            EdinmeTarihi = edinmeTarihi;
            Fiyat = fiyat;
            OncekiSahibi = oncekiSahibi;
        }
    }
}