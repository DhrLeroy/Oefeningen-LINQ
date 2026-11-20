using System;
using System.Collections.Generic;
using System.Text;

namespace Zonnestelsel___Select__SelectMany__Where
{

    public class Hemellichaam
    {
        public string Naam { get; set; }
        public double? DiameterInKm { get; set; }
        public double? GemiddeldeStraalInKm { get; set; }

    }
    public class Planeet : Hemellichaam
    {
        public string VolledigeNaam { get; set; }
        public int HorizonsNummer { get; set; }
        public double OmlooptijdInDagen { get; set; }

        public List<Maan> Manen { get; set; } = new List<Maan>();

        public Planeet(string csvRegel)
        {
            string[] gegevens = csvRegel.Split(',');

            Naam = gegevens[0];
            VolledigeNaam = gegevens[1];
            DiameterInKm = gegevens[2].ParseGetal();
            GemiddeldeStraalInKm = gegevens[3].ParseGetal(); ;
            HorizonsNummer = int.Parse(gegevens[6]);
            OmlooptijdInDagen = gegevens[8].ParseGetal(); ;
        }
    }

    public class Maan : Hemellichaam
    {
        public string Naam { get; set; }
        public string NaamZonderHoofdletters { get; set; }
        //public int HorizonsNummer { get; set; }
        public int Volgnummer { get; set; }
        public Planeet Planeet { get; set; }

        public Maan(string csvRegel, Dictionary<string, Planeet> planeten)
        {
            string[] gegevens = csvRegel.Split(',');

            Naam = gegevens[0];
            NaamZonderHoofdletters = gegevens[1];
            //HorizonsNummer = int.Parse(gegevens[2]);
            GemiddeldeStraalInKm = gegevens[3].ParseOptioneelGetal();
            DiameterInKm = gegevens[4].ParseOptioneelGetal();
            Volgnummer = int.Parse(gegevens[8]);
            var naamPlaneet = gegevens[7];
            Planeet = planeten[naamPlaneet];
            Planeet.Manen.Add(this);
        }
    }

    public class Asteroide : Hemellichaam
    {
        public string Id { get; set; }
        public int Catalogusnummer { get; set; }
        public string VolledigeNaam { get; set; }
        public string OfficieelNummer { get; set; }
        public bool IsAardebaanKruisend { get; set; }
        public bool IsPotentieelGevaarlijk { get; set; }
        public string? NaamVoorvoegsel { get; set; }
        public double PeriheliumInAE { get; set; }
        public double? OmlooptijdInDagen { get; set; }
        public string Type { get; set; }

        public Asteroide(string csvRegel)
        {
            string[] gegevens = csvRegel.Split(',');

            Id = gegevens[0];
            Catalogusnummer = int.Parse(gegevens[1].Trim());
            VolledigeNaam = gegevens[2].Trim().Trim('"');
            OfficieelNummer = gegevens[3];
            Naam = gegevens[4];
            IsAardebaanKruisend = gegevens[5] == "Y";
            IsPotentieelGevaarlijk = gegevens[6] == "Y";
            DiameterInKm = gegevens[7].ParseOptioneelGetal();
            NaamVoorvoegsel = gegevens[8];
            PeriheliumInAE = gegevens[9].StartsWith(".") ? double.Parse($"0{gegevens[9]}") : double.Parse(gegevens[9]);
            OmlooptijdInDagen = gegevens[10].ParseOptioneelGetal();
            Type = gegevens[11];
            GemiddeldeStraalInKm = DiameterInKm / 2;
        }
    }

    public static class ExtensionMethods
    {
        public static double? ParseOptioneelGetal(this string waarde)
        {
            string opgeschoond = string.Concat(
                waarde.Where(c => !char.IsWhiteSpace(c)));

            if (string.IsNullOrWhiteSpace(opgeschoond))
                return null;

            return double.Parse(
                opgeschoond,
                System.Globalization.CultureInfo.InvariantCulture);
        }

        public static double ParseGetal(this string waarde)
        {
            string opgeschoond = string.Concat(
                waarde.Where(c => !char.IsWhiteSpace(c)));

            return double.Parse(
                opgeschoond,
                System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}