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
            this.marcarRegistro = new System.Windows.Forms.Button();
            this.webCam = new System.Windows.Forms.ComboBox();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtMarcar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            // marcarRegistro
            // 
            this.marcarRegistro.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcarRegistro.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.marcarRegistro.Location = new System.Drawing.Point(109, 189);
            this.marcarRegistro.Name = "marcarRegistro";
            this.marcarRegistro.Size = new System.Drawing.Size(158, 70);
            this.marcarRegistro.TabIndex = 4;
            this.marcarRegistro.Text = "MARCAR";
            this.marcarRegistro.UseVisualStyleBackColor = true;
            this.marcarRegistro.Click += new System.EventHandler(this.marcarRegistro_Click);
            // 
            // webCam
            // 
            this.webCam.FormattingEnabled = true;
            this.webCam.Location = new System.Drawing.Point(429, 28);
            this.webCam.Name = "webCam";
            this.webCam.Size = new System.Drawing.Size(121, 24);
            this.webCam.TabIndex = 5;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.btnGrabar.Location = new System.Drawing.Point(488, 339);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(158, 70);
            this.btnGrabar.TabIndex = 8;
            this.btnGrabar.Text = "GRABAR";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(592, 85);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 191);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(349, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(206, 191);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // txtMarcar
            // 
            this.txtMarcar.Location = new System.Drawing.Point(100, 131);
            this.txtMarcar.Name = "txtMarcar";
            this.txtMarcar.Size = new System.Drawing.Size(205, 22);
            this.txtMarcar.TabIndex = 9;
            // 
            // RegistroDeMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 498);
            this.Controls.Add(this.txtMarcar);
            this.Controls.Add(this.btnGrabar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.webCam);
            this.Controls.Add(this.marcarRegistro);
            this.Controls.Add(this.lbCedula);
            this.Controls.Add(this.lbRegistroDeMarcas);
            this.Name = "RegistroDeMarcas";
            this.Text = "REGISTRO DE MARCAS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistroDeMarcas_FormClosing);
            this.Load += new System.EventHandler(this.RegistroDeMarcas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRegistroDeMarcas;
        private System.Windows.Forms.Label lbCedula;
        private System.Windows.Forms.Button marcarRegistro;
        private System.Windows.Forms.ComboBox webCam;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtMarcar;
    }
}