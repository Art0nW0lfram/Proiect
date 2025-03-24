using ClinicaMedicala;
using System.Collections.Generic;
using System;
using System.IO;

public enum SpecializareMedic
{
    Cardiologie,
    Neurologie,
    Chirurgie,
    Psihiatrie,
}

public class Medic : Persoana
{
    public SpecializareMedic Specializare { get; set; }

    public Medic(string nume, int varsta, string telefon, SpecializareMedic specializare)
        : base(nume, varsta, telefon)
    {
        Specializare = specializare;
    }

    // Citirea medicilor din fișier
    public static List<Medic> CitesteDinFisier()
    {
        List<Medic> medici = new List<Medic>();
        string path = "medici.txt"; // Fișierul din care citim medicii

        if (File.Exists(path))
        {
            foreach (var line in File.ReadLines(path))
            {
                var parts = line.Split(',');

                // Verificăm dacă avem suficiente date pentru un medic
                if (parts.Length == 4)
                {
                    string nume = parts[0];
                    int varsta = int.Parse(parts[1]);
                    string telefon = parts[2];
                    string specializareText = parts[3];

                    // Verificăm dacă specializarea este validă
                    if (Enum.TryParse(specializareText, out SpecializareMedic specializare))
                    {
                        medici.Add(new Medic(nume, varsta, telefon, specializare));
                    }
                    else
                    {
                        Console.WriteLine($"Linie invalidă (specializare greșită): {line}");
                    }
                }
                else
                {
                    Console.WriteLine($"Linie invalidă: {line}");
                }
            }
        }
        else
        {
            Console.WriteLine("Fișierul nu există.");
        }

        return medici;
    }

    // Salvarea medicilor în fișier
    public void SalveazaInFisier()
    {
        string path = "medici.txt";

        try
        {
            // Deschidem fișierul pentru a adăuga la final
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                // Verificăm dacă specializarea este validă
                if (Enum.IsDefined(typeof(SpecializareMedic), this.Specializare))
                {
                    // Salvăm medicul doar dacă specializarea este validă
                    sw.WriteLine($"{Nume},{Varsta},{Telefon},{Specializare}");
                    Console.WriteLine("Medicul a fost salvat cu succes.");
                }
                else
                {
                    Console.WriteLine($"Specializarea '{Specializare}' nu este validă. Medicul nu a fost salvat.");
                }
            }
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Eroare: Nu ai permisiunea de a salva fișierul. Verifică permisiunile fișierului.");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Eroare la salvarea fișierului: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Eroare neașteptată: {ex.Message}");
        }
    }

}
