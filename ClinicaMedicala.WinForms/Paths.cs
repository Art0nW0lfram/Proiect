using System;
using System.IO;

namespace ClinicaMedicala
{
    public static class Paths
    {
        private static string BaseDataFolder =>
            Path.GetFullPath(Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                @"..\..\..\..\Data"));

        public static string Pacienti => Path.Combine(BaseDataFolder, "pacienti.txt");
        public static string Medici => Path.Combine(BaseDataFolder, "medici.txt");
        public static string Consultatii => Path.Combine(BaseDataFolder, "consultatii.txt");
    }
}