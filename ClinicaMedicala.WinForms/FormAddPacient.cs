using System;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ClinicaMedicala;

namespace ClinicaMedicala.WinForms
{
    public partial class FormAddPacient : Form
    {
        // Limite de validare
        private const int MIN_AGE = 0;
        private const int MAX_AGE = 120;
        private const int PHONE_LENGTH = 10;

        public FormAddPacient()
        {
            InitializeComponent();
            this.Load += FormAddPacient_Load;
        }

        private void FormAddPacient_Load(object sender, EventArgs e)
        {
            // Curăță mesajul de eroare la început
            lblError.Text = string.Empty;
            lblError.ForeColor = Color.Red;
        }

        private void btnSavePacient_Click(object sender, EventArgs e)
        {
            bool valid = true;
            lblError.Text = string.Empty;

            // Validare ID
            if (!int.TryParse(txtId.Text, out int id) || id <= 0 ||
                Pacient.CitesteDinFisier().Any(p => p.Id == id))
            {
                lblId.ForeColor = Color.Red;
                valid = false;
            }
            else
            {
                lblId.ForeColor = Color.Black;
            }

            // Validare Nume
            if (string.IsNullOrWhiteSpace(txtNume.Text))
            {
                lblNume.ForeColor = Color.Red;
                valid = false;
            }
            else
            {
                lblNume.ForeColor = Color.Black;
            }

            // Validare Vârstă
            if (!int.TryParse(txtVarsta.Text, out int age) || age < MIN_AGE || age > MAX_AGE)
            {
                lblVarsta.ForeColor = Color.Red;
                valid = false;
            }
            else
            {
                lblVarsta.ForeColor = Color.Black;
            }

            // Validare Telefon
            if (txtTelefon.Text.Length != PHONE_LENGTH || !Regex.IsMatch(txtTelefon.Text, "^\\d{10}$"))
            {
                lblTelefon.ForeColor = Color.Red;
                valid = false;
            }
            else
            {
                lblTelefon.ForeColor = Color.Black;
            }

            // Dacă există erori, afișează mesaj și oprește
            if (!valid)
            {
                lblError.Text = "Corectează câmpurile evidențiate cu roșu.";
                return;
            }

            // Creează și salvează pacientul
            var pacient = new Pacient(id, txtNume.Text.Trim(), age, txtTelefon.Text.Trim());
            pacient.SalveazaInFisier();

            // Închide și semnalează OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
