using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using ClinicaMedicala;

namespace ClinicaMedicala.WinForms
{
    public partial class FormAddConsultatie : Form
    {
        private Consultatie _editing;

        public FormAddConsultatie()
        {
            InitializeComponent();
            ConfigureazaValidari();

            // Populează lista de medici
            cboMedic.DataSource = Medic.CitesteDinFisier().Select(m => m.Nume).ToList();
            cboMedic.DropDownStyle = ComboBoxStyle.DropDownList;

            // Configurează DateTimePicker
            dtpData.Format = DateTimePickerFormat.Custom;
            dtpData.CustomFormat = "dd/MM/yyyy HH:mm";
            dtpData.ShowUpDown = true;

            btnSaveConsultatie.Click += BtnSaveConsultatie_Click;
        }

        public FormAddConsultatie(Consultatie existing) : this()
        {
            _editing = existing;
            txtPacientId.Text = existing.PacientId.ToString();
            cboMedic.SelectedItem = existing.MedicNume;
            dtpData.Value = existing.Data;
            btnSaveConsultatie.Text = "Salvează Modificările";
        }

        private void ConfigureazaValidari()
        {
            // Validare ID pacient în timp real
            txtPacientId.TextChanged += (s, e) =>
            {
                if (!int.TryParse(txtPacientId.Text, out int pid) || !PacientExista(pid))
                    txtPacientId.BackColor = Color.LightPink;
                else
                    txtPacientId.BackColor = Color.White;
            };

            // Validare medic în timp real
            cboMedic.SelectedIndexChanged += (s, e) =>
            {
                cboMedic.BackColor = cboMedic.SelectedItem == null ? Color.LightPink : Color.White;
            };

            // Validare dată/oră în timp real
            dtpData.ValueChanged += (s, e) =>
            {
                bool isValid = dtpData.Value >= DateTime.Now && IntervalValid();
                dtpData.CalendarTitleBackColor = isValid ? Color.White : Color.LightPink;
            };
        }

        private bool PacientExista(int id)
        {
            return Pacient.CitesteDinFisier().Any(p => p.Id == id);
        }

        private bool IntervalValid()
        {
            if (cboMedic.SelectedItem == null) return false;

            var medic = Medic.CitesteDinFisier().FirstOrDefault(m => m.Nume == cboMedic.SelectedItem.ToString());
            if (medic == null) return false;

            var ora = dtpData.Value.TimeOfDay;
            return ora >= medic.OraStart && ora <= medic.OraEnd;
        }

        private void BtnSaveConsultatie_Click(object sender, EventArgs e)
        {
            // Resetare culori
            txtPacientId.BackColor = Color.White;
            cboMedic.BackColor = Color.White;
            dtpData.CalendarTitleBackColor = Color.White;

            // Validare finală
            bool isValid = true;

            // 1. Validare ID pacient
            if (!int.TryParse(txtPacientId.Text, out int pid) || !PacientExista(pid))
            {
                txtPacientId.BackColor = Color.LightPink;
                MessageBox.Show("ID pacient invalid sau inexistent!");
                isValid = false;
            }

            // 2. Validare medic
            if (cboMedic.SelectedItem == null)
            {
                cboMedic.BackColor = Color.LightPink;
                MessageBox.Show("Selectează un medic!");
                isValid = false;
            }

            // 3. Validare dată/oră
            if (dtpData.Value < DateTime.Now)
            {
                dtpData.CalendarTitleBackColor = Color.LightPink;
                MessageBox.Show("Data trebuie să fie în viitor!");
                isValid = false;
            }

            if (!IntervalValid())
            {
                dtpData.CalendarTitleBackColor = Color.LightPink;
                MessageBox.Show("Interval orar invalid pentru medicul selectat!");
                isValid = false;
            }

            if (!isValid) return;

            // Salvare (fără comentarii incomplete)
            try
            {
                if (_editing != null)
                {
                    // Editare consultație existentă
                    var consultatii = Consultatie.CitesteDinFisier().ToList();
                    var consultatie = consultatii.FirstOrDefault(c =>
                        c.PacientId == _editing.PacientId &&
                        c.MedicNume == _editing.MedicNume &&
                        c.Data == _editing.Data);

                    if (consultatie != null)
                    {
                        consultatie.PacientId = pid;
                        consultatie.MedicNume = cboMedic.SelectedItem.ToString();
                        consultatie.Data = dtpData.Value;
                    }

                    File.WriteAllLines("consultatii.txt", consultatii.Select(c => $"{c.PacientId},{c.MedicNume},{c.Data:dd/MM/yyyy HH:mm}"));
                }
                else
                {
                    // Adăugare consultație nouă
                    new Consultatie(pid, cboMedic.SelectedItem.ToString(), dtpData.Value).SalveazaInFisier();
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la salvare: {ex.Message}");
            }
        }
    }
}