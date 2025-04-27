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
            this.btnAddMedic = new System.Windows.Forms.Button();
            this.dgvMedici = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAddPacient = new System.Windows.Forms.Button();
            this.dgvPacienti = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnAddConsultatie = new System.Windows.Forms.Button();
            this.dgvConsultati = new System.Windows.Forms.DataGridView();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.lblSearchCategory = new System.Windows.Forms.Label();
            this.btnGlobalSearch = new System.Windows.Forms.Button();
            this.txtGlobalSearch = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedici)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacienti)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultati)).BeginInit();
            this.panelSearch.SuspendLayout();
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
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(600, 366);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAddMedic);
            this.tabPage1.Controls.Add(this.dgvMedici);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(592, 337);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabMedici";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAddMedic
            // 
            this.btnAddMedic.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddMedic.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddMedic.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddMedic.Location = new System.Drawing.Point(2, 316);
            this.btnAddMedic.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddMedic.Name = "btnAddMedic";
            this.btnAddMedic.Size = new System.Drawing.Size(588, 19);
            this.btnAddMedic.TabIndex = 1;
            this.btnAddMedic.Text = "Adaugă Medic";
            this.btnAddMedic.UseVisualStyleBackColor = false;
            this.btnAddMedic.Click += new System.EventHandler(this.btnAddMedic_Click);
            // 
            // dgvMedici
            // 
            this.dgvMedici.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMedici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMedici.Location = new System.Drawing.Point(2, 2);
            this.dgvMedici.Margin = new System.Windows.Forms.Padding(2);
            this.dgvMedici.Name = "dgvMedici";
            this.dgvMedici.RowHeadersWidth = 51;
            this.dgvMedici.RowTemplate.Height = 24;
            this.dgvMedici.Size = new System.Drawing.Size(588, 333);
            this.dgvMedici.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAddPacient);
            this.tabPage2.Controls.Add(this.dgvPacienti);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(592, 337);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPacienti";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAddPacient
            // 
            this.btnAddPacient.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddPacient.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddPacient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddPacient.Location = new System.Drawing.Point(2, 316);
            this.btnAddPacient.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddPacient.Name = "btnAddPacient";
            this.btnAddPacient.Size = new System.Drawing.Size(588, 19);
            this.btnAddPacient.TabIndex = 1;
            this.btnAddPacient.Text = "Adaugă Pacient";
            this.btnAddPacient.UseVisualStyleBackColor = false;
            this.btnAddPacient.Click += new System.EventHandler(this.btnAddPacient_Click);
            // 
            // dgvPacienti
            // 
            this.dgvPacienti.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPacienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacienti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPacienti.Location = new System.Drawing.Point(2, 2);
            this.dgvPacienti.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPacienti.Name = "dgvPacienti";
            this.dgvPacienti.RowHeadersWidth = 51;
            this.dgvPacienti.RowTemplate.Height = 24;
            this.dgvPacienti.Size = new System.Drawing.Size(588, 333);
            this.dgvPacienti.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnAddConsultatie);
            this.tabPage3.Controls.Add(this.dgvConsultati);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(592, 337);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabConsultatii";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnAddConsultatie
            // 
            this.btnAddConsultatie.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAddConsultatie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnAddConsultatie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddConsultatie.Location = new System.Drawing.Point(2, 316);
            this.btnAddConsultatie.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddConsultatie.Name = "btnAddConsultatie";
            this.btnAddConsultatie.Size = new System.Drawing.Size(588, 19);
            this.btnAddConsultatie.TabIndex = 1;
            this.btnAddConsultatie.Text = "Adaugă Consultație";
            this.btnAddConsultatie.UseVisualStyleBackColor = false;
            this.btnAddConsultatie.Click += new System.EventHandler(this.btnAddConsultatie_Click);
            // 
            // dgvConsultati
            // 
            this.dgvConsultati.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvConsultati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultati.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConsultati.Location = new System.Drawing.Point(2, 2);
            this.dgvConsultati.Margin = new System.Windows.Forms.Padding(2);
            this.dgvConsultati.Name = "dgvConsultati";
            this.dgvConsultati.RowHeadersWidth = 51;
            this.dgvConsultati.RowTemplate.Height = 24;
            this.dgvConsultati.Size = new System.Drawing.Size(588, 333);
            this.dgvConsultati.TabIndex = 0;
            // 
            // panelSearch
            // 
            this.panelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSearch.BackColor = System.Drawing.SystemColors.Control;
            this.panelSearch.Controls.Add(this.lblSearchCategory);
            this.panelSearch.Controls.Add(this.btnGlobalSearch);
            this.panelSearch.Controls.Add(this.txtGlobalSearch);
            this.panelSearch.Location = new System.Drawing.Point(317, 0);
            this.panelSearch.Margin = new System.Windows.Forms.Padding(2);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(268, 20);
            this.panelSearch.TabIndex = 2;
            // 
            // lblSearchCategory
            // 
            this.lblSearchCategory.AutoSize = true;
            this.lblSearchCategory.Location = new System.Drawing.Point(10, 5);
            this.lblSearchCategory.Name = "lblSearchCategory";
            this.lblSearchCategory.Size = new System.Drawing.Size(94, 13);
            this.lblSearchCategory.TabIndex = 2;
            this.lblSearchCategory.Text = "Cauta dupa nume:";
            this.lblSearchCategory.Click += new System.EventHandler(this.lblSearchCategory_Click);
            // 
            // btnGlobalSearch
            // 
            this.btnGlobalSearch.Location = new System.Drawing.Point(222, 2);
            this.btnGlobalSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnGlobalSearch.Name = "btnGlobalSearch";
            this.btnGlobalSearch.Size = new System.Drawing.Size(44, 19);
            this.btnGlobalSearch.TabIndex = 1;
            this.btnGlobalSearch.Text = "Caută";
            this.btnGlobalSearch.UseVisualStyleBackColor = true;
            // 
            // txtGlobalSearch
            // 
            this.txtGlobalSearch.Location = new System.Drawing.Point(109, 1);
            this.txtGlobalSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtGlobalSearch.Name = "txtGlobalSearch";
            this.txtGlobalSearch.Size = new System.Drawing.Size(109, 20);
            this.txtGlobalSearch.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedici)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacienti)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultati)).EndInit();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
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
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox txtGlobalSearch;
        private System.Windows.Forms.Button btnGlobalSearch;
        private System.Windows.Forms.Label lblSearchCategory;
    }
}

