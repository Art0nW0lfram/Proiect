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

        public FormAddMedic()
        {
            InitializeComponent();
            ConfigureazaValidari();
            comboSpecializare.DataSource = Enum.GetValues(typeof(SpecializareMedic));

            // Setăm format 24h și showUpDown pe pickerele existente din Designer
            timeStartPicker.Format = DateTimePickerFormat.Custom;
            timeStartPicker.CustomFormat = "HH:mm";
            timeStartPicker.ShowUpDown = true;

            timeEndPicker.Format = DateTimePickerFormat.Custom;
            timeEndPicker.CustomFormat = "HH:mm";
            timeEndPicker.ShowUpDown = true;

            // Valori implicite
            timeStartPicker.Value = DateTime.Today.AddHours(9);
            timeEndPicker.Value = DateTime.Today.AddHours(17);

            btnSaveMedic.Click += BtnSaveMedic_Click;
        }

        public FormAddMedic(Medic medic) : this()
        {
            _editingMedic = medic;
            txtNume.Text = medic.Nume;
            txtVarsta.Text = medic.Varsta.ToString();
            txtTelefon.Text = medic.Telefon;
            comboSpecializare.SelectedItem = medic.Specializare;

            // Preluăm intervalul salvat
            timeStartPicker.Value = DateTime.Today.Add(medic.OraStart);
            timeEndPicker.Value = DateTime.Today.Add(medic.OraEnd);
        }

        private void ConfigureazaValidari()
        {
            txtVarsta.TextChanged += (s, e) =>
            {
                if (!int.TryParse(txtVarsta.Text, out _) || int.Parse(txtVarsta.Text) < 0)
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
            // Validări text
            if (!int.TryParse(txtVarsta.Text, out int varsta) || varsta < 0)
            {
                MessageBox.Show("Vârsta invalidă."); return;
            }
            if (!Regex.IsMatch(txtTelefon.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Telefon invalid."); return;
            }
            if (string.IsNullOrWhiteSpace(txtNume.Text))
            {
                MessageBox.Show("Nume invalid."); return;
            }

            // Preluăm interval orar
            TimeSpan start = timeStartPicker.Value.TimeOfDay;
            TimeSpan end = timeEndPicker.Value.TimeOfDay;
            if (end <= start)
            {
                MessageBox.Show("Ora Sfârșit trebuie să fie după Ora Start.");
                return;
            }

            // Actualizăm lista de medici
            var medici = Medic.CitesteDinFisier().ToList();
            if (_editingMedic != null)
            {
                var exist = medici.First(p => p.Nume == _editingMedic.Nume && p.Varsta == _editingMedic.Varsta);
                exist.Nume = txtNume.Text.Trim();
                exist.Varsta = varsta;
                exist.Telefon = txtTelefon.Text.Trim();
                exist.Specializare = (SpecializareMedic)comboSpecializare.SelectedItem;
                exist.OraStart = start;
                exist.OraEnd = end;
            }
            else
            {
                medici.Add(new Medic(
                    txtNume.Text.Trim(),
                    varsta,
                    txtTelefon.Text.Trim(),
                    (SpecializareMedic)comboSpecializare.SelectedItem,
                    start,
                    end
                ));
            }

            // Salvăm cu 6 câmpuri
            File.WriteAllLines("medici.txt",
                medici.Select(m =>
                    $"{m.Nume},{m.Varsta},{m.Telefon},{m.Specializare},{m.OraStart:hh\\:mm},{m.OraEnd:hh\\:mm}"
                )
            );

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
