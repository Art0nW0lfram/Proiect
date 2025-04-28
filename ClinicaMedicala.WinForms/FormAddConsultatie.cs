using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace ClinicaMedicala.WinForms
{
    public partial class FormAddConsultatie : Form
    {
        private Consultatie _editing;

        public FormAddConsultatie()
        {
            InitializeComponent();

            // Populează ComboBox-ul cu lista de medici
            cboMedic.DataSource = Medic.CitesteDinFisier()
                                      .Select(m => m.Nume)
                                      .ToList();
            cboMedic.DropDownStyle = ComboBoxStyle.DropDownList;

            // Configurează DateTimePicker pentru data și ora consultatiei
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

            txtPacientId.ReadOnly = true;
            btnSaveConsultatie.Text = "Salvează Modificările";
        }

        private void BtnSaveConsultatie_Click(object sender, EventArgs e)
        {
            // Validare ID pacient
            if (!int.TryParse(txtPacientId.Text.Trim(), out int pid) || pid <= 0)
            {
                MessageBox.Show("ID pacient invalid.");
                return;
            }

            // Validare medic selectat
            if (cboMedic.SelectedItem == null)
            {
                MessageBox.Show("Selectează un medic din listă.");
                return;
            }

            // Preia data și ora din DateTimePicker
            DateTime dt = dtpData.Value;
            string medicName = cboMedic.SelectedItem.ToString();

            // Verifică disponibilitatea medicului
            var medicObj = Medic.CitesteDinFisier()
                                 .FirstOrDefault(m => m.Nume.Equals(medicName, StringComparison.OrdinalIgnoreCase));
            if (medicObj != null)
            {
                var ora = dt.TimeOfDay;
                if (ora < medicObj.OraStart || ora > medicObj.OraEnd)
                {
                    MessageBox.Show(
                        $"Medic indisponibil la ora aleasă. Program: {medicObj.OraStart:HH\\:mm}–{medicObj.OraEnd:HH\\:mm}.");
                    return;
                }
            }

            if (_editing != null)
            {
                // Editare consultatie existing
                var list = Consultatie.CitesteDinFisier().ToList();
                var target = list.FirstOrDefault(c =>
                    c.PacientId == _editing.PacientId &&
                    c.MedicNume == _editing.MedicNume &&
                    c.Data == _editing.Data);
                if (target != null)
                {
                    target.PacientId = pid;
                    target.MedicNume = medicName;
                    target.Data = dt;
                }

                File.WriteAllLines(
                    "consultatii.txt",
                    list.Select(c => $"{c.PacientId},{c.MedicNume},{c.Data:dd/MM/yyyy HH:mm}"));

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                // Adăugare consultatie nouă
                var nou = new Consultatie(pid, medicName, dt);
                nou.SalveazaInFisier();

                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
