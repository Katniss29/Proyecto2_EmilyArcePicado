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
            this.clmCedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.btnInsertarEmpleados = new System.Windows.Forms.Button();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCedulaEliminar = new System.Windows.Forms.TextBox();
            this.lbCedulaEliminar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtCodigoModificar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbModificar = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.clmCedula,
            this.clmNombre,
            this.clmApellido,
            this.clmApellido2,
            this.clmDireccion,
            this.clmTelefono,
            this.clmSalariosHoras});
            this.dataGridView1.Location = new System.Drawing.Point(639, 277);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(584, 157);
            this.dataGridView1.TabIndex = 0;
            // 
            // clmCodigo
            // 
            this.clmCodigo.HeaderText = "CODIGO";
            this.clmCodigo.MinimumWidth = 6;
            this.clmCodigo.Name = "clmCodigo";
            this.clmCodigo.Width = 125;
            // 
            // clmCedula
            // 
            this.clmCedula.HeaderText = "CEDULA";
            this.clmCedula.MinimumWidth = 6;
            this.clmCedula.Name = "clmCedula";
            this.clmCedula.Width = 125;
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
            this.button1.Location = new System.Drawing.Point(20, 639);
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
            this.lbPrimerApellido.Location = new System.Drawing.Point(28, 253);
            this.lbPrimerApellido.Name = "lbPrimerApellido";
            this.lbPrimerApellido.Size = new System.Drawing.Size(189, 23);
            this.lbPrimerApellido.TabIndex = 3;
            this.lbPrimerApellido.Text = "PRIMER APELLIDO";
            // 
            // lbSegundoApellido
            // 
            this.lbSegundoApellido.AutoSize = true;
            this.lbSegundoApellido.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSegundoApellido.Location = new System.Drawing.Point(28, 309);
            this.lbSegundoApellido.Name = "lbSegundoApellido";
            this.lbSegundoApellido.Size = new System.Drawing.Size(206, 23);
            this.lbSegundoApellido.TabIndex = 4;
            this.lbSegundoApellido.Text = "SEGUNDO APELLIDO";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(28, 205);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(95, 23);
            this.lbNombre.TabIndex = 5;
            this.lbNombre.Text = "NOMBRE";
            // 
            // lbDireccion
            // 
            this.lbDireccion.AutoSize = true;
            this.lbDireccion.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDireccion.Location = new System.Drawing.Point(28, 360);
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
            this.lbTelefono.Location = new System.Drawing.Point(28, 411);
            this.lbTelefono.Name = "lbTelefono";
            this.lbTelefono.Size = new System.Drawing.Size(115, 23);
            this.lbTelefono.TabIndex = 7;
            this.lbTelefono.Text = "TELEFONO";
            // 
            // lbSalarioHoras
            // 
            this.lbSalarioHoras.AutoSize = true;
            this.lbSalarioHoras.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalarioHoras.Location = new System.Drawing.Point(28, 461);
            this.lbSalarioHoras.Name = "lbSalarioHoras";
            this.lbSalarioHoras.Size = new System.Drawing.Size(210, 23);
            this.lbSalarioHoras.TabIndex = 8;
            this.lbSalarioHoras.Text = "SALARIO POR HORAS";
            // 
            // lbPrincipalEmpleados
            // 
            this.lbPrincipalEmpleados.AutoSize = true;
            this.lbPrincipalEmpleados.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrincipalEmpleados.Location = new System.Drawing.Point(479, 9);
            this.lbPrincipalEmpleados.Name = "lbPrincipalEmpleados";
            this.lbPrincipalEmpleados.Size = new System.Drawing.Size(380, 23);
            this.lbPrincipalEmpleados.TabIndex = 9;
            this.lbPrincipalEmpleados.Text = "MANTENIMIENTO DE LOS EMPLEADOS";
            // 
            // txtCodigoEmpleado
            // 
            this.txtCodigoEmpleado.Location = new System.Drawing.Point(275, 112);
            this.txtCodigoEmpleado.Name = "txtCodigoEmpleado";
            this.txtCodigoEmpleado.Size = new System.Drawing.Size(169, 22);
            this.txtCodigoEmpleado.TabIndex = 10;
            // 
            // txtNombreEmpleado
            // 
            this.txtNombreEmpleado.Location = new System.Drawing.Point(275, 206);
            this.txtNombreEmpleado.Name = "txtNombreEmpleado";
            this.txtNombreEmpleado.Size = new System.Drawing.Size(169, 22);
            this.txtNombreEmpleado.TabIndex = 11;
            // 
            // txtPrimerApellidoEmpleado
            // 
            this.txtPrimerApellidoEmpleado.Location = new System.Drawing.Point(275, 253);
            this.txtPrimerApellidoEmpleado.Name = "txtPrimerApellidoEmpleado";
            this.txtPrimerApellidoEmpleado.Size = new System.Drawing.Size(169, 22);
            this.txtPrimerApellidoEmpleado.TabIndex = 12;
            // 
            // txtSegundoApellidoEmpleado
            // 
            this.txtSegundoApellidoEmpleado.Location = new System.Drawing.Point(275, 309);
            this.txtSegundoApellidoEmpleado.Name = "txtSegundoApellidoEmpleado";
            this.txtSegundoApellidoEmpleado.Size = new System.Drawing.Size(169, 22);
            this.txtSegundoApellidoEmpleado.TabIndex = 13;
            // 
            // txtDireccionEmpleado
            // 
            this.txtDireccionEmpleado.Location = new System.Drawing.Point(275, 361);
            this.txtDireccionEmpleado.Name = "txtDireccionEmpleado";
            this.txtDireccionEmpleado.Size = new System.Drawing.Size(169, 22);
            this.txtDireccionEmpleado.TabIndex = 14;
            // 
            // txtTelefonoEmpleado
            // 
            this.txtTelefonoEmpleado.Location = new System.Drawing.Point(275, 412);
            this.txtTelefonoEmpleado.Name = "txtTelefonoEmpleado";
            this.txtTelefonoEmpleado.Size = new System.Drawing.Size(169, 22);
            this.txtTelefonoEmpleado.TabIndex = 15;
            // 
            // txtSalarioHoras
            // 
            this.txtSalarioHoras.Location = new System.Drawing.Point(275, 461);
            this.txtSalarioHoras.Name = "txtSalarioHoras";
            this.txtSalarioHoras.Size = new System.Drawing.Size(169, 22);
            this.txtSalarioHoras.TabIndex = 16;
            // 
            // btnInsertarEmpleados
            // 
            this.btnInsertarEmpleados.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarEmpleados.Location = new System.Drawing.Point(351, 639);
            this.btnInsertarEmpleados.Name = "btnInsertarEmpleados";
            this.btnInsertarEmpleados.Size = new System.Drawing.Size(159, 64);
            this.btnInsertarEmpleados.TabIndex = 17;
            this.btnInsertarEmpleados.Text = "INSERTAR EMPLEADOS";
            this.btnInsertarEmpleados.UseVisualStyleBackColor = true;
            this.btnInsertarEmpleados.Click += new System.EventHandler(this.btnInsertarEmpleados_Click);
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(275, 157);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(169, 22);
            this.txtCedula.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "CEDULA";
            // 
            // txtCedulaEliminar
            // 
            this.txtCedulaEliminar.Location = new System.Drawing.Point(962, 535);
            this.txtCedulaEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.txtCedulaEliminar.Name = "txtCedulaEliminar";
            this.txtCedulaEliminar.Size = new System.Drawing.Size(124, 22);
            this.txtCedulaEliminar.TabIndex = 25;
            // 
            // lbCedulaEliminar
            // 
            this.lbCedulaEliminar.AutoSize = true;
            this.lbCedulaEliminar.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCedulaEliminar.Location = new System.Drawing.Point(855, 538);
            this.lbCedulaEliminar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCedulaEliminar.Name = "lbCedulaEliminar";
            this.lbCedulaEliminar.Size = new System.Drawing.Size(89, 23);
            this.lbCedulaEliminar.TabIndex = 24;
            this.lbCedulaEliminar.Text = "CEDULA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(635, 473);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(588, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "INGRESE LA CEDULA DEL EMPLEADO QUE DESEA ELIMINAR ";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(700, 639);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(159, 64);
            this.btnEliminar.TabIndex = 26;
            this.btnEliminar.Text = "ELIMINAR EMPLEADO";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(1064, 639);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 64);
            this.button2.TabIndex = 27;
            this.button2.Text = "MODIFICAR EMPLEADO";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtCodigoModificar
            // 
            this.txtCodigoModificar.Location = new System.Drawing.Point(941, 175);
            this.txtCodigoModificar.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoModificar.Name = "txtCodigoModificar";
            this.txtCodigoModificar.Size = new System.Drawing.Size(124, 22);
            this.txtCodigoModificar.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(834, 178);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 29;
            this.label3.Text = "CODIGO";
            // 
            // lbModificar
            // 
            this.lbModificar.AutoSize = true;
            this.lbModificar.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModificar.Location = new System.Drawing.Point(614, 111);
            this.lbModificar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbModificar.Name = "lbModificar";
            this.lbModificar.Size = new System.Drawing.Size(597, 23);
            this.lbModificar.TabIndex = 28;
            this.lbModificar.Text = "INGRESE EL CODIGO DEL EMPLEADO QUE DESEA MODIFICAR";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(1106, 157);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(166, 79);
            this.btnBuscar.TabIndex = 31;
            this.btnBuscar.Text = "BUSCAR EMPLEADO";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // CrudEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1302, 761);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtCodigoModificar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbModificar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtCedulaEliminar);
            this.Controls.Add(this.lbCedulaEliminar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInsertarEmpleados);
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
        private System.Windows.Forms.Button btnInsertarEmpleados;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmApellido2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalariosHoras;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCedulaEliminar;
        private System.Windows.Forms.Label lbCedulaEliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtCodigoModificar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbModificar;
        private System.Windows.Forms.Button btnBuscar;
    }
}