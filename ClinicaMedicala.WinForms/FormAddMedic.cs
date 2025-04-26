using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using ClinicaMedicala;

namespace ClinicaMedicala.WinForms
{
    public partial class FormAddMedic : Form
    {
        // Limite de validare
        private const int MIN_AGE = 0;
        private const int MAX_AGE = 120;
        private const int PHONE_LENGTH = 10;

        // Interval implicit consultații
        private static readonly TimeSpan DEFAULT_START = TimeSpan.Parse("09:00");
        private static readonly TimeSpan DEFAULT_END = TimeSpan.Parse("17:00");

        public FormAddMedic()
        {
            InitializeComponent();
            this.Load += FormAddMedic_Load;
        }

        private void FormAddMedic_Load(object sender, EventArgs e)
        {
            // Populează ComboBox-ul cu enum SpecializareMedic
            comboSpecializare.DataSource = Enum.GetValues(typeof(SpecializareMedic));
            comboSpecializare.SelectedIndex = -1;

            // Mesaj de eroare gol la început
            lblError.Text = string.Empty;
            lblError.ForeColor = Color.Red;
        }

        private void btnSaveMedic_Click(object sender, EventArgs e)
        {
            bool valid = true;
            lblError.Text = string.Empty;

            // Validare Nume
            if (string.IsNullOrWhiteSpace(txtNume.Text))
            {
                lblNume.ForeColor = Color.Red;
                valid = false;
            }
            else lblNume.ForeColor = Color.Black;

            // Validare Vârstă
            if (!int.TryParse(txtVarsta.Text, out int age) || age < MIN_AGE || age > MAX_AGE)
            {
                lblVarsta.ForeColor = Color.Red;
                valid = false;
            }
            else lblVarsta.ForeColor = Color.Black;

            // Validare Telefon
            if (txtTelefon.Text.Length != PHONE_LENGTH || !Regex.IsMatch(txtTelefon.Text, "^\\d{10}$"))
            {
                lblTelefon.ForeColor = Color.Red;
                valid = false;
            }
            else lblTelefon.ForeColor = Color.Black;

            // Validare Specializare
            if (comboSpecializare.SelectedItem == null)
            {
                lblSpec.ForeColor = Color.Red;
                valid = false;
            }
            else lblSpec.ForeColor = Color.Black;

            if (!valid)
            {
                lblError.Text = "Te rog corectează câmpurile evidențiate în roșu.";
                return;
            }

            // Creează și salvează medicul cu interval implicit
            var spec = (SpecializareMedic)comboSpecializare.SelectedItem;
            var medic = new Medic(
                txtNume.Text.Trim(),
                age,
                txtTelefon.Text.Trim(),
                spec,
                DEFAULT_START,
                DEFAULT_END);
            medic.SalveazaInFisier();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
