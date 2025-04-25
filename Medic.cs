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
            // Citire nume
            string nume;
            do
            {
                Console.Write("Introdu numele medicului: ");
                nume = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(nume)) Console.WriteLine("Nume invalid.");
            } while (string.IsNullOrWhiteSpace(nume));

            // Citire varsta
            int varsta;
            do
            {
                Console.Write("Introdu varsta medicului: ");
            } while (!int.TryParse(Console.ReadLine(), out varsta) || varsta < 0);

            // Citire telefon
            string telefon;
            do
            {
                Console.Write("Introdu telefonul medicului (10 cifre): ");
                telefon = Console.ReadLine();
            } while (!Regex.IsMatch(telefon ?? "", "^\\d{10}$"));

            // Citire specializare
            SpecializareMedic spec;
            do
            {
                Console.Write("Introdu specializarea medicului (Cardiologie, Neurologie, Chirurgie, Psihiatrie): ");
            } while (!Enum.TryParse(Console.ReadLine(), true, out spec) || !Enum.IsDefined(typeof(SpecializareMedic), spec));

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
                m.AfiseazaInformatii();
                Console.WriteLine("------");
            });
        }

        public static void EditeazaDinConsola()
        {
            Console.Write("Nume medic de editat: ");
            var nume = Console.ReadLine();
            var medici = CitesteDinFisier();
            var m = medici.FirstOrDefault(x => x.Nume.Equals(nume, StringComparison.OrdinalIgnoreCase));
            if (m == null)
            {
                Console.WriteLine("Medicul nu a fost găsit.");
                return;
            }

            Console.Write($"Nume ({m.Nume}): ");
            var input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input)) m.Nume = input;

            while (true)
            {
                Console.Write($"Varsta ({m.Varsta}): ");
                input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input)) break;
                if (int.TryParse(input, out var v) && v >= 0)
                {
                    m.Varsta = v;
                    break;
                }
                Console.WriteLine("Eroare: Varsta trebuie sa fie un numar >= 0.");
            }

            Console.Write($"Telefon ({m.Telefon}): ");
            input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input) && Regex.IsMatch(input, "^\\d{10}$"))
                m.Telefon = input;

            while (true)
            {
                Console.Write($"Specializare ({m.Specializare}): ");
                input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input)) break;
                if (Enum.TryParse(input, true, out SpecializareMedic newSpec))
                {
                    m.Specializare = newSpec;
                    break;
                }
                Console.WriteLine("Eroare: Specializare invalida.");
            }

            File.WriteAllLines(filePath,
                medici.Select(x => $"{x.Nume},{x.Varsta},{x.Telefon},{x.Specializare}"));
            Console.WriteLine("Medicul a fost actualizat cu succes.");
        }

        public static void StergeDinFisier()
        {
            Console.Write("Nume medic de sters: ");
            var nume = Console.ReadLine();
            var medici = CitesteDinFisier();
            var m = medici.FirstOrDefault(x => x.Nume.Equals(nume, StringComparison.OrdinalIgnoreCase));
            if (m == null)
            {
                Console.WriteLine("Medicul nu a fost găsit.");
                return;
            }
            medici.Remove(m);
            File.WriteAllLines(filePath,
                medici.Select(x => $"{x.Nume},{x.Varsta},{x.Telefon},{x.Specializare}"));
            Console.WriteLine("Medicul a fost șters cu succes.");
        }
    }
}