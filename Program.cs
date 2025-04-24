using ClinicaMedicala;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nMeniu:");
            Console.WriteLine("1. Afiseaza toti medicii");
            Console.WriteLine("2. Afiseaza toti pacientii");
            Console.WriteLine("3. Afiseaza toate consultarile");
            Console.WriteLine("4. Adauga medic");
            Console.WriteLine("5. Adauga pacient");
            Console.WriteLine("6. Adauga consultatie");
            Console.WriteLine("7. Iesire");
            Console.WriteLine("8. Cauta medic dupa nume");
            Console.WriteLine("9. Cauta pacient dupa nume");
            Console.WriteLine("10. Cauta consultatii dupa ID pacient");
            Console.Write("Alege o optiune: ");
            string optiune = Console.ReadLine();

            switch (optiune)
            {
                case "1":
                    AfiseazaMedici();
                    break;
                case "2":
                    AfiseazaPacienti();
                    break;
                case "3":
                    AfiseazaConsultatii();
                    break;
                case "4":
                    AdaugaMedic();
                    break;
                case "5":
                    AdaugaPacient();
                    break;
                case "6":
                    AdaugaConsultatie();
                    break;
                case "7":
                    Console.WriteLine("La revedere!");
                    return;
                case "8":
                    CautaMedicDupaNume();
                    break;
                case "9":
                    CautaPacientDupaNume();
                    break;
                case "10":
                    CautaConsultatiiDupaId();
                    break;
                default:
                    Console.WriteLine("Optiune invalida. Incearca din nou.");
                    break;
            }
        }
    }

    static void AfiseazaMedici()
    {
        var medici = Medic.CitesteDinFisier();
        if (!medici.Any())
            Console.WriteLine("Nu exista medici in fisier.");
        else
        {
            foreach (var medic in medici)
            {
                medic.AfiseazaInformatii();
                Console.WriteLine("----------------------");
            }
        }
    }

    static void AfiseazaPacienti()
    {
        var pacienti = Pacient.CitesteDinFisier();
        if (!pacienti.Any())
            Console.WriteLine("Nu exista pacienti in fisier.");
        else
        {
            foreach (var p in pacienti)
            {
                p.AfiseazaInformatii();
                Console.WriteLine("----------------------");
            }
        }
    }

    static void AfiseazaConsultatii()
    {
        var consultatii = Consultatie.CitesteDinFisier();
        if (!consultatii.Any())
            Console.WriteLine("Nu exista consultatii in fisier.");
        else
        {
            foreach (var c in consultatii)
            {
                c.AfiseazaDetalii();
                Console.WriteLine("----------------------");
            }
        }
    }

    static void AdaugaMedic()
    {
        Console.Write("Introdu numele medicului: ");
        var nume = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(nume))
        {
            Console.WriteLine("Numele nu poate fi gol.");
            return;
        }
        int varsta;
        while (!int.TryParse(Prompt("Introdu varsta medicului: "), out varsta) || varsta < 0)
            Console.WriteLine("Varsta trebuie sa fie un numar nenegativ.");

        string telefon;
        while (!EsteTelefonValid(telefon = Prompt("Introdu telefonul medicului (10 cifre): ")))
            Console.WriteLine("Telefonul trebuie sa aiba exact 10 cifre.");

        SpecializareMedic spec;
        while (!Enum.TryParse(Prompt("Introdu specializarea medicului (Cardiologie, Neurologie, Chirurgie, Psihiatrie): "), true, out spec)
               || !Enum.IsDefined(typeof(SpecializareMedic), spec))
        {
            Console.WriteLine("Specializare invalida.");
        }

        new Medic(nume, varsta, telefon, spec).SalveazaInFisier();
    }

    static void AdaugaPacient()
    {
        int id;
        while (!int.TryParse(Prompt("Introdu ID-ul pacientului: "), out id) || id <= 0 || Pacient.CitesteDinFisier().Any(p => p.Id == id))
            Console.WriteLine("ID invalid sau duplicat.");

        var nume = Prompt("Introdu numele pacientului: ");
        if (string.IsNullOrWhiteSpace(nume))
        {
            Console.WriteLine("Numele nu poate fi gol.");
            return;
        }

        int varsta;
        while (!int.TryParse(Prompt("Introdu varsta pacientului: "), out varsta) || varsta < 0)
            Console.WriteLine("Varsta trebuie sa fie un numar nenegativ.");

        string telefon;
        while (!EsteTelefonValid(telefon = Prompt("Introdu telefonul pacientului (10 cifre): ")))
            Console.WriteLine("Telefonul trebuie sa aiba exact 10 cifre.");

        new Pacient(id, nume, varsta, telefon).SalveazaInFisier();
    }

    static void AdaugaConsultatie()
    {
        int pid;
        while (!int.TryParse(Prompt("Introdu ID-ul pacientului pentru consultatie: "), out pid)
               || !Pacient.CitesteDinFisier().Any(p => p.Id == pid))
        {
            Console.WriteLine("ID-pacient invalid.");
        }

        var numeMedic = Prompt("Introdu numele medicului pentru consultatie: ");
        if (string.IsNullOrWhiteSpace(numeMedic) || !Medic.CitesteDinFisier().Any(m => m.Nume.Equals(numeMedic, StringComparison.OrdinalIgnoreCase)))
        {
            Console.WriteLine("Medic invalid.");
            return;
        }

        DateTime dt;
        while (!DateTime.TryParseExact(Prompt("Introdu data consultatiei (dd/MM/yyyy HH:mm): "), "dd/MM/yyyy HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out dt))
            Console.WriteLine("Format data invalid.");

        new Consultatie(pid, numeMedic, dt).SalveazaInFisier();
    }

    static void CautaMedicDupaNume()
    {
        var frag = Prompt("Introdu numele (sau fragment) medicului: ");
        var found = Medic.CitesteDinFisier()
                         .Where(m => m.Nume.IndexOf(frag, StringComparison.OrdinalIgnoreCase) >= 0)
                         .ToList();
        if (!found.Any()) Console.WriteLine("Nu s-au gasit medici.");
        else found.ForEach(m => { m.AfiseazaInformatii(); Console.WriteLine("----------------------"); });
    }

    static void CautaPacientDupaNume()
    {
        var frag = Prompt("Introdu numele (sau fragment) pacientului: ");
        var found = Pacient.CitesteDinFisier()
                            .Where(p => p.Nume.IndexOf(frag, StringComparison.OrdinalIgnoreCase) >= 0)
                            .ToList();
        if (!found.Any()) Console.WriteLine("Nu s-au gasit pacienti.");
        else found.ForEach(p => { p.AfiseazaInformatii(); Console.WriteLine("----------------------"); });
    }

    static void CautaConsultatiiDupaId()
    {
        if (!int.TryParse(Prompt("Introdu ID-ul pacientului pentru care cauti consultatii: "), out int id))
        { Console.WriteLine("ID invalid."); return; }
        var found = Consultatie.CitesteDinFisier()
                               .Where(c => c.PacientId == id)
                               .ToList();
        if (!found.Any()) Console.WriteLine("Nu exista consultatii pentru acest ID.");
        else found.ForEach(c => { c.AfiseazaDetalii(); Console.WriteLine("----------------------"); });
    }

    static string Prompt(string message)
    {
        Console.Write(message);
        return Console.ReadLine();
    }

    static bool EsteTelefonValid(string telefon)
    {
        return !string.IsNullOrWhiteSpace(telefon) && Regex.IsMatch(telefon, "^\\d{10}$");
    }
}
