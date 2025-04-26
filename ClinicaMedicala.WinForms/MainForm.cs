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

        private void btnAddPacient_Click(object sender, EventArgs e)
        {
            using (var f = new FormAddPacient())
                if (f.ShowDialog() == DialogResult.OK)
                    dgvPacienti.DataSource = Pacient.CitesteDinFisier();
        }


        private void btnAddMedic_Click(object sender, EventArgs e)
        {
            using (var frm = new FormAddMedic())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                    dgvMedici.DataSource = Medic.CitesteDinFisier();
            }
        }

        private void btnAddConsultatie_Click(object sender, EventArgs e)
        {
            using (var f = new FormAddConsultatie())
                if (f.ShowDialog() == DialogResult.OK)
                    dgvConsultati.DataSource = Consultatie.CitesteDinFisier();
        }


        private void dgvMedici_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
