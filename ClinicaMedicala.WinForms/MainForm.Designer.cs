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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvMedici = new System.Windows.Forms.DataGridView();
            this.dgvPacienti = new System.Windows.Forms.DataGridView();
            this.dgvConsultati = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacienti)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsultati)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
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
            this.tabPage1.Controls.Add(this.dgvMedici);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabMedici";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvPacienti);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPacienti";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvConsultati);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(392, 271);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabConsultatii";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvMedici
            // 
            this.dgvMedici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMedici.Location = new System.Drawing.Point(3, 3);
            this.dgvMedici.Name = "dgvMedici";
            this.dgvMedici.RowHeadersWidth = 51;
            this.dgvMedici.RowTemplate.Height = 24;
            this.dgvMedici.Size = new System.Drawing.Size(786, 415);
            this.dgvMedici.TabIndex = 0;
            // 
            // dgvPacienti
            // 
            this.dgvPacienti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPacienti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPacienti.Location = new System.Drawing.Point(3, 3);
            this.dgvPacienti.Name = "dgvPacienti";
            this.dgvPacienti.RowHeadersWidth = 51;
            this.dgvPacienti.RowTemplate.Height = 24;
            this.dgvPacienti.Size = new System.Drawing.Size(786, 415);
            this.dgvPacienti.TabIndex = 0;
            // 
            // dgvConsultati
            // 
            this.dgvConsultati.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsultati.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConsultati.Location = new System.Drawing.Point(3, 3);
            this.dgvConsultati.Name = "dgvConsultati";
            this.dgvConsultati.RowHeadersWidth = 51;
            this.dgvConsultati.RowTemplate.Height = 24;
            this.dgvConsultati.Size = new System.Drawing.Size(386, 265);
            this.dgvConsultati.TabIndex = 0;
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
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPacienti)).EndInit();
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
    }
}

