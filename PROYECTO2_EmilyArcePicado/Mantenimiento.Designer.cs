namespace PROYECTO2_EmilyArcePicado
{
    partial class Mantenimiento
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
            this.btnMantenimientoEmpleados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMantenimientoEmpleados
            // 
            this.btnMantenimientoEmpleados.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMantenimientoEmpleados.Location = new System.Drawing.Point(12, 65);
            this.btnMantenimientoEmpleados.Name = "btnMantenimientoEmpleados";
            this.btnMantenimientoEmpleados.Size = new System.Drawing.Size(247, 74);
            this.btnMantenimientoEmpleados.TabIndex = 0;
            this.btnMantenimientoEmpleados.Text = "MANTENIMIENTO DE LOS EMPLEADOS";
            this.btnMantenimientoEmpleados.UseVisualStyleBackColor = true;
            this.btnMantenimientoEmpleados.Click += new System.EventHandler(this.btnMantenimientoEmpleados_Click);
            // 
            // Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMantenimientoEmpleados);
            this.Name = "Mantenimiento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenimiento";
            this.Load += new System.EventHandler(this.MANTENIMIENTO_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMantenimientoEmpleados;
    }
}