using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaMedicala.WinForms
{
    public partial class FormAddConsultatie : Form
    {
        public FormAddConsultatie()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSaveConsultatie_Click(object sender, EventArgs e)
        {
            bool valid = true;
            lblError.Text = string.Empty;

            // 1. Validare ID pacient
            if (!int.TryParse(txtIdPacient.Text, out int pid) ||
                !Pacient.CitesteDinFisier().Any(p => p.Id == pid))
            {
                lblIdPacient.ForeColor = Color.Red;
                valid = false;
            }
            else
            {
                lblIdPacient.ForeColor = Color.Black;
            }

            // 2. Validare Medic (există în listă?)
            var medicName = comboMedici.SelectedItem as string;
            var medicObj = Medic.CitesteDinFisier()
                                 .FirstOrDefault(m =>
                                     m.Nume.Equals(medicName, StringComparison.OrdinalIgnoreCase));
            if (medicObj == null)
            {
                lblMedic.ForeColor = Color.Red;
                valid = false;
            }
            else
            {
                lblMedic.ForeColor = Color.Black;
            }

            // 3. Validare Data/Ora în interval
            var dt = dateTimePicker.Value;
            var ora = dt.TimeOfDay;
            if (medicObj == null || ora < medicObj.OraStart || ora > medicObj.OraEnd)
            {
                lblData.ForeColor = Color.Red;
                valid = false;
            }
            else
            {
                lblData.ForeColor = Color.Black;
            }

            // Dacă găsim erori, afișăm mesaj și ieșim
            if (!valid)
            {
                lblError.Text = "Verifică datele completate.";
                return;
            }

            // Dacă e totul ok, creăm și salvăm consultatia
            var consult = new Consultatie(pid, medicObj.Nume, dt);
            consult.SalveazaInFisier();

            // Închidem cu OK ca MainForm să știe să reîncarce grila
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
