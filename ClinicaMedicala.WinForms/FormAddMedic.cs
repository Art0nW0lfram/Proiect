using System;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace ClinicaMedicala.WinForms
{
    public partial class FormAddMedic : Form
    {
        private Medic _editing;

        // Constructor implicit (adaugă)
        public FormAddMedic()
        {
            InitializeComponent();
            comboSpecializare.DataSource = Enum.GetValues(typeof(SpecializareMedic));
            btnSaveMedic.Click += BtnSaveMedic_Click;
        }

        // Constructor pentru editare (preîncarcă câmpurile)
        public FormAddMedic(Medic existing) : this()
        {
            _editing = existing;
            txtNume.Text = existing.Nume;
            txtVarsta.Text = existing.Varsta.ToString();
            txtTelefon.Text = existing.Telefon;
            comboSpecializare.SelectedItem = existing.Specializare;
            btnSaveMedic.Text = "Salvează Modificările";
        }

        private void BtnSaveMedic_Click(object sender, EventArgs e)
        {

            if (_editing != null)
            {
                var list = Medic.CitesteDinFisier().ToList();

                _editing.Nume = txtNume.Text.Trim();
                _editing.Varsta = int.Parse(txtVarsta.Text);
                _editing.Telefon = txtTelefon.Text.Trim();
                _editing.Specializare = (SpecializareMedic)comboSpecializare.SelectedItem;

                // Rescrie fișierul
                File.WriteAllLines("medici.txt", list
                    .Select(m => $"{m.Nume},{m.Varsta},{m.Telefon},{m.Specializare}")
                );

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                // Adaugă nou medic cu interval implicit 09:00-17:00
                var nou = new Medic(
                    txtNume.Text.Trim(),
                    int.Parse(txtVarsta.Text),
                    txtTelefon.Text.Trim(),
                    (SpecializareMedic)comboSpecializare.SelectedItem,
                    TimeSpan.Parse("09:00"),
                    TimeSpan.Parse("17:00")
                );

                nou.SalveazaInFisier();
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}