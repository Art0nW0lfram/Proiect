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
        Psihiatrie,
        MedicinaGenerala
    }

    public class Medic : Persoana
    {
        private static readonly string filePath = "medici.txt";
        public SpecializareMedic Specializare { get; set; }
        public TimeSpan OraStart { get; set; }
        public TimeSpan OraEnd { get; set; }

        public Medic(string nume, int varsta, string telefon,
                     SpecializareMedic specializare,
                     TimeSpan oraStart, TimeSpan oraEnd)
            : base(nume, varsta, telefon)
        {
            Specializare = specializare;
            OraStart = oraStart;
            OraEnd = oraEnd;
        }

        public override void AfiseazaInformatii()
        {
            base.AfiseazaInformatii();
            Console.WriteLine($"Specializare: {Specializare}");
            Console.WriteLine($"Disponibil: {OraStart:hh\\:mm}–{OraEnd:hh\\:mm}\n");
        }

        public static List<Medic> CitesteDinFisier()
        {
            var medici = new List<Medic>();
            if (!File.Exists(filePath)) return medici;

            foreach (var linie in File.ReadAllLines(filePath))
            {
                var p = linie.Split(',');
                if (p.Length == 4)
                {
                    // format vechi → interval implicit 09:00–17:00
                    var start = TimeSpan.Parse("09:00");
                    var end = TimeSpan.Parse("17:00");
                    var nume = p[0].Trim();
                    if (!int.TryParse(p[1].Trim(), out int varsta)) continue;
                    var telefon = p[2].Trim();
                    if (!Enum.TryParse(p[3].Trim(), true, out SpecializareMedic spec)) continue;
                    medici.Add(new Medic(nume, varsta, telefon, spec, start, end));
                }
                else if (p.Length == 6)
                {
                    var nume = p[0].Trim();
                    if (!int.TryParse(p[1].Trim(), out int varsta)) continue;
                    var telefon = p[2].Trim();
                    if (!Enum.TryParse(p[3].Trim(), true, out SpecializareMedic spec)) continue;
                    if (!TimeSpan.TryParse(p[4].Trim(), out TimeSpan start)) continue;
                    if (!TimeSpan.TryParse(p[5].Trim(), out TimeSpan end)) continue;
                    medici.Add(new Medic(nume, varsta, telefon, spec, start, end));
                }
            }
            return medici;
        }

        public void SalveazaInFisier()
        {
            var linie = $"{Nume},{Varsta},{Telefon},{Specializare},{OraStart:hh\\:mm},{OraEnd:hh\\:mm}";
            var prefix = File.Exists(filePath) ? Environment.NewLine : string.Empty;
            File.AppendAllText(filePath, prefix + linie);
            Console.WriteLine("Medicul a fost salvat cu succes.");
        }

        public static void AfiseazaToti()
        {
            var lista = CitesteDinFisier();
            if (!lista.Any())
            {
                Console.WriteLine("Nu exista medici.");
                return;
            }
            foreach (var m in lista)
            {
                m.AfiseazaInformatii();
                Console.WriteLine("----------------------");
            }
        }

        public static void AdaugaDinConsola()
        {
            // Nume
            string nume;
            do
            {
                Console.Write("Introdu numele medicului: ");
                nume = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(nume));

            // Vârsta
            int varsta;
            do
            {
                Console.Write("Introdu varsta medicului: ");
            } while (!int.TryParse(Console.ReadLine(), out varsta) || varsta < 0);

            // Telefon
            string telefon;
            do
            {
                Console.Write("Introdu telefon (10 cifre): ");
                telefon = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(telefon) || !Regex.IsMatch(telefon, @"^\d{10}$"));

            // Specializare
            SpecializareMedic spec;
            do
            {
                Console.Write("Introdu specializarea (Cardiologie, Neurologie, Chirurgie, Psihiatrie, MedicinaGenerala): ");
            } while (!Enum.TryParse(Console.ReadLine(), true, out spec) || !Enum.IsDefined(typeof(SpecializareMedic), spec));

            // Interval orar
            TimeSpan start, end;
            do
            {
                Console.Write("Ora start (HH:mm): ");
            } while (!TimeSpan.TryParse(Console.ReadLine(), out start));
            do
            {
                Console.Write("Ora end (HH:mm): ");
            } while (!TimeSpan.TryParse(Console.ReadLine(), out end) || end <= start);

            new Medic(nume, varsta, telefon, spec, start, end).SalveazaInFisier();
        }

        public static void CautaDupaNume()
        {
            Console.Write("Fragment nume: ");
            var frag = Console.ReadLine() ?? string.Empty;
            var found = CitesteDinFisier()
                .Where(m => m.Nume.IndexOf(frag, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
            if (!found.Any())
            {
                Console.WriteLine("Nu s-au gasit medici.");
                return;
            }
            foreach (var m in found)
            {
                m.AfiseazaInformatii();
                Console.WriteLine("------");
            }
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
                if (int.TryParse(input, out var v) && v >= 0) { m.Varsta = v; break; }
                Console.WriteLine("Eroare: varsta invalidă.");
            }

            Console.Write($"Telefon ({m.Telefon}): ");
            input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input) && Regex.IsMatch(input, @"^\d{10}$"))
                m.Telefon = input;

            while (true)
            {
                Console.Write($"Specializare ({m.Specializare}): ");
                input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input)) break;
                if (Enum.TryParse(input, true, out SpecializareMedic ns)) { m.Specializare = ns; break; }
                Console.WriteLine("Eroare: specializare invalidă.");
            }

            while (true)
            {
                Console.Write($"Ora start ({m.OraStart:hh\\:mm}): ");
                input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input)) break;
                if (TimeSpan.TryParse(input, out TimeSpan s)) { m.OraStart = s; break; }
                Console.WriteLine("Eroare: format ora invalid.");
            }

            while (true)
            {
                Console.Write($"Ora end ({m.OraEnd:hh\\:mm}): ");
                input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input)) break;
                if (TimeSpan.TryParse(input, out TimeSpan e) && e > m.OraStart) { m.OraEnd = e; break; }
                Console.WriteLine("Eroare: ora end trebuie sa fie dupa start.");
            }

            // Rescriem fișierul păstrând intervalul orar
            File.WriteAllLines(filePath,
                medici.Select(x =>
                    $"{x.Nume},{x.Varsta},{x.Telefon},{x.Specializare},{x.OraStart:hh\\:mm},{x.OraEnd:hh\\:mm}"
                )
            );
            Console.WriteLine("Medicul a fost actualizat.");
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
            // Rescriem fișierul păstrând intervalul orar
            File.WriteAllLines(filePath,
                medici.Select(x =>
                    $"{x.Nume},{x.Varsta},{x.Telefon},{x.Specializare},{x.OraStart:hh\\:mm},{x.OraEnd:hh\\:mm}"
                )
            );
            Console.WriteLine("Medicul a fost sters.");
        }
    }
}
