namespace AutoKonzol
{
    internal class Program
    {
        static void Main(string[] args)
        {
             List<Auto> autos = new List<Auto>();
             using(StreamReader o = new StreamReader("../../../forras/carsData.csv"))
            {
                o.ReadLine();
                while(!o.EndOfStream)
                {
                    autos.Add(new Auto(o.ReadLine()));
                }
            }
            var f5 = autos.Where(x => x.Gyarto.GyartoName == "Rolls-Royce"
            && x.Karosszeria.KarosszeriaName == "Sedan"
            && x.HengerekSzama == 8).Count();

            Console.WriteLine($"5. Feladat - 8 hengeres, Rolls-Royce sedanok száma az adott időszakban: {f5} db");

            Console.WriteLine("6. feladat - A legdrágább autó");
            var f6 = autos.Max(x => x.Ar);
            foreach (Auto auto in autos)
            {
                if(auto.Ar == f6)
                {
                    Console.WriteLine(auto.ToString());
                    Console.Write($"\t Ára (HUF): {Math.Round(auto.Ar * 248.02, 0)}");
                }
            }
            Console.WriteLine();
            Console.WriteLine("7. feladat - Adatok fájba írása");
            var f7 = autos.Where(x => x.Gyarto.GyartoName == "Aston Martin"
            || x.Gyarto.GyartoName == "Ferrari");

            using(StreamWriter iro = new StreamWriter("../../../forras/forma-1.txt"))
            {
                foreach (Auto auto in f7)
                {
                    iro.WriteLine($"{auto.Azonosito};{auto.Gyarto.GyartoName};{auto.Modell};{auto.Evjarat};{auto.KilometeroraAllas}");
                }
            }
        }
    }
}
