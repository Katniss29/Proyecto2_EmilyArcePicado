namespace PROYECTO2_EmilyArcePicado
{
    partial class CrudEmpleados
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmApellido2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalariosHoras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lbPrimerApellido = new System.Windows.Forms.Label();
            this.lbSegundoApellido = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbDireccion = new System.Windows.Forms.Label();
            this.lbTelefono = new System.Windows.Forms.Label();
            this.lbSalarioHoras = new System.Windows.Forms.Label();
            this.lbPrincipalEmpleados = new System.Windows.Forms.Label();
            this.txtCodigoEmpleado = new System.Windows.Forms.TextBox();
            this.txtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.txtPrimerApellidoEmpleado = new System.Windows.Forms.TextBox();
            this.txtSegundoApellidoEmpleado = new System.Windows.Forms.TextBox();
            this.txtDireccionEmpleado = new System.Windows.Forms.TextBox();
            this.txtTelefonoEmpleado = new System.Windows.Forms.TextBox();
            this.txtSalarioHoras = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.clmNombre,
            this.clmApellido,
            this.clmApellido2,
            this.clmDireccion,
            this.clmTelefono,
            this.clmSalariosHoras});
            this.dataGridView1.Location = new System.Drawing.Point(585, 158);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(468, 157);
            this.dataGridView1.TabIndex = 0;
            // 
            // clmCodigo
            // 
            this.clmCodigo.HeaderText = "CODIGO";
            this.clmCodigo.MinimumWidth = 6;
            this.clmCodigo.Name = "clmCodigo";
            this.clmCodigo.Width = 125;
            // 
            // clmNombre
            // 
            this.clmNombre.HeaderText = "NOMBRE";
            this.clmNombre.MinimumWidth = 6;
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.Width = 125;
            // 
            // clmApellido
            // 
            this.clmApellido.HeaderText = "APELLIDO";
            this.clmApellido.MinimumWidth = 6;
            this.clmApellido.Name = "clmApellido";
            this.clmApellido.Width = 125;
            // 
            // clmApellido2
            // 
            this.clmApellido2.HeaderText = "APELLIDO";
            this.clmApellido2.MinimumWidth = 6;
            this.clmApellido2.Name = "clmApellido2";
            this.clmApellido2.Width = 125;
            // 
            // clmDireccion
            // 
            this.clmDireccion.HeaderText = "DIRECCION";
            this.clmDireccion.MinimumWidth = 6;
            this.clmDireccion.Name = "clmDireccion";
            this.clmDireccion.Width = 125;
            // 
            // clmTelefono
            // 
            this.clmTelefono.HeaderText = "TELEFONO";
            this.clmTelefono.MinimumWidth = 6;
            this.clmTelefono.Name = "clmTelefono";
            this.clmTelefono.Width = 125;
            // 
            // clmSalariosHoras
            // 
            this.clmSalariosHoras.HeaderText = "SALARIO HORAS";
            this.clmSalariosHoras.MinimumWidth = 6;
            this.clmSalariosHoras.Name = "clmSalariosHoras";
            this.clmSalariosHoras.Width = 125;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(20, 533);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 64);
            this.button1.TabIndex = 1;
            this.button1.Text = "MOSTRAR EMPLEADOS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.Location = new System.Drawing.Point(28, 112);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(87, 23);
            this.lbCodigo.TabIndex = 2;
            this.lbCodigo.Text = "CODIGO";
            // 
            // lbPrimerApellido
            // 
            this.lbPrimerApellido.AutoSize = true;
            this.lbPrimerApellido.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrimerApellido.Location = new System.Drawing.Point(28, 210);
            this.lbPrimerApellido.Name = "lbPrimerApellido";
            this.lbPrimerApellido.Size = new System.Drawing.Size(189, 23);
            this.lbPrimerApellido.TabIndex = 3;
            this.lbPrimerApellido.Text = "PRIMER APELLIDO";
            // 
            // lbSegundoApellido
            // 
            this.lbSegundoApellido.AutoSize = true;
            this.lbSegundoApellido.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSegundoApellido.Location = new System.Drawing.Point(28, 266);
            this.lbSegundoApellido.Name = "lbSegundoApellido";
            this.lbSegundoApellido.Size = new System.Drawing.Size(206, 23);
            this.lbSegundoApellido.TabIndex = 4;
            this.lbSegundoApellido.Text = "SEGUNDO APELLIDO";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(28, 162);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(95, 23);
            this.lbNombre.TabIndex = 5;
            this.lbNombre.Text = "NOMBRE";
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDireccion.Location = new System.Drawing.Point(28, 317);
            this.lbDireccion.Name = "lbDireccion";
            this.lbDireccion.Size = new System.Drawing.Size(120, 23);
            this.lbDireccion.TabIndex = 6;
            this.lbDireccion.Text = "DIRECCION";
            this.lbDireccion.UseMnemonic = false;
            // 
            // lbTelefono
            // 
            this.lbTelefono.AutoSize = true;
            this.lbTelefono.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTelefono.Location = new System.Drawing.Point(28, 368);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(115, 23);
            this.lbTelefono.TabIndex = 7;
            this.lbTelefono.Text = "TELEFONO";
            // 
            // lbSalarioHoras
            // 
            this.lbSalarioHoras.AutoSize = true;
            this.lbSalarioHoras.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalarioHoras.Location = new System.Drawing.Point(28, 418);
            this.lbSalarioHoras.Name = "lbSalarioHoras";
            this.lbSalarioHoras.Size = new System.Drawing.Size(210, 23);
            this.lbSalarioHoras.TabIndex = 8;
            this.lbSalarioHoras.Text = "SALARIO POR HORAS";
            // 
            // lbPrincipalEmpleados
            // 
            this.lbPrincipalEmpleados.AutoSize = true;
            this.lbPrincipalEmpleados.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrincipalEmpleados.Location = new System.Drawing.Point(337, 9);
            this.lbPrincipalEmpleados.Name = "lbPrincipalEmpleados";
            this.lbPrincipalEmpleados.Size = new System.Drawing.Size(380, 23);
            this.lbPrincipalEmpleados.TabIndex = 9;
            this.lbPrincipalEmpleados.Text = "MANTENIMIENTO DE LOS EMPLEADOS";
            // 
            // txtCodigoEmpleado
            // 
            this.txtCodigoEmpleado.Location = new System.Drawing.Point(247, 112);
            this.txtCodigoEmpleado.Name = "txtCodigoEmpleado";
            this.txtCodigoEmpleado.Size = new System.Drawing.Size(169, 22);
            this.txtCodigoEmpleado.TabIndex = 10;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Location = new System.Drawing.Point(247, 163);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(169, 22);
            this.txtNombreEmpleado.TabIndex = 11;
            // 
            // txtPrimerApellidoEmpleado
            // 
            this.txtPrimerApellidoEmpleado.Location = new System.Drawing.Point(247, 210);
            this.txtPrimerApellidoEmpleado.Name = "txtPrimerApellidoEmpleado";
            this.txtPrimerApellidoEmpleado.Size = new System.Drawing.Size(169, 22);
            this.txtPrimerApellidoEmpleado.TabIndex = 12;
            // 
            // txtSegundoApellidoEmpleado
            // 
            this.txtSegundoApellidoEmpleado.Location = new System.Drawing.Point(247, 267);
            this.txtSegundoApellidoEmpleado.Name = "txtSegundoApellidoEmpleado";
            this.txtSegundoApellidoEmpleado.Size = new System.Drawing.Size(169, 22);
            this.txtSegundoApellidoEmpleado.TabIndex = 13;
            // 
            // txtDireccionEmpleado
            // 
            this.txtDireccionEmpleado.Location = new System.Drawing.Point(247, 318);
            this.txtDireccionEmpleado.Name = "txtDireccionEmpleado";
            this.txtDireccionEmpleado.Size = new System.Drawing.Size(169, 22);
            this.txtDireccionEmpleado.TabIndex = 14;
            // 
            // txtTelefonoEmpleado
            // 
            this.txtTelefonoEmpleado.Location = new System.Drawing.Point(247, 369);
            this.txtTelefonoEmpleado.Name = "txtTelefonoEmpleado";
            this.txtTelefonoEmpleado.Size = new System.Drawing.Size(169, 22);
            this.txtTelefonoEmpleado.TabIndex = 15;
            // 
            // txtSalarioHoras
            // 
            this.txtSalarioHoras.Location = new System.Drawing.Point(247, 419);
            this.txtSalarioHoras.Name = "txtSalarioHoras";
            this.txtSalarioHoras.Size = new System.Drawing.Size(169, 22);
            this.txtSalarioHoras.TabIndex = 16;
            // 
            // CrudEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 646);
            this.Controls.Add(this.txtSalarioHoras);
            this.Controls.Add(this.txtTelefonoEmpleado);
            this.Controls.Add(this.txtDireccionEmpleado);
            this.Controls.Add(this.txtSegundoApellidoEmpleado);
            this.Controls.Add(this.txtPrimerApellidoEmpleado);
            this.Controls.Add(this.txtNombreEmpleado);
            this.Controls.Add(this.txtCodigoEmpleado);
            this.Controls.Add(this.lbPrincipalEmpleados);
            this.Controls.Add(this.lbSalarioHoras);
            this.Controls.Add(this.lbTelefono);
            this.Controls.Add(this.lbDireccion);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbSegundoApellido);
            this.Controls.Add(this.lbPrimerApellido);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CrudEmpleados";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crud Empleados";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmApellido2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalariosHoras;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lbPrimerApellido;
        private System.Windows.Forms.Label lbSegundoApellido;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbDireccion;
        private System.Windows.Forms.Label lbTelefono;
        private System.Windows.Forms.Label lbSalarioHoras;
        private System.Windows.Forms.Label lbPrincipalEmpleados;
        private System.Windows.Forms.TextBox txtCodigoEmpleado;
        private System.Windows.Forms.TextBox txtNombreEmpleado;
        private System.Windows.Forms.TextBox txtPrimerApellidoEmpleado;
        private System.Windows.Forms.TextBox txtSegundoApellidoEmpleado;
        private System.Windows.Forms.TextBox txtDireccionEmpleado;
        private System.Windows.Forms.TextBox txtTelefonoEmpleado;
        private System.Windows.Forms.TextBox txtSalarioHoras;
    }
}