using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace ClinicaMedicala
{
    public class Consultatie
    {
        private static readonly string filePath = "consultatii.txt";
        public int PacientId { get; set; }
        public string MedicNume { get; set; }
        public DateTime Data { get; set; }

        public Consultatie(int pacientId, string medicNume, DateTime data)
        {
            PacientId = pacientId;
            MedicNume = medicNume;
            Data = data;
        }

        public void AfiseazaDetalii()
        {
            Console.WriteLine($"Consultatie: Pacient ID {PacientId} cu medicul {MedicNume}");
            Console.WriteLine($"Data: {Data:dd/MM/yyyy HH:mm}");
        }

        public static List<Consultatie> CitesteDinFisier()
        {
            var list = new List<Consultatie>();
            if (!File.Exists(filePath)) return list;
            foreach (var linie in File.ReadAllLines(filePath))
            {
                var parts = linie.Split(',');
                if (parts.Length != 3) continue;
                if (!int.TryParse(parts[0].Trim(), out int pid)) continue;
                var medic = parts[1].Trim();
                if (!DateTime.TryParseExact(parts[2].Trim(), "dd/MM/yyyy HH:mm",
                    CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dt)) continue;
                list.Add(new Consultatie(pid, medic, dt));
            }
            return list;
        }

        public void SalveazaInFisier()
        {
            var linie = $"{PacientId},{MedicNume},{Data:dd/MM/yyyy HH:mm}";
            File.AppendAllText(filePath, Environment.NewLine + linie);
            Console.WriteLine("Consultatie salvata cu succes.");
        }

        public static void AfiseazaToate()
        {
            var consultatii = CitesteDinFisier();
            if (!consultatii.Any()) Console.WriteLine("Nu exista consultatii.");
            else consultatii.ForEach(c => {
                c.AfiseazaDetalii();
                Console.WriteLine("----------------------");
            });
        }

        public static void AdaugaDinConsola()
        {
            int pid;
            do
            {
                Console.Write("Introdu ID pacient: ");
            } while (!int.TryParse(Console.ReadLine(), out pid) || !Pacient.CitesteDinFisier().Any(p => p.Id == pid));

            string medic;
            do
            {
                Console.Write("Introdu nume medic: ");
                medic = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(medic) || !Medic.CitesteDinFisier().Any(m => m.Nume.Equals(medic, StringComparison.OrdinalIgnoreCase)));

            DateTime dt;
            do
            {
                Console.Write("Introdu data (dd/MM/yyyy HH:mm): ");
            } while (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm",
                     CultureInfo.InvariantCulture, DateTimeStyles.None, out dt));

            new Consultatie(pid, medic, dt).SalveazaInFisier();
        }

        public static void CautaDupaId()
        {
            Console.Write("ID pacient: ");
            if (!int.TryParse(Console.ReadLine(), out int pid))
            {
                Console.WriteLine("ID invalid."); return;
            }
            var found = CitesteDinFisier().Where(c => c.PacientId == pid).ToList();
            if (!found.Any()) Console.WriteLine("Nu s-au gasit consultatii.");
            else found.ForEach(c => {
                c.AfiseazaDetalii();
                Console.WriteLine("------");
            });
        }

        public static void EditeazaDinConsola()
        {
            Console.Write("ID pacient (cheie): ");
            if (!int.TryParse(Console.ReadLine(), out int pidKey)) { Console.WriteLine("ID invalid."); return; }
            Console.Write("Nume medic (cheie): ");
            var numeKey = Console.ReadLine();
            DateTime dataKey;
            do
            {
                Console.Write("Data consultatie (cheie, dd/MM/yyyy HH:mm): ");
            } while (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm",
                     CultureInfo.InvariantCulture, DateTimeStyles.None, out dataKey));

            var consultatii = CitesteDinFisier();
            var c = consultatii.FirstOrDefault(x =>
                x.PacientId == pidKey &&
                x.MedicNume.Equals(numeKey, StringComparison.OrdinalIgnoreCase) &&
                x.Data == dataKey);
            if (c == null)
            {
                Console.WriteLine("Consultatia nu a fost gasita.");
                return;
            }

            Console.Write($"PacientId ({c.PacientId}): ");
            var input = Console.ReadLine();
            if (int.TryParse(input, out int newPid)) c.PacientId = newPid;

            Console.Write($"MedicNume ({c.MedicNume}): ");
            input = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(input)) c.MedicNume = input;

            while (true)
            {
                Console.Write($"Data ({c.Data:dd/MM/yyyy HH:mm}): ");
                input = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(input)) break;
                if (DateTime.TryParseExact(input, "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime newDt))
                {
                    c.Data = newDt;
                    break;
                }
                Console.WriteLine("Format data invalid.");
            }

            File.WriteAllLines(filePath,
                consultatii.Select(x => $"{x.PacientId},{x.MedicNume},{x.Data:dd/MM/yyyy HH:mm}"));
            Console.WriteLine("Consultatia a fost actualizata cu succes.");
        }

        public static void StergeDinFisier()
        {
            Console.Write("ID pacient: ");
            if (!int.TryParse(Console.ReadLine(), out int pidKey)) { Console.WriteLine("ID invalid."); return; }
            Console.Write("Nume medic: ");
            var numeKey = Console.ReadLine();
            DateTime dataKey;
            do
            {
                Console.Write("Data consultatie (dd/MM/yyyy HH:mm): ");
            } while (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm",
                     CultureInfo.InvariantCulture, DateTimeStyles.None, out dataKey));

            var consultatii = CitesteDinFisier();
            var c = consultatii.FirstOrDefault(x => x.PacientId == pidKey && x.MedicNume.Equals(numeKey, StringComparison.OrdinalIgnoreCase) && x.Data == dataKey);
            if (c == null)
            {
                Console.WriteLine("Consultatia nu a fost gasita.");
                return;
            }
            consultatii.Remove(c);
            File.WriteAllLines(filePath,
                consultatii.Select(x => $"{x.PacientId},{x.MedicNume},{x.Data:dd/MM/yyyy HH:mm}"));
            Console.WriteLine("Consultatia a fost stearsa cu succes.");
        }
    }
}