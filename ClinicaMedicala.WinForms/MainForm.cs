using System;
using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

namespace ClinicaMedicala.WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
            btnGlobalSearch.Click += BtnGlobalSearch_Click;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Populează DataGridView-urile la încărcare
            dgvMedici.DataSource = Medic.CitesteDinFisier();
            dgvPacienti.DataSource = Pacient.CitesteDinFisier();
            dgvConsultati.DataSource = Consultatie.CitesteDinFisier();
        }

        private void btnAddMedic_Click(object sender, EventArgs e)
        {
            using (var f = new FormAddMedic())
                if (f.ShowDialog() == DialogResult.OK)
                    dgvMedici.DataSource = Medic.CitesteDinFisier();
        }

        private void btnAddPacient_Click(object sender, EventArgs e)
        {
            using (var f = new FormAddPacient())
                if (f.ShowDialog() == DialogResult.OK)
                    dgvPacienti.DataSource = Pacient.CitesteDinFisier();
        }

        private void btnAddConsultatie_Click(object sender, EventArgs e)
        {
            using (var f = new FormAddConsultatie())
                if (f.ShowDialog() == DialogResult.OK)
                    dgvConsultati.DataSource = Consultatie.CitesteDinFisier();
        }

        private void BtnGlobalSearch_Click(object sender, EventArgs e)
        {
            string text = txtGlobalSearch.Text.Trim();
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    var allM = Medic.CitesteDinFisier();
                    dgvMedici.DataSource = string.IsNullOrEmpty(text)
                        ? allM
                        : allM.Where(m => m.Nume.IndexOf(text, StringComparison.OrdinalIgnoreCase) >= 0)
                              .ToList();
                    break;
                case 1:
                    var allP = Pacient.CitesteDinFisier();
                    dgvPacienti.DataSource = string.IsNullOrEmpty(text)
                        ? allP
                        : allP.Where(p => p.Nume.IndexOf(text, StringComparison.OrdinalIgnoreCase) >= 0)
                              .ToList();
                    break;
                case 2:
                    var allC = Consultatie.CitesteDinFisier();
                    dgvConsultati.DataSource = string.IsNullOrEmpty(text)
                        ? allC
                        : int.TryParse(text, out int pid)
                            ? allC.Where(c => c.PacientId == pid).ToList()
                            : allC;
                    break;
            }
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    lblSearchCategory.Text = "Cauta dupa nume:";
                    break;
                case 1:
                    lblSearchCategory.Text = "Cauta dupa nume:";
                    break;
                case 2:
                    lblSearchCategory.Text = "Cauta dupa ID:";
                    break;
            }
        }

        private void lblSearchCategory_Click(object sender, EventArgs e)
        {

        }
    }
}
