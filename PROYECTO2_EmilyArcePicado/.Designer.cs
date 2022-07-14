namespace PROYECTO2_EmilyArcePicado
{
    partial class RegistroDeMarcas
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
            this.lbRegistroDeMarcas = new System.Windows.Forms.Label();
            this.lbCedula = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbRegistroDeMarcas
            // 
            this.lbRegistroDeMarcas.AutoSize = true;
            this.lbRegistroDeMarcas.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegistroDeMarcas.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.lbRegistroDeMarcas.Location = new System.Drawing.Point(96, 9);
            this.lbRegistroDeMarcas.Name = "lbRegistroDeMarcas";
            this.lbRegistroDeMarcas.Size = new System.Drawing.Size(209, 21);
            this.lbRegistroDeMarcas.TabIndex = 0;
            this.lbRegistroDeMarcas.Text = "REGISTRO DE MARCAS";
            // 
            // lbCedula
            // 
            this.lbCedula.AutoSize = true;
            this.lbCedula.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCedula.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.lbCedula.Location = new System.Drawing.Point(144, 76);
            this.lbCedula.Name = "lbCedula";
            this.lbCedula.Size = new System.Drawing.Size(92, 23);
            this.lbCedula.TabIndex = 1;
            this.lbCedula.Text = "CEDULA";
            this.lbCedula.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(242, 22);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.button1.Location = new System.Drawing.Point(109, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 70);
            this.button1.TabIndex = 4;
            this.button1.Text = "MARCAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // RegistroDeMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 299);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbCedula);
            this.Controls.Add(this.lbRegistroDeMarcas);
            this.Name = "RegistroDeMarcas";
            this.Text = "REGISTRO DE MARCAS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistroDeMarcas_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRegistroDeMarcas;
        private System.Windows.Forms.Label lbCedula;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}