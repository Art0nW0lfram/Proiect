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

    // Citirea medicilor din fisier
    public static List<Medic> CitesteDinFisier()
    {
        List<Medic> medici = new List<Medic>();
        string path = "medici.txt";

        if (!File.Exists(path))
        {
            Console.WriteLine("Fisierul medici.txt nu exista.");
            return medici;
        }

        try
        {
            string[] linii = File.ReadAllLines(path);
            for (int i = 0; i < linii.Length; i++)
            {
                string linie = linii[i].Trim();
                if (string.IsNullOrWhiteSpace(linie))
                    continue; // Ignora liniile goale

                string[] parts = linie.Split(',');
                if (parts.Length == 4)
                {
                    try
                    {
                        string nume = parts[0].Trim();
                        if (!int.TryParse(parts[1].Trim(), out int varsta))
                        {
                            Console.WriteLine($"Eroare la linia {i + 1}: Varsta '{parts[1]}' nu este un numar valid.");
                            continue;
                        }
                        string telefon = parts[2].Trim();
                        string specializareText = parts[3].Trim();

                        if (Enum.TryParse(specializareText, true, out SpecializareMedic specializare))
                        {
                            medici.Add(new Medic(nume, varsta, telefon, specializare));
                        }
                        else
                        {
                            Console.WriteLine($"Eroare la linia {i + 1}: Specializarea '{specializareText}' nu este valida.");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Eroare la procesarea liniei {i + 1}: {ex.Message}");
                    }
                }
                else
                {
                    Console.WriteLine($"Eroare la linia {i + 1}: Format invalid (se asteapta 4 campuri, gasite {parts.Length}).");
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Eroare la citirea fisierului: {ex.Message}");
        }

        return medici;
    }

    // Salvarea medicilor in fisier
    public void SalveazaInFisier()
    {
        string path = "medici.txt";

        try
        {
            // Verifica daca numele contine virgule, care ar putea strica formatul
            if (Nume.Contains(","))
            {
                Console.WriteLine("Numele medicului nu poate contine virgule.");
                return;
            }

            // Deschidem fisierul pentru a adauga la final
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                if (Enum.IsDefined(typeof(SpecializareMedic), this.Specializare))
                {
                    sw.WriteLine($"{Nume},{Varsta},{Telefon},{Specializare}");
                    Console.WriteLine("Medicul a fost salvat cu succes.");
                }
                else
                {
                    Console.WriteLine($"Specializarea '{Specializare}' nu este valida. Medicul nu a fost salvat.");
                }
            }
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Eroare: Nu ai permisiunea de a salva fisierul. Verifica permisiunile fisierului.");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Eroare la salvarea fisierului: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Eroare neasteptata: {ex.Message}");
        }
    }
    public override void AfiseazaInformatii()
    {
        // afișează întâi câmpurile de bază
        base.AfiseazaInformatii();
        // apoi specializarea
        Console.WriteLine($"Specializare: {Specializare}");
    }
}