namespace ClinicaMedicala.WinForms
{
    partial class FormAddPacient
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
            this.lblId = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblVarsta = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtVarsta = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.btnSavePacient = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblId, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblNume, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblVarsta, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTelefon, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblError, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtId, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNume, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtVarsta, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtTelefon, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSavePacient, 1, 4);
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
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(4, 1);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(23, 16);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(4, 90);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(46, 16);
            this.lblNume.TabIndex = 1;
            this.lblNume.Text = "Nume:";
            // 
            // lblVarsta
            // 
            this.lblVarsta.AutoSize = true;
            this.lblVarsta.Location = new System.Drawing.Point(4, 179);
            this.lblVarsta.Name = "lblVarsta";
            this.lblVarsta.Size = new System.Drawing.Size(49, 16);
            this.lblVarsta.TabIndex = 2;
            this.lblVarsta.Text = "Vârstă:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(4, 268);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(56, 16);
            this.lblTelefon.TabIndex = 3;
            this.lblTelefon.Text = "Telefon:";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(4, 357);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 16);
            this.lblError.TabIndex = 4;
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtId.Location = new System.Drawing.Point(403, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 22);
            this.txtId.TabIndex = 5;
            // 
            // txtNume
            // 
            this.txtNume.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNume.Location = new System.Drawing.Point(403, 93);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(100, 22);
            this.txtNume.TabIndex = 6;
            // 
            // txtVarsta
            // 
            this.txtVarsta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtVarsta.Location = new System.Drawing.Point(403, 182);
            this.txtVarsta.Name = "txtVarsta";
            this.txtVarsta.Size = new System.Drawing.Size(100, 22);
            this.txtVarsta.TabIndex = 7;
            // 
            // txtTelefon
            // 
            this.txtTelefon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtTelefon.Location = new System.Drawing.Point(403, 271);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 22);
            this.txtTelefon.TabIndex = 8;
            // 
            // btnSavePacient
            // 
            this.btnSavePacient.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSavePacient.Location = new System.Drawing.Point(403, 360);
            this.btnSavePacient.Name = "btnSavePacient";
            this.btnSavePacient.Size = new System.Drawing.Size(75, 23);
            this.btnSavePacient.TabIndex = 9;
            this.btnSavePacient.Text = "Salvează";
            this.btnSavePacient.UseVisualStyleBackColor = false;
            // 
            // FormAddPacient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormAddPacient";
            this.Text = "FormAddPacient";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblVarsta;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtVarsta;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Button btnSavePacient;
    }
}