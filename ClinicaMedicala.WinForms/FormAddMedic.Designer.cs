namespace ClinicaMedicala.WinForms
{
    partial class FormAddMedic
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
            this.lblNume = new System.Windows.Forms.Label();
            this.lblVarsta = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblSpec = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtVarsta = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.comboSpecializare = new System.Windows.Forms.ComboBox();
            this.btnSaveMedic = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.lblNume, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblVarsta, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTelefon, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblSpec, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblError, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtNume, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtVarsta, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTelefon, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.comboSpecializare, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.btnSaveMedic, 1, 4);
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
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(4, 1);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(46, 16);
            this.lblNume.TabIndex = 0;
            this.lblNume.Text = "Nume:";
            // 
            // lblVarsta
            // 
            this.lblVarsta.AutoSize = true;
            this.lblVarsta.Location = new System.Drawing.Point(4, 90);
            this.lblVarsta.Name = "lblVarsta";
            this.lblVarsta.Size = new System.Drawing.Size(49, 16);
            this.lblVarsta.TabIndex = 1;
            this.lblVarsta.Text = "Vârstă:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(4, 179);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(56, 16);
            this.lblTelefon.TabIndex = 2;
            this.lblTelefon.Text = "Telefon:";
            // 
            // lblSpec
            // 
            this.lblSpec.AutoSize = true;
            this.lblSpec.Location = new System.Drawing.Point(4, 268);
            this.lblSpec.Name = "lblSpec";
            this.lblSpec.Size = new System.Drawing.Size(85, 16);
            this.lblSpec.TabIndex = 3;
            this.lblSpec.Text = "Specializare:";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(4, 357);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 16);
            this.lblError.TabIndex = 4;
            // 
            // txtNume
            // 
            this.txtNume.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNume.Location = new System.Drawing.Point(403, 4);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(100, 22);
            this.txtNume.TabIndex = 5;
            // 
            // txtVarsta
            // 
            this.txtVarsta.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtVarsta.Location = new System.Drawing.Point(403, 93);
            this.txtVarsta.Name = "txtVarsta";
            this.txtVarsta.Size = new System.Drawing.Size(100, 22);
            this.txtVarsta.TabIndex = 6;
            // 
            // txtTelefon
            // 
            this.txtTelefon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtTelefon.Location = new System.Drawing.Point(403, 182);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 22);
            this.txtTelefon.TabIndex = 7;
            // 
            // comboSpecializare
            // 
            this.comboSpecializare.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.comboSpecializare.FormattingEnabled = true;
            this.comboSpecializare.Location = new System.Drawing.Point(403, 271);
            this.comboSpecializare.Name = "comboSpecializare";
            this.comboSpecializare.Size = new System.Drawing.Size(121, 24);
            this.comboSpecializare.TabIndex = 8;
            // 
            // btnSaveMedic
            // 
            this.btnSaveMedic.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSaveMedic.Location = new System.Drawing.Point(403, 360);
            this.btnSaveMedic.Name = "btnSaveMedic";
            this.btnSaveMedic.Size = new System.Drawing.Size(75, 23);
            this.btnSaveMedic.TabIndex = 9;
            this.btnSaveMedic.Text = "Salvează";
            this.btnSaveMedic.UseVisualStyleBackColor = false;
            // 
            // FormAddMedic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FormAddMedic";
            this.Text = "FormAddMedic";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblVarsta;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblSpec;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtVarsta;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.ComboBox comboSpecializare;
        private System.Windows.Forms.Button btnSaveMedic;
    }
}