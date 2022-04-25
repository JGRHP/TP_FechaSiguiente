
namespace Fecha
{
    partial class Form2
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
            this.lblDia = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.txtAnio = new System.Windows.Forms.TextBox();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.lblLeyenda = new System.Windows.Forms.Label();
            this.btnVerFecha = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.Location = new System.Drawing.Point(53, 18);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(24, 15);
            this.lblDia.TabIndex = 0;
            this.lblDia.Text = "Día";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(168, 18);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(29, 15);
            this.lblMes.TabIndex = 1;
            this.lblMes.Text = "Mes";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(296, 18);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(29, 15);
            this.lblAnio.TabIndex = 2;
            this.lblAnio.Text = "Año";
            // 
            // txtAnio
            // 
            this.txtAnio.Location = new System.Drawing.Point(280, 47);
            this.txtAnio.Name = "txtAnio";
            this.txtAnio.Size = new System.Drawing.Size(64, 23);
            this.txtAnio.TabIndex = 3;
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(152, 47);
            this.txtMes.MaxLength = 2;
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(64, 23);
            this.txtMes.TabIndex = 4;
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(34, 47);
            this.txtDia.MaxLength = 2;
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(64, 23);
            this.txtDia.TabIndex = 5;
            //this.txtDia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDia_KeyPress);
            //this.txtDia.Validated += new System.EventHandler(this.btnVerFecha_Click);
            // 
            // lblLeyenda
            // 
            this.lblLeyenda.AutoSize = true;
            this.lblLeyenda.Location = new System.Drawing.Point(80, 148);
            this.lblLeyenda.Name = "lblLeyenda";
            this.lblLeyenda.Size = new System.Drawing.Size(216, 15);
            this.lblLeyenda.TabIndex = 6;
            this.lblLeyenda.Text = "Ingrese una fecha en formato numérico";
            // 
            // btnVerFecha
            // 
            this.btnVerFecha.Location = new System.Drawing.Point(138, 115);
            this.btnVerFecha.Name = "btnVerFecha";
            this.btnVerFecha.Size = new System.Drawing.Size(97, 20);
            this.btnVerFecha.TabIndex = 7;
            this.btnVerFecha.Text = "VerFecha";
            this.btnVerFecha.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnVerFecha.UseVisualStyleBackColor = true;
            this.btnVerFecha.Click += new System.EventHandler(this.btnVerFecha_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(391, 172);
            this.Controls.Add(this.btnVerFecha);
            this.Controls.Add(this.lblLeyenda);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.txtAnio);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.lblDia);
            this.Name = "Form2";
            this.Text = "Fecha";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.TextBox txtAnio;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.Label lblLeyenda;
        private System.Windows.Forms.Button btnVerFecha;
    }
}