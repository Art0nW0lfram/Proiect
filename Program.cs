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
            Console.WriteLine("7. Cauta medic dupa nume");
            Console.WriteLine("8. Cauta pacient dupa nume");
            Console.WriteLine("9. Cauta consultatii dupa ID pacient");
            Console.WriteLine("10. Editeaza medic");
            Console.WriteLine("11. Sterge medic");
            Console.WriteLine("12. Editeaza pacient");
            Console.WriteLine("13. Sterge pacient");
            Console.WriteLine("14. Editeaza consultatie");
            Console.WriteLine("15. Sterge consultatie");
            Console.WriteLine("16. Iesire");
            Console.Write("Alege o optiune: ");

            switch (Console.ReadLine())
            {
                case "1": Medic.AfiseazaToti(); break;
                case "2": Pacient.AfiseazaToti(); break;
                case "3": Consultatie.AfiseazaToate(); break;
                case "4": Medic.AdaugaDinConsola(); break;
                case "5": Pacient.AdaugaDinConsola(); break;
                case "6": Consultatie.AdaugaDinConsola(); break;
                case "7": Medic.CautaDupaNume(); break;
                case "8": Pacient.CautaDupaNume(); break;
                case "9": Consultatie.CautaDupaId(); break;
                case "10": Medic.EditeazaDinConsola(); break;
                case "11": Medic.StergeDinFisier(); break;
                case "12": Pacient.EditeazaDinConsola(); break;
                case "13": Pacient.StergeDinFisier(); break;
                case "14": Consultatie.EditeazaDinConsola(); break;
                case "15": Consultatie.StergeDinFisier(); break;
                case "16": return;
                default: Console.WriteLine("Opţiune invalidă"); break;
            }
        }
    }
}
