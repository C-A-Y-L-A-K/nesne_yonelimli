using System;
using System.Collections.Generic;

namespace AracYonetimSistemi
{
    class Program
    {
        static void Main(string[] args)
        {
            Kisi Kisi_1 = new Kisi();
            Kisi_1.KisiBelirle("Abdussamed", "İlhan", 2005, "12345678901");

            Arac arac_1 = new Arac("A1B2C3", "Mercedes", 2024, "Mercedes", "01.01.2024", 5000000, new List<string> { "Kisi_1", "Kisi_2", "Kisi_3" });
            Arac arac_2 = new Arac("D445F4", "Nssan", 2001, "Ford", "12.02.2023", 400000, new List<string> { "Kisi_1", "Kisi_2", "Kisi_3", "Kisi_4" });
            Arac arac_3 = new Arac("GAHIA0", "BMW", 2002, "BMW", "03.08.2013", 600000, new List<string> { "Kiis_1", "Kisi_2", "Kisi_3", "Kisi_4", "Kisi_5" });
            Arac arac_4 = new Arac("88K2L3", "Toyota", 2018, "Toyota", "02.04.2020", 300000, new List<string> { "Kisi_1", "Kisi_2" });

            Kisi_1.AddVehicle(arac_1);
            Kisi_1.AddVehicle(arac_2);
            Kisi_1.AddVehicle(arac_3);
            Kisi_1.AddVehicle(arac_4);

            Kisi_1.ListVehicles();
        }
    }
}
