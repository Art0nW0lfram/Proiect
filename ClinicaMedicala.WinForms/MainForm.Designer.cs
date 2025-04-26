namespace ClinicaMedicala.WinForms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvMedici = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvPacienti = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvConsultati = new System.Windows.Forms.DataGridView();
            this.btnAddMedic = new System.Windows.Forms.Button();
            this.btnAddPacient = new System.Windows.Forms.Button();
            this.btnAddConsultatie = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedici)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacienti)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultati)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAddMedic);
            this.tabPage1.Controls.Add(this.dgvMedici);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabMedici";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvMedici
            // 
            this.dgvMedici.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMedici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMedici.Location = new System.Drawing.Point(3, 3);
            this.dgvMedici.Name = "dgvMedici";
            this.dgvMedici.RowHeadersWidth = 51;
            this.dgvMedici.RowTemplate.Height = 24;
            this.dgvMedici.Size = new System.Drawing.Size(786, 412);
            this.dgvMedici.TabIndex = 0;
            this.dgvMedici.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMedici_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAddPacient);
            this.tabPage2.Controls.Add(this.dgvPacienti);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPacienti";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvPacienti
            // 
            this.dgvPacienti.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPacienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacienti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPacienti.Location = new System.Drawing.Point(3, 3);
            this.dgvPacienti.Name = "dgvPacienti";
            this.dgvPacienti.RowHeadersWidth = 51;
            this.dgvPacienti.RowTemplate.Height = 24;
            this.dgvPacienti.Size = new System.Drawing.Size(786, 412);
            this.dgvPacienti.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnAddConsultatie);
            this.tabPage3.Controls.Add(this.dgvConsultati);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 418);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabConsultatii";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvConsultati
            // 
            this.dgvConsultati.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvConsultati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultati.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConsultati.Location = new System.Drawing.Point(3, 3);
            this.dgvConsultati.Name = "dgvConsultati";
            this.dgvConsultati.RowHeadersWidth = 51;
            this.dgvConsultati.RowTemplate.Height = 24;
            this.dgvConsultati.Size = new System.Drawing.Size(786, 412);
            this.dgvConsultati.TabIndex = 0;
            // 
            // btnAddMedic
            // 
            this.btnAddMedic.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddMedic.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddMedic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddMedic.Location = new System.Drawing.Point(3, 3);
            this.btnAddMedic.Name = "btnAddMedic";
            this.btnAddMedic.Size = new System.Drawing.Size(786, 23);
            this.btnAddMedic.TabIndex = 1;
            this.btnAddMedic.Text = "Adaugă Medic";
            this.btnAddMedic.UseVisualStyleBackColor = false;
            this.btnAddMedic.Click += new System.EventHandler(this.btnAddMedic_Click);
            // 
            // btnAddPacient
            // 
            this.btnAddPacient.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddPacient.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddPacient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddPacient.Location = new System.Drawing.Point(3, 3);
            this.btnAddPacient.Name = "btnAddPacient";
            this.btnAddPacient.Size = new System.Drawing.Size(786, 23);
            this.btnAddPacient.TabIndex = 1;
            this.btnAddPacient.Text = "Adaugă Pacient";
            this.btnAddPacient.UseVisualStyleBackColor = false;
            this.btnAddPacient.Click += new System.EventHandler(this.btnAddPacient_Click);
            // 
            // btnAddConsultatie
            // 
            this.btnAddConsultatie.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddConsultatie.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddConsultatie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddConsultatie.Location = new System.Drawing.Point(3, 3);
            this.btnAddConsultatie.Name = "btnAddConsultatie";
            this.btnAddConsultatie.Size = new System.Drawing.Size(786, 23);
            this.btnAddConsultatie.TabIndex = 1;
            this.btnAddConsultatie.Text = "Adaugă Consultație";
            this.btnAddConsultatie.UseVisualStyleBackColor = false;
            this.btnAddConsultatie.Click += new System.EventHandler(this.btnAddConsultatie_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedici)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacienti)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultati)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvMedici;
        private System.Windows.Forms.DataGridView dgvPacienti;
        private System.Windows.Forms.DataGridView dgvConsultati;
        private System.Windows.Forms.Button btnAddMedic;
        private System.Windows.Forms.Button btnAddPacient;
        private System.Windows.Forms.Button btnAddConsultatie;
    }
}

