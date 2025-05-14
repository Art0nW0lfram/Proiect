namespace ClinicaMedicala.WinForms
{
    partial class FormAddConsultatie
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblIdPacient = new System.Windows.Forms.Label();
            this.lblMedic = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.txtPacientId = new System.Windows.Forms.TextBox();
            this.cboMedic = new System.Windows.Forms.ComboBox();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.btnSaveConsultatie = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblIdPacient, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMedic, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblData, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblError, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtPacientId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.cboMedic, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpData, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnSaveConsultatie, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // lblIdPacient
            // 
            this.lblIdPacient.AutoSize = true;
            this.lblIdPacient.Location = new System.Drawing.Point(4, 1);
            this.lblIdPacient.Name = "lblIdPacient";
            this.lblIdPacient.Size = new System.Drawing.Size(71, 16);
            this.lblIdPacient.TabIndex = 0;
            this.lblIdPacient.Text = "ID Pacient:";
            // 
            // lblMedic
            // 
            this.lblMedic.AutoSize = true;
            this.lblMedic.Location = new System.Drawing.Point(4, 90);
            this.lblMedic.Name = "lblMedic";
            this.lblMedic.Size = new System.Drawing.Size(47, 16);
            this.lblMedic.TabIndex = 1;
            this.lblMedic.Text = "Medic:";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(4, 179);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(39, 16);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "Data:";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.SystemColors.Control;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(4, 268);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 16);
            this.lblError.TabIndex = 3;
            // 
            // txtPacientId
            // 
            this.txtPacientId.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtPacientId.Location = new System.Drawing.Point(403, 4);
            this.txtPacientId.Name = "txtPacientId";
            this.txtPacientId.Size = new System.Drawing.Size(100, 22);
            this.txtPacientId.TabIndex = 4;
            // 
            // cboMedic
            // 
            this.cboMedic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cboMedic.FormattingEnabled = true;
            this.cboMedic.Location = new System.Drawing.Point(403, 93);
            this.cboMedic.Name = "cboMedic";
            this.cboMedic.Size = new System.Drawing.Size(121, 24);
            this.cboMedic.TabIndex = 5;
            // 
            // dtpData
            // 
            this.dtpData.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpData.Location = new System.Drawing.Point(403, 182);
            this.dtpData.Name = "dtpData";
            this.dtpData.ShowUpDown = true;
            this.dtpData.Size = new System.Drawing.Size(200, 22);
            this.dtpData.TabIndex = 6;
            // 
            // btnSaveConsultatie
            // 
            this.btnSaveConsultatie.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSaveConsultatie.Location = new System.Drawing.Point(403, 271);
            this.btnSaveConsultatie.Name = "btnSaveConsultatie";
            this.btnSaveConsultatie.Size = new System.Drawing.Size(75, 23);
            this.btnSaveConsultatie.TabIndex = 7;
            this.btnSaveConsultatie.Text = "Salvează";
            this.btnSaveConsultatie.UseVisualStyleBackColor = false;
            // 
            // FormAddConsultatie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormAddConsultatie";
            this.Text = "FormAddConsultatie";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblIdPacient;
        private System.Windows.Forms.Label lblMedic;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtPacientId;
        private System.Windows.Forms.ComboBox cboMedic;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.Button btnSaveConsultatie;
    }
}