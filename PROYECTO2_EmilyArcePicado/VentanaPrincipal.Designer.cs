namespace PROYECTO2_EmilyArcePicado
{
    partial class VentanaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbVentanaPrincipal = new System.Windows.Forms.Label();
            this.btnAdministrativa = new System.Windows.Forms.Button();
            this.btnRegistroDeMarcas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbVentanaPrincipal
            // 
            this.lbVentanaPrincipal.AutoSize = true;
            this.lbVentanaPrincipal.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVentanaPrincipal.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.lbVentanaPrincipal.Location = new System.Drawing.Point(173, 9);
            this.lbVentanaPrincipal.Name = "lbVentanaPrincipal";
            this.lbVentanaPrincipal.Size = new System.Drawing.Size(261, 26);
            this.lbVentanaPrincipal.TabIndex = 2;
            this.lbVentanaPrincipal.Text = "RECURSOS HUMANOS ";
            // 
            // btnAdministrativa
            // 
            this.btnAdministrativa.BackColor = System.Drawing.Color.White;
            this.btnAdministrativa.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministrativa.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.btnAdministrativa.Location = new System.Drawing.Point(331, 129);
            this.btnAdministrativa.Name = "btnAdministrativa";
            this.btnAdministrativa.Size = new System.Drawing.Size(208, 81);
            this.btnAdministrativa.TabIndex = 1;
            this.btnAdministrativa.Text = "ADMINISTRATIVA";
            this.btnAdministrativa.UseVisualStyleBackColor = false;
            this.btnAdministrativa.Click += new System.EventHandler(this.btnAdministrativa_Click);
            // 
            // btnRegistroDeMarcas
            // 
            this.btnRegistroDeMarcas.BackColor = System.Drawing.Color.White;
            this.btnRegistroDeMarcas.BackgroundImage = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.btnRegistroDeMarcas.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroDeMarcas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRegistroDeMarcas.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.btnRegistroDeMarcas.Location = new System.Drawing.Point(29, 129);
            this.btnRegistroDeMarcas.Name = "btnRegistroDeMarcas";
            this.btnRegistroDeMarcas.Size = new System.Drawing.Size(226, 81);
            this.btnRegistroDeMarcas.TabIndex = 0;
            this.btnRegistroDeMarcas.Text = "REGISTO DE MARCAS";
            this.btnRegistroDeMarcas.UseVisualStyleBackColor = false;
            this.btnRegistroDeMarcas.Click += new System.EventHandler(this.btnRegistroDeMarcas_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 265);
            this.Controls.Add(this.lbVentanaPrincipal);
            this.Controls.Add(this.btnAdministrativa);
            this.Controls.Add(this.btnRegistroDeMarcas);
            this.Name = "VentanaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VENTANA PRINCIPAL";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistroDeMarcas;
        private System.Windows.Forms.Button btnAdministrativa;
        private System.Windows.Forms.Label lbVentanaPrincipal;
    }
}

