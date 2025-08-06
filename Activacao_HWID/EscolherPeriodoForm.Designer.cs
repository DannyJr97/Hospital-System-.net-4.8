namespace Hospital97.Activacao_HWID
{
    partial class EscolherPeriodoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EscolherPeriodoForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbPeriodo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGerarChaveFinal = new Guna.UI2.WinForms.Guna2Button();
            this.btnCopiarChave = new Guna.UI2.WinForms.Guna2Button();
            this.button1 = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtChaveGerada = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblHWID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cmbPeriodo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnGerarChaveFinal);
            this.panel1.Location = new System.Drawing.Point(12, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(278, 137);
            this.panel1.TabIndex = 17;
            // 
            // cmbPeriodo
            // 
            this.cmbPeriodo.BackColor = System.Drawing.Color.Transparent;
            this.cmbPeriodo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbPeriodo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPeriodo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPeriodo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbPeriodo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbPeriodo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbPeriodo.ItemHeight = 30;
            this.cmbPeriodo.Location = new System.Drawing.Point(14, 48);
            this.cmbPeriodo.Name = "cmbPeriodo";
            this.cmbPeriodo.Size = new System.Drawing.Size(246, 36);
            this.cmbPeriodo.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(20, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Insira o período de activação :";
            // 
            // btnGerarChaveFinal
            // 
            this.btnGerarChaveFinal.BorderColor = System.Drawing.Color.White;
            this.btnGerarChaveFinal.BorderRadius = 10;
            this.btnGerarChaveFinal.BorderThickness = 2;
            this.btnGerarChaveFinal.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGerarChaveFinal.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGerarChaveFinal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGerarChaveFinal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGerarChaveFinal.FillColor = System.Drawing.Color.Gray;
            this.btnGerarChaveFinal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarChaveFinal.ForeColor = System.Drawing.Color.White;
            this.btnGerarChaveFinal.Location = new System.Drawing.Point(14, 90);
            this.btnGerarChaveFinal.Name = "btnGerarChaveFinal";
            this.btnGerarChaveFinal.Size = new System.Drawing.Size(146, 35);
            this.btnGerarChaveFinal.TabIndex = 12;
            this.btnGerarChaveFinal.Text = "Gerar Chave";
            this.btnGerarChaveFinal.Click += new System.EventHandler(this.btnGerarChaveFinal_Click_1);
            // 
            // btnCopiarChave
            // 
            this.btnCopiarChave.BorderColor = System.Drawing.Color.White;
            this.btnCopiarChave.BorderRadius = 5;
            this.btnCopiarChave.BorderThickness = 2;
            this.btnCopiarChave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCopiarChave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCopiarChave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCopiarChave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCopiarChave.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnCopiarChave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopiarChave.ForeColor = System.Drawing.Color.White;
            this.btnCopiarChave.Location = new System.Drawing.Point(13, 50);
            this.btnCopiarChave.Name = "btnCopiarChave";
            this.btnCopiarChave.Size = new System.Drawing.Size(247, 37);
            this.btnCopiarChave.TabIndex = 13;
            this.btnCopiarChave.Text = "Copiar chave";
            this.btnCopiarChave.Click += new System.EventHandler(this.btnCopiarChave_Click_1);
            // 
            // button1
            // 
            this.button1.BorderColor = System.Drawing.Color.White;
            this.button1.BorderRadius = 10;
            this.button1.BorderThickness = 2;
            this.button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.button1.FillColor = System.Drawing.Color.ForestGreen;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(38, 309);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 35);
            this.button1.TabIndex = 11;
            this.button1.Text = "Voltar a tela de Activação";
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "Activação do Software";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtChaveGerada);
            this.panel2.Controls.Add(this.btnCopiarChave);
            this.panel2.Location = new System.Drawing.Point(12, 190);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(278, 97);
            this.panel2.TabIndex = 20;
            // 
            // txtChaveGerada
            // 
            this.txtChaveGerada.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtChaveGerada.DefaultText = "";
            this.txtChaveGerada.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtChaveGerada.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtChaveGerada.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChaveGerada.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtChaveGerada.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtChaveGerada.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtChaveGerada.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtChaveGerada.Location = new System.Drawing.Point(13, 8);
            this.txtChaveGerada.Name = "txtChaveGerada";
            this.txtChaveGerada.PlaceholderText = "";
            this.txtChaveGerada.SelectedText = "";
            this.txtChaveGerada.Size = new System.Drawing.Size(247, 36);
            this.txtChaveGerada.TabIndex = 14;
            // 
            // lblHWID
            // 
            this.lblHWID.AutoSize = true;
            this.lblHWID.Location = new System.Drawing.Point(9, 348);
            this.lblHWID.Name = "lblHWID";
            this.lblHWID.Size = new System.Drawing.Size(10, 13);
            this.lblHWID.TabIndex = 21;
            this.lblHWID.Text = ".";
            // 
            // EscolherPeriodoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(304, 371);
            this.Controls.Add(this.lblHWID);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EscolherPeriodoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Activação do Software";
            this.Load += new System.EventHandler(this.EscolherPeriodoForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnCopiarChave;
        private Guna.UI2.WinForms.Guna2Button btnGerarChaveFinal;
        private Guna.UI2.WinForms.Guna2Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbPeriodo;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtChaveGerada;
        private System.Windows.Forms.Label lblHWID;
    }
}