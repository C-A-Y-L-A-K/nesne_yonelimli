using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AracYonetimSistemi;

namespace AracYonetimSistemi
{
    public class Kisi
    {
        string Ad, SoyAd, Tc;
        int DogumYili;
        List<Arac> SahipArac;

        public void KisiBelirle(string ad, string soyAd, int dogumYili, string tc)
        {
            Ad = ad;
            SoyAd = soyAd;
            DogumYili = dogumYili;
            Tc = tc;
            SahipArac = new List<Arac>();
        }

        public void AddVehicle(Arac vehicle)
        {   
             SahipArac.Add(vehicle);
        }

        public void ListVehicles()
        {
            foreach (var vehicle in SahipArac)
            {
                Console.WriteLine($"Şase Numarası: {vehicle.SaseNo}");
                Console.WriteLine($"Sahibi: {Ad} {SoyAd}");
                Console.WriteLine($"Edinme Tarihi: {vehicle.EdinmeTarihi}");
                Console.WriteLine($"Model Yılı: {vehicle.OncekiSahibi[vehicle.OncekiSahibi.Count - 1]}");
                Console.WriteLine();
            }
        }

    }
}
