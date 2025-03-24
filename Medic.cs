using System;
using System.Collections.Generic;
using System.IO;

namespace ClinicaMedicala
{
    public class Medic : Persoana
    {
        public string Specializare { get; set; }
        private static string filePath = "medici.txt";  // Fișierul pentru salvare date

        // Constructorul clasei Medic
        public Medic(string nume, int varsta, string telefon, string specializare)
            : base(nume, varsta, telefon)
        {
            Specializare = specializare;
        }

        public override void AfiseazaInformatii()
        {
            base.AfiseazaInformatii();
            Console.WriteLine($"Specializare: {Specializare}");
        }

        // Citirea medicilor din fișier
        public static List<Medic> CitesteDinFisier()
        {
            List<Medic> medici = new List<Medic>();
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Fișierul de medici nu există.");
                return medici;
            }

            try
            {
                string[] linii = File.ReadAllLines(filePath);
                foreach (string linie in linii)
                {
                    string[] date = linie.Split(',');
                    if (date.Length == 4)
                    {
                        string nume = date[0].Trim();
                        int varsta = int.Parse(date[1].Trim());
                        string telefon = date[2].Trim();
                        string specializare = date[3].Trim();

                        medici.Add(new Medic(nume, varsta, telefon, specializare));
                    }
                    else
                    {
                        Console.WriteLine($"Linie invalidă: {linie}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Eroare la citirea medicilor din fișier: {ex.Message}");
            }

            return medici;
        }

        // Scrierea unui medic în fișier
        public void SalveazaInFisier()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine($"{Nume}, {Varsta}, {Telefon}, {Specializare}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Eroare la adăugarea medicului în fișier: {ex.Message}");
            }
        }
    }
}
