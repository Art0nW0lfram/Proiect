using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System;

public class Consultatie
{
    public int PacientId { get; set; }       // Pentru a face legătura, stocăm ID-ul pacientului
    public string MedicNume { get; set; }     // Stocăm numele medicului
    public DateTime Data { get; set; }
    private static string filePath = "consultatii.txt";

    public Consultatie(int pacientId, string medicNume, DateTime data)
    {
        PacientId = pacientId;
        MedicNume = medicNume;
        Data = data;
    }

    public void AfiseazaDetalii()
    {
        Console.WriteLine($"Consultatie: Pacient ID {PacientId} cu medicul {MedicNume}");
        Console.WriteLine($"Data: {Data.ToString("dd/MM/yyyy HH:mm")}");
    }

    public void SalveazaInFisier()
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                // Format: PacientId,MedicNume,Data (data se salvează în formatul "dd/MM/yyyy HH:mm")
                writer.WriteLine($"{PacientId},{MedicNume},{Data.ToString("dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture)}");
            }
            Console.WriteLine("Consultație salvată cu succes în fișier.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Eroare la salvarea consultației: {ex.Message}");
        }
    }

    public static List<Consultatie> CitesteDinFisier()
    {
        List<Consultatie> consultatii = new List<Consultatie>();
        if (!File.Exists(filePath))
        {
            Console.WriteLine("Fișierul de consultații nu există.");
            return consultatii;
        }

        try
        {
            string[] linii = File.ReadAllLines(filePath);
            foreach (string linie in linii)
            {
                string[] date = linie.Split(',');
                if (date.Length == 3)
                {
                    int pacientId = int.Parse(date[0].Trim());
                    string medicNume = date[1].Trim();
                    DateTime data = DateTime.ParseExact(date[2].Trim(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
                    consultatii.Add(new Consultatie(pacientId, medicNume, data));
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Eroare la citirea consultațiilor: {ex.Message}");
        }
        return consultatii;
    }
}