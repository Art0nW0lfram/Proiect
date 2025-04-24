using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace ClinicaMedicala
{
    public enum SpecializareMedic
    {
        Cardiologie,
        Neurologie,
        Chirurgie,
        Psihiatrie
    }

    public class Medic : Persoana
    {
        private static readonly string filePath = "medici.txt";
        public SpecializareMedic Specializare { get; set; }

        public Medic(string nume, int varsta, string telefon, SpecializareMedic specializare)
            : base(nume, varsta, telefon)
        {
            Specializare = specializare;
        }

        public override void AfiseazaInformatii()
        {
            base.AfiseazaInformatii();
            Console.WriteLine($"Specializare: {Specializare}");
        }

        public static List<Medic> CitesteDinFisier()
        {
            var medici = new List<Medic>();
            if (!File.Exists(filePath)) return medici;

            foreach (var linie in File.ReadAllLines(filePath))
            {
                var parts = linie.Split(',');
                if (parts.Length != 4) continue;
                var nume = parts[0].Trim();
                if (!int.TryParse(parts[1].Trim(), out int varsta)) continue;
                var telefon = parts[2].Trim();
                if (!Enum.TryParse(parts[3].Trim(), true, out SpecializareMedic spec)) continue;

                medici.Add(new Medic(nume, varsta, telefon, spec));
            }
            return medici;
        }

        public void SalveazaInFisier()
        {
            var linie = $"{Nume},{Varsta},{Telefon},{Specializare}";
            File.AppendAllText(filePath, Environment.NewLine + linie);
            Console.WriteLine("Medicul a fost salvat cu succes.");
        }

        public static void AfiseazaToti()
        {
            var medici = CitesteDinFisier();
            if (!medici.Any()) Console.WriteLine("Nu exista medici.");
            else medici.ForEach(m => {
                m.AfiseazaInformatii();
                Console.WriteLine("----------------------");
            });
        }

        public static void AdaugaDinConsola()
        {
            Console.Write("Introdu numele medicului: ");
            var nume = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(nume)) { Console.WriteLine("Nume invalid."); return; }

            Console.Write("Introdu varsta medicului: ");
            if (!int.TryParse(Console.ReadLine(), out int varsta) || varsta < 0)
            { Console.WriteLine("Varsta invalida."); return; }

            Console.Write("Introdu telefon (10 cifre): ");
            var telefon = Console.ReadLine();
            if (!Regex.IsMatch(telefon ?? "", "^\\d{10}$"))
            { Console.WriteLine("Telefon invalid."); return; }

            Console.Write("Introdu specializarea (Cardiologie, Neurologie, Chirurgie, Psihiatrie): ");
            if (!Enum.TryParse(Console.ReadLine(), true, out SpecializareMedic spec))
            { Console.WriteLine("Specializare invalida."); return; }

            new Medic(nume, varsta, telefon, spec).SalveazaInFisier();
        }

        public static void CautaDupaNume()
        {
            Console.Write("Fragment nume: ");
            var frag = Console.ReadLine() ?? string.Empty;
            var found = CitesteDinFisier()
                .Where(m => m.Nume.IndexOf(frag, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
            if (!found.Any()) Console.WriteLine("Nu s-au gasit medici.");
            else found.ForEach(m => {
                m.AfiseazaInformatii(); Console.WriteLine("------");
            });
        }
    }
}