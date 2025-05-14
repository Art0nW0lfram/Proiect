using System;

namespace ClinicaMedicala
{
    public class Persoana
    {
        public string Nume { get; set; }
        public int Varsta { get; set; }
        public string Telefon { get; set; }

        public Persoana(string nume, int varsta, string telefon)
        {
            Nume = nume;
            Varsta = varsta;
            Telefon = telefon;
        }

        public virtual void AfiseazaInformatii()
        {
            Console.WriteLine($"Nume: {Nume}, Varsta: {Varsta}, Telefon: {Telefon}");
        }
    }
}