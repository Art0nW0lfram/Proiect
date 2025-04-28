using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ClinicaMedicala.WinForms
{
    public partial class FormAddPacient : Form
    {
        private Pacient _editing;
        private int _oldId;

        // Constructor pentru adăugare
        public FormAddPacient()
        {
            InitializeComponent();
            btnSavePacient.Click += BtnSavePacient_Click;
        }

        // Constructor pentru editare (preîncarcă câmpurile și păstrează ID-ul vechi)
        public FormAddPacient(Pacient existing) : this()
        {
            _editing = existing;
            _oldId = existing.Id;

            txtId.Text = existing.Id.ToString();
            txtNume.Text = existing.Nume;
            txtVarsta.Text = existing.Varsta.ToString();
            txtTelefon.Text = existing.Telefon;
            txtId.ReadOnly = true;
            btnSavePacient.Text = "Salvează Modificările";
        }

        private void BtnSavePacient_Click(object sender, EventArgs e)
        {
            // Validări
            if (string.IsNullOrWhiteSpace(txtNume.Text) ||
                !int.TryParse(txtVarsta.Text, out int varsta) || varsta < 0 ||
                !Regex.IsMatch(txtTelefon.Text.Trim(), "^\\d{10}$"))
            {
                MessageBox.Show("Te rog corectează câmpurile valide.");
                return;
            }

            if (_editing != null)
            {
                // Editare
                var list = Pacient.CitesteDinFisier().ToList();
                var target = list.FirstOrDefault(p => p.Id == _oldId);
                if (target != null)
                {
                    target.Nume = txtNume.Text.Trim();
                    target.Varsta = varsta;
                    target.Telefon = txtTelefon.Text.Trim();
                }

                File.WriteAllLines("pacienti.txt",
                    list.Select(p => $"{p.Id},{p.Nume},{p.Varsta},{p.Telefon}"));

                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                // Adăugare nou pacient
                int id;
                if (!int.TryParse(txtId.Text, out id) || id <= 0)
                {
                    MessageBox.Show("ID invalid.");
                    return;
                }
                var nou = new Pacient(id,
                                      txtNume.Text.Trim(),
                                      varsta,
                                      txtTelefon.Text.Trim());
                nou.SalveazaInFisier();
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
