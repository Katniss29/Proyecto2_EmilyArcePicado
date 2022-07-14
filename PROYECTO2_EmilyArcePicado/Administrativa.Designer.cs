namespace PROYECTO2_EmilyArcePicado
{
    partial class Administrativa
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
            this.btnProcesosEspecificos = new System.Windows.Forms.Button();
            this.btnSeguridad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMantenimiento = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProcesosEspecificos
            // 
            this.btnProcesosEspecificos.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcesosEspecificos.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.btnProcesosEspecificos.Location = new System.Drawing.Point(299, 90);
            this.btnProcesosEspecificos.Name = "btnProcesosEspecificos";
            this.btnProcesosEspecificos.Size = new System.Drawing.Size(213, 61);
            this.btnProcesosEspecificos.TabIndex = 1;
            this.btnProcesosEspecificos.Text = "PROCESOS ESPECIFICOS";
            this.btnProcesosEspecificos.UseVisualStyleBackColor = true;
           
            // 
            // btnSeguridad
            // 
            this.btnSeguridad.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeguridad.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.btnSeguridad.Location = new System.Drawing.Point(561, 90);
            this.btnSeguridad.Name = "btnSeguridad";
            this.btnSeguridad.Size = new System.Drawing.Size(213, 61);
            this.btnSeguridad.TabIndex = 2;
            this.btnSeguridad.Text = "SEGURIDAD";
            this.btnSeguridad.UseVisualStyleBackColor = true;
            this.btnSeguridad.Click += new System.EventHandler(this.btnSeguridad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.label1.Location = new System.Drawing.Point(247, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "MANTENIMIENTO DEL SISTEMA";
            // 
            // btnMantenimiento
            // 
            this.btnMantenimiento.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenimiento.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.btnMantenimiento.Location = new System.Drawing.Point(40, 90);
            this.btnMantenimiento.Name = "btnMantenimiento";
            this.btnMantenimiento.Size = new System.Drawing.Size(213, 61);
            this.btnMantenimiento.TabIndex = 4;
            this.btnMantenimiento.Text = "MANTENIMIENTO";
            this.btnMantenimiento.UseMnemonic = false;
            this.btnMantenimiento.UseVisualStyleBackColor = true;
            this.btnMantenimiento.Click += new System.EventHandler(this.btnMantenimiento_Click_1);
            // 
            // Administrativa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 189);
            this.Controls.Add(this.btnMantenimiento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSeguridad);
            this.Controls.Add(this.btnProcesosEspecificos);
            this.Name = "Administrativa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADMINISTRATIVA";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Administrativa_FormClosing);
         
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnProcesosEspecificos;
        private System.Windows.Forms.Button btnSeguridad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMantenimiento;
    }
}