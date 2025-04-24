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
            Console.WriteLine($"Consultatie: pacient {PacientId} cu {MedicNume}");
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
                if (!DateTime.TryParseExact(parts[2].Trim(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dt)) continue;

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
                c.AfiseazaDetalii(); Console.WriteLine("----------------------");
            });
        }

        public static void AdaugaDinConsola()
        {
            Console.Write("Introdu ID pacient: ");
            if (!int.TryParse(Console.ReadLine(), out int pid) || !Pacient.CitesteDinFisier().Any(p => p.Id == pid))
            { Console.WriteLine("ID invalid sau inexistent."); return; }

            Console.Write("Introdu nume medic: ");
            var medic = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(medic) || !Medic.CitesteDinFisier().Any(m => m.Nume.Equals(medic, StringComparison.OrdinalIgnoreCase)))
            { Console.WriteLine("Medic invalid."); return; }

            Console.Write("Introdu data (dd/MM/yyyy HH:mm): ");
            if (!DateTime.TryParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime dt))
            { Console.WriteLine("Format data invalid."); return; }

            new Consultatie(pid, medic, dt).SalveazaInFisier();
        }

        public static void CautaDupaId()
        {
            Console.Write("ID pacient: ");
            if (!int.TryParse(Console.ReadLine(), out int pid))
            { Console.WriteLine("ID invalid."); return; }

            var found = CitesteDinFisier().Where(c => c.PacientId == pid).ToList();
            if (!found.Any()) Console.WriteLine("Nu s-au gasit consultatii.");
            else found.ForEach(c => { c.AfiseazaDetalii(); Console.WriteLine("------"); });
        }
    }
}