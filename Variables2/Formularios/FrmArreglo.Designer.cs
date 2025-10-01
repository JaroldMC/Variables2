namespace Variables2.Formularios
{
    partial class FrmArreglo
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
            this.gbEdades = new System.Windows.Forms.GroupBox();
            this.lblMenor = new System.Windows.Forms.Label();
            this.lblMayor = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.lbEdades = new System.Windows.Forms.ListBox();
            this.tbEdades = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbEdades.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbEdades
            // 
            this.gbEdades.Controls.Add(this.lblMenor);
            this.gbEdades.Controls.Add(this.lblMayor);
            this.gbEdades.Controls.Add(this.lblPromedio);
            this.gbEdades.Controls.Add(this.lbEdades);
            this.gbEdades.Controls.Add(this.tbEdades);
            this.gbEdades.Controls.Add(this.label1);
            this.gbEdades.Location = new System.Drawing.Point(34, 41);
            this.gbEdades.Name = "gbEdades";
            this.gbEdades.Size = new System.Drawing.Size(219, 516);
            this.gbEdades.TabIndex = 0;
            this.gbEdades.TabStop = false;
            this.gbEdades.Text = "Edades: 0";
            this.gbEdades.Enter += new System.EventHandler(this.gbEdades_Enter);
            // 
            // lblMenor
            // 
            this.lblMenor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMenor.Location = new System.Drawing.Point(20, 476);
            this.lblMenor.Name = "lblMenor";
            this.lblMenor.Size = new System.Drawing.Size(160, 48);
            this.lblMenor.TabIndex = 5;
            this.lblMenor.Text = "Menor: 0";
            // 
            // lblMayor
            // 
            this.lblMayor.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMayor.Location = new System.Drawing.Point(20, 428);
            this.lblMayor.Name = "lblMayor";
            this.lblMayor.Size = new System.Drawing.Size(160, 48);
            this.lblMayor.TabIndex = 4;
            this.lblMayor.Text = "Mayor: 0";
            // 
            // lblPromedio
            // 
            this.lblPromedio.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPromedio.Location = new System.Drawing.Point(24, 380);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(160, 48);
            this.lblPromedio.TabIndex = 3;
            this.lblPromedio.Text = "Promedio: 0";
            this.lblPromedio.Click += new System.EventHandler(this.lblPromedio_Click);
            // 
            // lbEdades
            // 
            this.lbEdades.FormattingEnabled = true;
            this.lbEdades.ItemHeight = 16;
            this.lbEdades.Location = new System.Drawing.Point(23, 96);
            this.lbEdades.Name = "lbEdades";
            this.lbEdades.Size = new System.Drawing.Size(161, 260);
            this.lbEdades.TabIndex = 2;
            // 
            // tbEdades
            // 
            this.tbEdades.Location = new System.Drawing.Point(23, 55);
            this.tbEdades.Name = "tbEdades";
            this.tbEdades.Size = new System.Drawing.Size(161, 22);
            this.tbEdades.TabIndex = 1;
            this.tbEdades.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbEdades_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese la edad:";
            // 
            // FrmArreglo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 658);
            this.Controls.Add(this.gbEdades);
            this.MaximizeBox = false;
            this.Name = "FrmArreglo";
            this.Text = "Arreglos";
            this.gbEdades.ResumeLayout(false);
            this.gbEdades.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEdades;
        private System.Windows.Forms.TextBox tbEdades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.ListBox lbEdades;
        private System.Windows.Forms.Label lblMayor;
        private System.Windows.Forms.Label lblMenor;
    }
}