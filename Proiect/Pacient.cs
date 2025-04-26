using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace ClinicaMedicala
{
    public class Pacient : Persoana
    {
        private static readonly string filePath = "pacienti.txt";
        public int Id { get; set; }

        public Pacient(int id, string nume, int varsta, string telefon)
            : base(nume, varsta, telefon)
        {
            Id = id;
        }

        public override void AfiseazaInformatii()
        {
            Console.WriteLine($"ID: {Id}");
            base.AfiseazaInformatii();
        }

        public static List<Pacient> CitesteDinFisier()
        {
            var list = new List<Pacient>();
            if (!File.Exists(filePath)) return list;
            foreach (var linie in File.ReadAllLines(filePath))
            {
                var parts = linie.Split(',');
                if (parts.Length != 4) continue;
                if (!int.TryParse(parts[0].Trim(), out int id)) continue;
                var nume = parts[1].Trim();
                if (!int.TryParse(parts[2].Trim(), out int varsta)) continue;
                var telefon = parts[3].Trim();
                list.Add(new Pacient(id, nume, varsta, telefon));
            }
            return list;
        }

        public void SalveazaInFisier()
        {
            var linie = $"{Id},{Nume},{Varsta},{Telefon}";
            File.AppendAllText(filePath, Environment.NewLine + linie);
            Console.WriteLine("Pacient salvat cu succes.");
        }

        public static void AfiseazaToti()
        {
            var pacienti = CitesteDinFisier();
            if (!pacienti.Any()) Console.WriteLine("Nu exista pacienti.");
            else pacienti.ForEach(p => {
                p.AfiseazaInformatii();
                Console.WriteLine("----------------------");
            });
        }

        public static void AdaugaDinConsola()
        {
            int id;
            do
            {
                Console.Write("Introdu ID pacient: ");
            } while (!int.TryParse(Console.ReadLine(), out id) || id <= 0 || CitesteDinFisier().Any(p => p.Id == id));

            string nume;
            do
            {
                Console.Write("Introdu nume pacient: ");
                nume = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(nume));

            int varsta;
            do
            {
                Console.Write("Introdu varsta pacient: ");
            } while (!int.TryParse(Console.ReadLine(), out varsta) || varsta < 0);

            string telefon;
            do
            {
                Console.Write("Introdu telefonul pacientului (10 cifre): ");
                telefon = Console.ReadLine();
            } while (!Regex.IsMatch(telefon ?? "", "^\\d{10}$"));

            new Pacient(id, nume, varsta, telefon).SalveazaInFisier();
        }

        public static void CautaDupaNume()
        {
            Console.Write("Fragment nume: ");
            var frag = Console.ReadLine() ?? string.Empty;
            var found = CitesteDinFisier()
                .Where(p => p.Nume.IndexOf(frag, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();
            if (!found.Any()) Console.WriteLine("Nu s-au gasit pacienti.");
            else found.ForEach(p => {
                p.AfiseazaInformatii();
                Console.WriteLine("------");
            });
        }

        public static void EditeazaDinConsola()
        {
            Console.Write("ID pacient de editat: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("ID invalid."); return;
            }
            var pacienti = CitesteDinFisier();
            var p = pacienti.FirstOrDefault(x => x.Id == id);
            if (p == null)
            {
                Console.WriteLine("Pacientul nu a fost găsit."); return;
            }

            Console.Write($"ID ({p.Id}): ");
            var input = Console.ReadLine();
            if (int.TryParse(input, out int newId) && newId > 0) p.Id = newId;

            Console.Write($"Nume ({p.Nume}): ");
            input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input)) p.Nume = input;

            while (true)
            {
                Console.Write($"Varsta ({p.Varsta}): ");
                input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input)) break;
                if (int.TryParse(input, out int v) && v >= 0) { p.Varsta = v; break; }
                Console.WriteLine("Eroare: Varsta invalida.");
            }

            Console.Write($"Telefon ({p.Telefon}): ");
            input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input) && Regex.IsMatch(input, "^\\d{10}$"))
                p.Telefon = input;

            File.WriteAllLines(filePath,
                pacienti.Select(x => $"{x.Id},{x.Nume},{x.Varsta},{x.Telefon}"));
            Console.WriteLine("Pacientul a fost actualizat cu succes.");
        }

        public static void StergeDinFisier()
        {
            Console.Write("ID pacient de sters: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("ID invalid."); return;
            }
            var pacienti = CitesteDinFisier();
            var p = pacienti.FirstOrDefault(x => x.Id == id);
            if (p == null)
            {
                Console.WriteLine("Pacientul nu a fost găsit."); return;
            }
            pacienti.Remove(p);
            File.WriteAllLines(filePath,
                pacienti.Select(x => $"{x.Id},{x.Nume},{x.Varsta},{x.Telefon}"));
            Console.WriteLine("Pacientul a fost șters cu succes.");
        }
    }
}