using System;
using System.Windows.Forms;
using ClinicaMedicala;

namespace ClinicaMedicala.WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Populeaza DataGridView-urile cu datele din fisiere
            dgvMedici.DataSource = Medic.CitesteDinFisier();
            dgvPacienti.DataSource = Pacient.CitesteDinFisier();
            // Folosim dgvConsultati conform numelui din Designer
            dgvConsultati.DataSource = Consultatie.CitesteDinFisier();
        }
    }
}
