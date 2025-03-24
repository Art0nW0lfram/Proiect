using ClinicaMedicala;
using System.Collections.Generic;
using System.IO;
using System;

public class Pacient : Persoana
{
    public int Id { get; set; }
    private static string filePath = "pacienti.txt";

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

    public void SalveazaInFisier()
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                // Format: Id,Nume,Varsta,Telefon
                writer.WriteLine($"{Id},{Nume},{Varsta},{Telefon}");
            }
            Console.WriteLine("Pacient salvat cu succes în fișier.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Eroare la salvarea pacientului: {ex.Message}");
        }
    }

    public static List<Pacient> CitesteDinFisier()
    {
        List<Pacient> pacienti = new List<Pacient>();
        if (!File.Exists(filePath))
        {
            Console.WriteLine("Fișierul de pacienți nu există.");
            return pacienti;
        }

        try
        {
            string[] linii = File.ReadAllLines(filePath);
            foreach (string linie in linii)
            {
                string[] date = linie.Split(',');
                if (date.Length == 4)
                {
                    int id = int.Parse(date[0].Trim());
                    string nume = date[1].Trim();
                    int varsta = int.Parse(date[2].Trim());
                    string telefon = date[3].Trim();
                    pacienti.Add(new Pacient(id, nume, varsta, telefon));
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Eroare la citirea pacienților: {ex.Message}");
        }
        return pacienti;
    }
}