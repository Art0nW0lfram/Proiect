using System;
using System.IO;
using System.Windows.Forms;

namespace ClinicaMedicala.WinForms
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // setează directorul de lucru la soluția/Data
            var dataDir = Path.GetFullPath(
               Path.Combine(AppDomain.CurrentDomain.BaseDirectory,@"..\..\..\Data"));
            if (Directory.Exists(dataDir))
                Directory.SetCurrentDirectory(dataDir);
            else
                MessageBox.Show("Folder Data nu exista: " + dataDir);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
