using System;
using System.Collections.Generic;
using System.Text;

namespace AutoKonzol
{
    internal class Auto
    {
        public Auto(string l)
        {
            var r = l.Split(";");
            Azonosito = int.Parse(r[0]);
            Evjarat = int.Parse(r[1]);
            Gyarto = new Gyarto()
            {
                GyartoID = int.Parse(r[2]),
                GyartoName = r[3]
            };
            Modell = r[4];
            KilometeroraAllas = int.Parse(r[5]);
            Karosszeria = new Karosszeria()
            {
                KarosszeriaID = int.Parse(r[6]),
                KarosszeriaName = r[7]
            };
            HengerekSzama = int.Parse(r[8]);
            Valto = new Valto()
            {
                ValtoID = int.Parse(r[9]),
                ValtoName = r[10]
            };
            KulsoSzin = r[11];
            BelsoSzin = r[12];
            SzemelyekSzama = int.Parse(r[13]);
            Ajtok = int.Parse(r[14]);
            FogyasztasVarosban = double.Parse(r[15]);
            FogyasztasAutopalyan = double.Parse(r[16]);
            Ar = double.Parse(r[17]);
        }

        public int Azonosito { get; set; }
        public int Evjarat { get; set; }
        public Gyarto Gyarto { get; set; }
        public string Modell { get; set; }
        public int KilometeroraAllas { get; set; }
        public Karosszeria Karosszeria { get; set; }
        public int HengerekSzama { get; set; }
        public Valto Valto { get; set; }
        public string KulsoSzin { get; set; }
        public string BelsoSzin { get; set; }
        public int SzemelyekSzama { get; set; }
        public int Ajtok { get; set; }
        public double FogyasztasVarosban { get; set; }
        public double FogyasztasAutopalyan { get; set; }
        public double Ar { get; set; }

        public override string ToString()
        {
            return $"{Azonosito}. autó:\n" +
                $"\t Gyártó - modell: {Gyarto.GyartoName} - {Modell}\n" +
                $"\t Fogyasztás: {Math.Round((FogyasztasVarosban + FogyasztasAutopalyan)/2, 2)}\n" +
                $"\t Kilométer állása: {KilometeroraAllas} km\n" +
                $"\t Váltó típusa: {Valto.ValtoName}\n" +
                $"\t Ára (CAD): {Ar}";
        }
    }
}
