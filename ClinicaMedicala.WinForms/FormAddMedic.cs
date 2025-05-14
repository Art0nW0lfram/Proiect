using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ClinicaMedicala;
using System.IO;

namespace ClinicaMedicala.WinForms
{
    public partial class FormAddMedic : Form
    {
        private Medic _editingMedic;

        // Constructor pentru adăugare
        public FormAddMedic()
        {
            InitializeComponent();
            ConfigureazaValidari();
            comboSpecializare.DataSource = Enum.GetValues(typeof(SpecializareMedic));
            btnSaveMedic.Click += BtnSaveMedic_Click;
        }

        // Constructor pentru editare
        public FormAddMedic(Medic medic) : this()
        {
            _editingMedic = medic;
            txtNume.Text = medic.Nume;
            txtVarsta.Text = medic.Varsta.ToString();
            txtTelefon.Text = medic.Telefon;
            comboSpecializare.SelectedItem = medic.Specializare;
        }

        private void ConfigureazaValidari()
        {
            txtVarsta.TextChanged += (s, e) =>
            {
                if (!int.TryParse(txtVarsta.Text, out int varsta) || varsta < 0)
                    txtVarsta.BackColor = Color.LightPink;
                else
                    txtVarsta.BackColor = Color.White;
            };

            txtTelefon.TextChanged += (s, e) =>
            {
                if (!Regex.IsMatch(txtTelefon.Text, @"^\d{10}$"))
                    txtTelefon.BackColor = Color.LightPink;
                else
                    txtTelefon.BackColor = Color.White;
            };
        }

        private void BtnSaveMedic_Click(object sender, EventArgs e)
        {
            // Validare finală
            if (!int.TryParse(txtVarsta.Text, out int varsta) || varsta < 0)
            {
                MessageBox.Show("Vârsta trebuie să fie un număr pozitiv.");
                return;
            }

            if (!Regex.IsMatch(txtTelefon.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Telefon invalid. Introduceți 10 cifre.");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtNume.Text))
            {
                MessageBox.Show("Introduceți un nume valid.");
                return;
            }

            // Salvare medic
            var medici = Medic.CitesteDinFisier();
            if (_editingMedic != null)
            {
                // Editare
                var medic = medici.FirstOrDefault(m => m.Nume == _editingMedic.Nume);
                if (medic != null)
                {
                    medic.Nume = txtNume.Text.Trim();
                    medic.Varsta = varsta;
                    medic.Telefon = txtTelefon.Text.Trim();
                    medic.Specializare = (SpecializareMedic)comboSpecializare.SelectedItem;
                }
            }
            else
            {
                // Adăugare
                medici.Add(new Medic(
                    txtNume.Text.Trim(),
                    varsta,
                    txtTelefon.Text.Trim(),
                    (SpecializareMedic)comboSpecializare.SelectedItem,
                    new TimeSpan(9, 0, 0), // Ore implicite
                    new TimeSpan(17, 0, 0)
                ));
            }

            // Actualizează fișierul
            File.WriteAllLines("medici.txt", medici.Select(m =>
                $"{m.Nume},{m.Varsta},{m.Telefon},{m.Specializare},{m.OraStart:hh\\:mm},{m.OraEnd:hh\\:mm}"));

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}