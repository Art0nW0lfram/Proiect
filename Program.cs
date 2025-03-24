using ClinicaMedicala;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nMeniu:");
            Console.WriteLine("1. Afisează toti medicii");
            Console.WriteLine("2. Afisează toti pacientii");
            Console.WriteLine("3. Afisează toate consultatiile");
            Console.WriteLine("4. Adaugă medic");
            Console.WriteLine("5. Adaugă pacient");
            Console.WriteLine("6. Adaugă consultatie");
            Console.WriteLine("7. Iesire");
            Console.Write("Alege o optiune: ");
            string optiune = Console.ReadLine();

            switch (optiune)
            {
                case "1":
                    // Afisare medici din fișier
                    List<Medic> medici = Medic.CitesteDinFisier();
                    if (medici.Count == 0)
                    {
                        Console.WriteLine("Nu există medici în fișier.");
                    }
                    else
                    {
                        foreach (var medic in medici)
                        {
                            medic.AfiseazaInformatii();
                            Console.WriteLine("----------------------");
                        }
                    }
                    break;

                case "2":
                    // Afisare pacienți din fișier
                    List<Pacient> pacienti = Pacient.CitesteDinFisier();
                    if (pacienti.Count == 0)
                    {
                        Console.WriteLine("Nu există pacienti în fișier.");
                    }
                    else
                    {
                        foreach (var pacient in pacienti)
                        {
                            pacient.AfiseazaInformatii();
                            Console.WriteLine("----------------------");
                        }
                    }
                    break;

                case "3":
                    // Afisare consultații din fișier
                    List<Consultatie> consultatii = Consultatie.CitesteDinFisier();
                    if (consultatii.Count == 0)
                    {
                        Console.WriteLine("Nu există consultatii în fișier.");
                    }
                    else
                    {
                        foreach (var consultatie in consultatii)
                        {
                            consultatie.AfiseazaDetalii();
                            Console.WriteLine("----------------------");
                        }
                    }
                    break;

                case "4":
                    // Adaugă medic (citire de la tastatură)
                    Console.Write("Introdu numele medicului: ");
                    string numeMedic = Console.ReadLine();
                    Console.Write("Introdu vârsta medicului: ");
                    int varstaMedic = int.Parse(Console.ReadLine());
                    Console.Write("Introdu telefonul medicului: ");
                    string telefonMedic = Console.ReadLine();
                    Console.Write("Introdu specializarea medicului: Cardiologie, Neurologie, Chirurgie, Psihiatrie");
                    string specializareText = Console.ReadLine();

                    // Verificăm dacă specializarea este validă
                    if (Enum.TryParse(specializareText, out SpecializareMedic specializare))
                    {
                        Medic medicNou = new Medic(numeMedic, varstaMedic, telefonMedic, specializare);
                        medicNou.SalveazaInFisier();
                    }
                    else
                    {
                        Console.WriteLine("Specializarea introdusă nu este validă.");
                    }
                    break;


                case "5":
                    // Adaugă pacient (citire de la tastatură)
                    Console.Write("Introdu ID-ul pacientului: ");
                    int idPacient = int.Parse(Console.ReadLine());
                    Console.Write("Introdu numele pacientului: ");
                    string numePacient = Console.ReadLine();
                    Console.Write("Introdu vârsta pacientului: ");
                    int varstaPacient = int.Parse(Console.ReadLine());
                    Console.Write("Introdu telefonul pacientului: ");
                    string telefonPacient = Console.ReadLine();
                    Pacient pacientNou = new Pacient(idPacient, numePacient, varstaPacient, telefonPacient);
                    pacientNou.SalveazaInFisier();
                    break;

                case "6":
                    // Adaugă consultație (citire de la tastatură)
                    Console.Write("Introdu ID-ul pacientului pentru consultatie: ");
                    int idConsultatie = int.Parse(Console.ReadLine());
                    Console.Write("Introdu numele medicului pentru consultatie: ");
                    string numeMedicConsultatie = Console.ReadLine();
                    Console.Write("Introdu data consultatiei (dd/MM/yyyy HH:mm): ");
                    DateTime dataConsultatie = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture);
                    Consultatie consultatieNoua = new Consultatie(idConsultatie, numeMedicConsultatie, dataConsultatie);
                    consultatieNoua.SalveazaInFisier();
                    break;

                case "7":
                    Console.WriteLine("La revedere!");
                    return;

                default:
                    Console.WriteLine("Optiune invalidă. Încearcă din nou.");
                    break;
            }
        }
    }
}
