using ClinicaMedicala;
using System;

class Program
{
    static void Main()
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
            Console.WriteLine("7. Cauta consultatii dupa ID pacient");
            Console.WriteLine("8. Cauta medic dupa nume");
            Console.WriteLine("9. Cauta pacient dupa nume");
            Console.WriteLine("10. Iesire");
            Console.Write("Alege o optiune: ");

            switch (Console.ReadLine())
            {
                case "1": Medic.AfiseazaToti(); break;
                case "2": Pacient.AfiseazaToti(); break;
                case "3": Consultatie.AfiseazaToate(); break;
                case "4": Medic.AdaugaDinConsola(); break;
                case "5": Pacient.AdaugaDinConsola(); break;
                case "6": Consultatie.AdaugaDinConsola(); break;
                case "7": Consultatie.CautaDupaId(); break;
                case "8": Medic.CautaDupaNume(); break;
                case "9": Pacient.CautaDupaNume(); break;
                case "10": return;
                default: Console.WriteLine("Opţiune invalidă"); break;
            }
        }
    }
}
