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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gbMediciActions = new System.Windows.Forms.GroupBox();
            this.btnExecuteMedic = new System.Windows.Forms.Button();
            this.rbDeleteMedic = new System.Windows.Forms.RadioButton();
            this.rbEditMedic = new System.Windows.Forms.RadioButton();
            this.rbAddMedic = new System.Windows.Forms.RadioButton();
            this.dgvMedici = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gbPacientiActions = new System.Windows.Forms.GroupBox();
            this.btnExecutePacient = new System.Windows.Forms.Button();
            this.rbDeletePacient = new System.Windows.Forms.RadioButton();
            this.rbEditPacient = new System.Windows.Forms.RadioButton();
            this.rbAddPacient = new System.Windows.Forms.RadioButton();
            this.dgvPacienti = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gbConsultatiiActions = new System.Windows.Forms.GroupBox();
            this.btnExecuteConsultatie = new System.Windows.Forms.Button();
            this.rbDeleteConsultatie = new System.Windows.Forms.RadioButton();
            this.rbEditConsultatie = new System.Windows.Forms.RadioButton();
            this.rbAddConsultatie = new System.Windows.Forms.RadioButton();
            this.dgvConsultati = new System.Windows.Forms.DataGridView();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.lblSearchCategory = new System.Windows.Forms.Label();
            this.btnGlobalSearch = new System.Windows.Forms.Button();
            this.txtGlobalSearch = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.gbMediciActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedici)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.gbPacientiActions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacienti)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.gbConsultatiiActions.SuspendLayout();
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
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gbMediciActions);
            this.tabPage1.Controls.Add(this.dgvMedici);
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(792, 418);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Medici";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gbMediciActions
            // 
            this.gbMediciActions.Controls.Add(this.btnExecuteMedic);
            this.gbMediciActions.Controls.Add(this.rbDeleteMedic);
            this.gbMediciActions.Controls.Add(this.rbEditMedic);
            this.gbMediciActions.Controls.Add(this.rbAddMedic);
            this.gbMediciActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbMediciActions.Location = new System.Drawing.Point(3, 356);
            this.gbMediciActions.Name = "gbMediciActions";
            this.gbMediciActions.Size = new System.Drawing.Size(786, 60);
            this.gbMediciActions.TabIndex = 1;
            this.gbMediciActions.TabStop = false;
            // 
            // btnExecuteMedic
            // 
            this.btnExecuteMedic.Location = new System.Drawing.Point(300, 18);
            this.btnExecuteMedic.Name = "btnExecuteMedic";
            this.btnExecuteMedic.Size = new System.Drawing.Size(75, 23);
            this.btnExecuteMedic.TabIndex = 3;
            this.btnExecuteMedic.Text = "Execută";
            this.btnExecuteMedic.UseVisualStyleBackColor = true;
            // 
            // rbDeleteMedic
            // 
            this.rbDeleteMedic.AutoSize = true;
            this.rbDeleteMedic.Location = new System.Drawing.Point(200, 20);
            this.rbDeleteMedic.Name = "rbDeleteMedic";
            this.rbDeleteMedic.Size = new System.Drawing.Size(68, 20);
            this.rbDeleteMedic.TabIndex = 2;
            this.rbDeleteMedic.TabStop = true;
            this.rbDeleteMedic.Text = "Șterge";
            this.rbDeleteMedic.UseVisualStyleBackColor = true;
            // 
            // rbEditMedic
            // 
            this.rbEditMedic.AutoSize = true;
            this.rbEditMedic.Location = new System.Drawing.Point(100, 20);
            this.rbEditMedic.Name = "rbEditMedic";
            this.rbEditMedic.Size = new System.Drawing.Size(81, 20);
            this.rbEditMedic.TabIndex = 1;
            this.rbEditMedic.TabStop = true;
            this.rbEditMedic.Text = "Editează";
            this.rbEditMedic.UseVisualStyleBackColor = true;
            this.rbEditMedic.CheckedChanged += new System.EventHandler(this.rbEditMedic_CheckedChanged);
            // 
            // rbAddMedic
            // 
            this.rbAddMedic.AutoSize = true;
            this.rbAddMedic.Location = new System.Drawing.Point(10, 20);
            this.rbAddMedic.Name = "rbAddMedic";
            this.rbAddMedic.Size = new System.Drawing.Size(76, 20);
            this.rbAddMedic.TabIndex = 0;
            this.rbAddMedic.TabStop = true;
            this.rbAddMedic.Text = "Adaugă";
            this.rbAddMedic.UseVisualStyleBackColor = true;
            // 
            // dgvMedici
            // 
            this.dgvMedici.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvMedici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMedici.Location = new System.Drawing.Point(3, 2);
            this.dgvMedici.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvMedici.Name = "dgvMedici";
            this.dgvMedici.RowHeadersWidth = 51;
            this.dgvMedici.RowTemplate.Height = 24;
            this.dgvMedici.Size = new System.Drawing.Size(786, 414);
            this.dgvMedici.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gbPacientiActions);
            this.tabPage2.Controls.Add(this.dgvPacienti);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(792, 418);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Pacienti";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gbPacientiActions
            // 
            this.gbPacientiActions.Controls.Add(this.btnExecutePacient);
            this.gbPacientiActions.Controls.Add(this.rbDeletePacient);
            this.gbPacientiActions.Controls.Add(this.rbEditPacient);
            this.gbPacientiActions.Controls.Add(this.rbAddPacient);
            this.gbPacientiActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbPacientiActions.Location = new System.Drawing.Point(3, 356);
            this.gbPacientiActions.Name = "gbPacientiActions";
            this.gbPacientiActions.Size = new System.Drawing.Size(786, 60);
            this.gbPacientiActions.TabIndex = 1;
            this.gbPacientiActions.TabStop = false;
            // 
            // btnExecutePacient
            // 
            this.btnExecutePacient.Location = new System.Drawing.Point(300, 18);
            this.btnExecutePacient.Name = "btnExecutePacient";
            this.btnExecutePacient.Size = new System.Drawing.Size(75, 23);
            this.btnExecutePacient.TabIndex = 3;
            this.btnExecutePacient.Text = "Execută";
            this.btnExecutePacient.UseVisualStyleBackColor = true;
            // 
            // rbDeletePacient
            // 
            this.rbDeletePacient.AutoSize = true;
            this.rbDeletePacient.Location = new System.Drawing.Point(200, 20);
            this.rbDeletePacient.Name = "rbDeletePacient";
            this.rbDeletePacient.Size = new System.Drawing.Size(68, 20);
            this.rbDeletePacient.TabIndex = 2;
            this.rbDeletePacient.TabStop = true;
            this.rbDeletePacient.Text = "Șterge";
            this.rbDeletePacient.UseVisualStyleBackColor = true;
            // 
            // rbEditPacient
            // 
            this.rbEditPacient.AutoSize = true;
            this.rbEditPacient.Location = new System.Drawing.Point(100, 20);
            this.rbEditPacient.Name = "rbEditPacient";
            this.rbEditPacient.Size = new System.Drawing.Size(81, 20);
            this.rbEditPacient.TabIndex = 1;
            this.rbEditPacient.TabStop = true;
            this.rbEditPacient.Text = "Editează";
            this.rbEditPacient.UseVisualStyleBackColor = true;
            // 
            // rbAddPacient
            // 
            this.rbAddPacient.AutoSize = true;
            this.rbAddPacient.Location = new System.Drawing.Point(10, 20);
            this.rbAddPacient.Name = "rbAddPacient";
            this.rbAddPacient.Size = new System.Drawing.Size(76, 20);
            this.rbAddPacient.TabIndex = 0;
            this.rbAddPacient.TabStop = true;
            this.rbAddPacient.Text = "Adaugă";
            this.rbAddPacient.UseVisualStyleBackColor = true;
            // 
            // dgvPacienti
            // 
            this.dgvPacienti.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPacienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacienti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPacienti.Location = new System.Drawing.Point(3, 2);
            this.dgvPacienti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPacienti.Name = "dgvPacienti";
            this.dgvPacienti.RowHeadersWidth = 51;
            this.dgvPacienti.RowTemplate.Height = 24;
            this.dgvPacienti.Size = new System.Drawing.Size(786, 414);
            this.dgvPacienti.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.gbConsultatiiActions);
            this.tabPage3.Controls.Add(this.dgvConsultati);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage3.Size = new System.Drawing.Size(792, 418);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Consultatii";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gbConsultatiiActions
            // 
            this.gbConsultatiiActions.Controls.Add(this.btnExecuteConsultatie);
            this.gbConsultatiiActions.Controls.Add(this.rbDeleteConsultatie);
            this.gbConsultatiiActions.Controls.Add(this.rbEditConsultatie);
            this.gbConsultatiiActions.Controls.Add(this.rbAddConsultatie);
            this.gbConsultatiiActions.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbConsultatiiActions.Location = new System.Drawing.Point(3, 356);
            this.gbConsultatiiActions.Name = "gbConsultatiiActions";
            this.gbConsultatiiActions.Size = new System.Drawing.Size(786, 60);
            this.gbConsultatiiActions.TabIndex = 1;
            this.gbConsultatiiActions.TabStop = false;
            // 
            // btnExecuteConsultatie
            // 
            this.btnExecuteConsultatie.Location = new System.Drawing.Point(300, 18);
            this.btnExecuteConsultatie.Name = "btnExecuteConsultatie";
            this.btnExecuteConsultatie.Size = new System.Drawing.Size(75, 23);
            this.btnExecuteConsultatie.TabIndex = 3;
            this.btnExecuteConsultatie.Text = "Execută";
            this.btnExecuteConsultatie.UseVisualStyleBackColor = true;
            // 
            // rbDeleteConsultatie
            // 
            this.rbDeleteConsultatie.AutoSize = true;
            this.rbDeleteConsultatie.Location = new System.Drawing.Point(200, 20);
            this.rbDeleteConsultatie.Name = "rbDeleteConsultatie";
            this.rbDeleteConsultatie.Size = new System.Drawing.Size(68, 20);
            this.rbDeleteConsultatie.TabIndex = 2;
            this.rbDeleteConsultatie.TabStop = true;
            this.rbDeleteConsultatie.Text = "Șterge";
            this.rbDeleteConsultatie.UseVisualStyleBackColor = true;
            // 
            // rbEditConsultatie
            // 
            this.rbEditConsultatie.AutoSize = true;
            this.rbEditConsultatie.Location = new System.Drawing.Point(100, 20);
            this.rbEditConsultatie.Name = "rbEditConsultatie";
            this.rbEditConsultatie.Size = new System.Drawing.Size(81, 20);
            this.rbEditConsultatie.TabIndex = 1;
            this.rbEditConsultatie.TabStop = true;
            this.rbEditConsultatie.Text = "Editează";
            this.rbEditConsultatie.UseVisualStyleBackColor = true;
            // 
            // rbAddConsultatie
            // 
            this.rbAddConsultatie.AutoSize = true;
            this.rbAddConsultatie.Location = new System.Drawing.Point(10, 20);
            this.rbAddConsultatie.Name = "rbAddConsultatie";
            this.rbAddConsultatie.Size = new System.Drawing.Size(76, 20);
            this.rbAddConsultatie.TabIndex = 0;
            this.rbAddConsultatie.TabStop = true;
            this.rbAddConsultatie.Text = "Adaugă";
            this.rbAddConsultatie.UseVisualStyleBackColor = true;
            // 
            // dgvConsultati
            // 
            this.dgvConsultati.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvConsultati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultati.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConsultati.Location = new System.Drawing.Point(3, 2);
            this.dgvConsultati.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvConsultati.Name = "dgvConsultati";
            this.dgvConsultati.RowHeadersWidth = 51;
            this.dgvConsultati.RowTemplate.Height = 24;
            this.dgvConsultati.Size = new System.Drawing.Size(786, 414);
            this.dgvConsultati.TabIndex = 0;
            // 
            // panelSearch
            // 
            this.panelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSearch.BackColor = System.Drawing.SystemColors.Control;
            this.panelSearch.Controls.Add(this.lblSearchCategory);
            this.panelSearch.Controls.Add(this.btnGlobalSearch);
            this.panelSearch.Controls.Add(this.txtGlobalSearch);
            this.panelSearch.Location = new System.Drawing.Point(423, 0);
            this.panelSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(357, 25);
            this.panelSearch.TabIndex = 2;
            // 
            // lblSearchCategory
            // 
            this.lblSearchCategory.AutoSize = true;
            this.lblSearchCategory.Location = new System.Drawing.Point(13, 6);
            this.lblSearchCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchCategory.Name = "lblSearchCategory";
            this.lblSearchCategory.Size = new System.Drawing.Size(115, 16);
            this.lblSearchCategory.TabIndex = 2;
            this.lblSearchCategory.Text = "Cauta dupa nume:";
            // 
            // btnGlobalSearch
            // 
            this.btnGlobalSearch.Location = new System.Drawing.Point(296, 2);
            this.btnGlobalSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGlobalSearch.Name = "btnGlobalSearch";
            this.btnGlobalSearch.Size = new System.Drawing.Size(59, 23);
            this.btnGlobalSearch.TabIndex = 1;
            this.btnGlobalSearch.Text = "Caută";
            this.btnGlobalSearch.UseVisualStyleBackColor = true;
            // 
            // txtGlobalSearch
            // 
            this.txtGlobalSearch.Location = new System.Drawing.Point(145, 1);
            this.txtGlobalSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGlobalSearch.Name = "txtGlobalSearch";
            this.txtGlobalSearch.Size = new System.Drawing.Size(144, 22);
            this.txtGlobalSearch.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "CLINICA MEDICALA";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.gbMediciActions.ResumeLayout(false);
            this.gbMediciActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedici)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.gbPacientiActions.ResumeLayout(false);
            this.gbPacientiActions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacienti)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.gbConsultatiiActions.ResumeLayout(false);
            this.gbConsultatiiActions.PerformLayout();
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
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.TextBox txtGlobalSearch;
        private System.Windows.Forms.Button btnGlobalSearch;
        private System.Windows.Forms.Label lblSearchCategory;
        private System.Windows.Forms.GroupBox gbMediciActions;
        private System.Windows.Forms.RadioButton rbEditMedic;
        private System.Windows.Forms.RadioButton rbAddMedic;
        private System.Windows.Forms.GroupBox gbPacientiActions;
        private System.Windows.Forms.GroupBox gbConsultatiiActions;
        private System.Windows.Forms.Button btnExecuteMedic;
        private System.Windows.Forms.RadioButton rbDeleteMedic;
        private System.Windows.Forms.Button btnExecutePacient;
        private System.Windows.Forms.RadioButton rbDeletePacient;
        private System.Windows.Forms.RadioButton rbEditPacient;
        private System.Windows.Forms.RadioButton rbAddPacient;
        private System.Windows.Forms.Button btnExecuteConsultatie;
        private System.Windows.Forms.RadioButton rbDeleteConsultatie;
        private System.Windows.Forms.RadioButton rbEditConsultatie;
        private System.Windows.Forms.RadioButton rbAddConsultatie;
    }
}

