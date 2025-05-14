using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ClinicaMedicala;

namespace ClinicaMedicala.WinForms
{
    public partial class FormAddPacient : Form
    {
        private Pacient _editingPacient;

        public FormAddPacient()
        {
            InitializeComponent();
            ConfigureazaValidari();
            btnSavePacient.Click += BtnSavePacient_Click;
        }

        public FormAddPacient(Pacient pacient) : this()
        {
            _editingPacient = pacient;
            txtId.Text = pacient.Id.ToString();
            txtNume.Text = pacient.Nume;
            txtVarsta.Text = pacient.Varsta.ToString();
            txtTelefon.Text = pacient.Telefon;
        }

        private void ConfigureazaValidari()
        {
            // Validare ID (doar dacă nu suntem în editare)
            if (_editingPacient == null)
            {
                txtId.TextChanged += (s, e) =>
                {
                    if (!int.TryParse(txtId.Text, out int id) || id <= 0 || Pacient.CitesteDinFisier().Any(p => p.Id == id))
                    {
                        txtId.BackColor = Color.LightPink;
                    }
                    else
                    {
                        txtId.BackColor = Color.White;
                    }
                };
            }

            // Validare varsta
            txtVarsta.TextChanged += (s, e) =>
            {
                if (!int.TryParse(txtVarsta.Text, out int varsta) || varsta < 0)
                    txtVarsta.BackColor = Color.LightPink;
                else
                    txtVarsta.BackColor = Color.White;
            };

            // Validare telefon
            txtTelefon.TextChanged += (s, e) =>
            {
                if (!Regex.IsMatch(txtTelefon.Text, @"^\d{10}$"))
                    txtTelefon.BackColor = Color.LightPink;
                else
                    txtTelefon.BackColor = Color.White;
            };
        }

        private void BtnSavePacient_Click(object sender, EventArgs e)
        {
            // Validare ID
            if (!int.TryParse(txtId.Text, out int id) || id <= 0)
            {
                MessageBox.Show("ID invalid!");
                return;
            }

            // Dacă suntem în editare, excludem pacientul curent de la verificarea ID-ului
            var pacienti = Pacient.CitesteDinFisier().ToList();
            bool idExistent = pacienti.Any(p =>
                p.Id == id &&
                (_editingPacient == null || p.Id != _editingPacient.Id) // Ignoră ID-ul vechi în editare
            );

            if (idExistent)
            {
                MessageBox.Show("ID existent!");
                return;
            }

            // Validare varsta
            if (!int.TryParse(txtVarsta.Text, out int varsta) || varsta < 0)
            {
                MessageBox.Show("Vârsta invalidă!");
                return;
            }

            // Validare telefon
            if (!Regex.IsMatch(txtTelefon.Text, @"^\d{10}$"))
            {
                MessageBox.Show("Telefon invalid (10 cifre)!");
                return;
            }

            // Salvare
            if (_editingPacient != null)
            {
                // Editare: Actualizează pacientul existent
                var pacientVechi = pacienti.FirstOrDefault(p => p.Id == _editingPacient.Id);
                if (pacientVechi != null)
                {
                    pacientVechi.Id = id;
                    pacientVechi.Nume = txtNume.Text;
                    pacientVechi.Varsta = varsta;
                    pacientVechi.Telefon = txtTelefon.Text;
                }
            }
            else
            {
                // Adăugare: Adaugă pacient nou
                pacienti.Add(new Pacient(id, txtNume.Text, varsta, txtTelefon.Text));
            }

            File.WriteAllLines("pacienti.txt", pacienti.Select(p => $"{p.Id},{p.Nume},{p.Varsta},{p.Telefon}"));
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}