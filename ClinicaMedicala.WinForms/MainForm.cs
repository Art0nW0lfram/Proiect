using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ClinicaMedicala.WinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Evenimente de încărcare și navigare
            this.Load += MainForm_Load;
            tabControl1.SelectedIndexChanged += TabControl1_SelectedIndexChanged;

            // Search universal
            btnGlobalSearch.Click += BtnGlobalSearch_Click;

            // RadioButton + Execută pentru acțiuni Medici
            btnExecuteMedic.Click += BtnExecuteMedic_Click;
            // RadioButton + Execută pentru acțiuni Pacienți
            btnExecutePacient.Click += BtnExecutePacient_Click;
            // RadioButton + Execută pentru acțiuni Consultații
            btnExecuteConsultatie.Click += BtnExecuteConsultatie_Click;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // Populează date la start
            dgvMedici.DataSource = Medic.CitesteDinFisier();
            dgvPacienti.DataSource = Pacient.CitesteDinFisier();
            dgvConsultati.DataSource = Consultatie.CitesteDinFisier();
            dgvConsultati.Columns["Data"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";

            // Set textul inițial pentru bara de căutare
            lblSearchCategory.Text = "Caut în: Medici";
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Actualizează eticheta de search în funcție de tab
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    lblSearchCategory.Text = "Caut în: Medici";
                    break;
                case 1:
                    lblSearchCategory.Text = "Caut în: Pacienți";
                    break;
                case 2:
                    lblSearchCategory.Text = "Caut în: Consultații";
                    break;
            }
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
                        : (int.TryParse(text, out int pid)
                            ? allC.Where(c => c.PacientId == pid).ToList()
                            : allC);
                    break;
            }
        }

        // ==================== Acțiuni Medici ====================
        private void BtnExecuteMedic_Click(object sender, EventArgs e)
        {
            if (rbAddMedic.Checked)
            {
                // Adaugă Medic
                using (var f = new FormAddMedic())
                    if (f.ShowDialog() == DialogResult.OK)
                        dgvMedici.DataSource = Medic.CitesteDinFisier();
            }
            else if (rbEditMedic.Checked)
            {
                if (dgvMedici.CurrentRow == null)
                {
                    MessageBox.Show("Selectează un medic pentru editare.");
                    return;
                }
                var medic = (Medic)dgvMedici.CurrentRow.DataBoundItem;
                using (var f = new FormAddMedic(medic))
                    if (f.ShowDialog() == DialogResult.OK)
                        dgvMedici.DataSource = Medic.CitesteDinFisier();
            }
            else if (rbDeleteMedic.Checked)
            {
                if (dgvMedici.CurrentRow == null)
                {
                    MessageBox.Show("Selectează un medic pentru ștergere.");
                    return;
                }
                var medic = (Medic)dgvMedici.CurrentRow.DataBoundItem;
                if (MessageBox.Show($"Ștergi {medic.Nume}?", "Confirmă", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var list = Medic.CitesteDinFisier().ToList();
                    list.RemoveAll(m => m.Nume == medic.Nume && m.Varsta == medic.Varsta);
                    File.WriteAllLines("medici.txt", list.Select(m => $"{m.Nume},{m.Varsta},{m.Telefon},{m.Specializare}"));
                    dgvMedici.DataSource = list;
                }
            }
        }

        // ==================== Acțiuni Pacienți ====================
        private void BtnExecutePacient_Click(object sender, EventArgs e)
        {
            if (rbAddPacient.Checked)
            {
                using (var f = new FormAddPacient())
                    if (f.ShowDialog() == DialogResult.OK)
                        dgvPacienti.DataSource = Pacient.CitesteDinFisier();
            }
            else if (rbEditPacient.Checked)
            {
                if (dgvPacienti.CurrentRow == null)
                {
                    MessageBox.Show("Selectează un pacient pentru editare.");
                    return;
                }
                var pac = (Pacient)dgvPacienti.CurrentRow.DataBoundItem;
                using (var f = new FormAddPacient(pac))
                    if (f.ShowDialog() == DialogResult.OK)
                        dgvPacienti.DataSource = Pacient.CitesteDinFisier();
            }
            else if (rbDeletePacient.Checked)
            {
                if (dgvPacienti.CurrentRow == null)
                {
                    MessageBox.Show("Selectează un pacient pentru ștergere.");
                    return;
                }
                var pac = (Pacient)dgvPacienti.CurrentRow.DataBoundItem;
                if (MessageBox.Show($"Ștergi {pac.Nume}?", "Confirmă", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var list = Pacient.CitesteDinFisier().ToList();
                    list.RemoveAll(p => p.Id == pac.Id);
                    File.WriteAllLines("pacienti.txt", list.Select(p => $"{p.Id},{p.Nume},{p.Varsta},{p.Telefon}"));
                    dgvPacienti.DataSource = list;
                }
            }
        }

        // ==================== Acțiuni Consultații ====================
        private void BtnExecuteConsultatie_Click(object sender, EventArgs e)
        {
            if (rbAddConsultatie.Checked)
            {
                using (var f = new FormAddConsultatie())
                    if (f.ShowDialog() == DialogResult.OK)
                        dgvConsultati.DataSource = Consultatie.CitesteDinFisier();
            }
            else if (rbEditConsultatie.Checked)
            {
                if (dgvConsultati.CurrentRow == null)
                {
                    MessageBox.Show("Selectează o consultație pentru editare.");
                    return;
                }
                var c = (Consultatie)dgvConsultati.CurrentRow.DataBoundItem;
                using (var f = new FormAddConsultatie(c))
                    if (f.ShowDialog() == DialogResult.OK)
                        dgvConsultati.DataSource = Consultatie.CitesteDinFisier();
            }
            else if (rbDeleteConsultatie.Checked)
            {
                if (dgvConsultati.CurrentRow == null)
                {
                    MessageBox.Show("Selectează o consultație pentru ștergere.");
                    return;
                }
                var c = (Consultatie)dgvConsultati.CurrentRow.DataBoundItem;
                if (MessageBox.Show($"Ștergi consultatia din {c.Data:dd/MM/yyyy HH:mm}?", "Confirmă", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var list = Consultatie.CitesteDinFisier().ToList();
                    list.RemoveAll(x => x.PacientId == c.PacientId && x.MedicNume == c.MedicNume && x.Data == c.Data);
                    File.WriteAllLines("consultatii.txt", list.Select(x => $"{x.PacientId},{x.MedicNume},{x.Data:dd/MM/yyyy HH:mm}"));
                    dgvConsultati.DataSource = list;
                }
            }
        }

        private void rbEditMedic_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
