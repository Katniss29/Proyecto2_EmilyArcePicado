namespace PROYECTO2_EmilyArcePicado
{
    partial class CrudDeducciones
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
            this.txtCodigoEliminar = new System.Windows.Forms.TextBox();
            this.txtCodigoModificar = new System.Windows.Forms.TextBox();
            this.txtRebejasSalariales = new System.Windows.Forms.TextBox();
            this.txtCodigoDeducciones = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSalarioGanado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCCSS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmIVM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmJuntaAhorro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPoliza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarDeduccion = new System.Windows.Forms.Button();
            this.btnModificarDeducciones = new System.Windows.Forms.Button();
            this.btnEliminarDeducciones = new System.Windows.Forms.Button();
            this.lbCodigoModificar = new System.Windows.Forms.Label();
            this.lbModificar = new System.Windows.Forms.Label();
            this.btnInsertarDeducciones = new System.Windows.Forms.Button();
            this.lbDepartaemento = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.btnMostrarDEDUCCIONES = new System.Windows.Forms.Button();
            this.lbMantenimientoDiasFeriados = new System.Windows.Forms.Label();
            this.txtSalarioGanada = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCCSS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIVM = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtJuntaAhorro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPoliza = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCodigoEliminar
            // 
            this.txtCodigoEliminar.Location = new System.Drawing.Point(371, 579);
            this.txtCodigoEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoEliminar.Name = "txtCodigoEliminar";
            this.txtCodigoEliminar.Size = new System.Drawing.Size(197, 22);
            this.txtCodigoEliminar.TabIndex = 70;
            // 
            // txtCodigoModificar
            // 
            this.txtCodigoModificar.Location = new System.Drawing.Point(1014, 169);
            this.txtCodigoModificar.Name = "txtCodigoModificar";
            this.txtCodigoModificar.Size = new System.Drawing.Size(197, 22);
            this.txtCodigoModificar.TabIndex = 65;
            // 
            // txtRebejasSalariales
            // 
            this.txtRebejasSalariales.Location = new System.Drawing.Point(335, 154);
            this.txtRebejasSalariales.Name = "txtRebejasSalariales";
            this.txtRebejasSalariales.Size = new System.Drawing.Size(197, 22);
            this.txtRebejasSalariales.TabIndex = 61;
            // 
            // txtCodigoDeducciones
            // 
            this.txtCodigoDeducciones.Location = new System.Drawing.Point(335, 101);
            this.txtCodigoDeducciones.Name = "txtCodigoDeducciones";
            this.txtCodigoDeducciones.Size = new System.Drawing.Size(197, 22);
            this.txtCodigoDeducciones.TabIndex = 60;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.clmNombre,
            this.clmSalarioGanado,
            this.clmCCSS,
            this.clmIVM,
            this.clmJuntaAhorro,
            this.clmPoliza});
            this.dataGridView1.Location = new System.Drawing.Point(797, 359);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(527, 150);
            this.dataGridView1.TabIndex = 56;
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
            this.clmNombre.HeaderText = "REBAJAS SALARIALES";
            this.clmNombre.MinimumWidth = 6;
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.Width = 125;
            // 
            // clmSalarioGanado
            // 
            this.clmSalarioGanado.HeaderText = "SALARIO GANADO";
            this.clmSalarioGanado.MinimumWidth = 6;
            this.clmSalarioGanado.Name = "clmSalarioGanado";
            this.clmSalarioGanado.Width = 125;
            // 
            // clmCCSS
            // 
            this.clmCCSS.HeaderText = "CCSS";
            this.clmCCSS.MinimumWidth = 6;
            this.clmCCSS.Name = "clmCCSS";
            this.clmCCSS.Width = 125;
            // 
            // clmIVM
            // 
            this.clmIVM.HeaderText = "IVM";
            this.clmIVM.MinimumWidth = 6;
            this.clmIVM.Name = "clmIVM";
            this.clmIVM.Width = 125;
            // 
            // clmJuntaAhorro
            // 
            this.clmJuntaAhorro.HeaderText = "JUNTA AHORRO";
            this.clmJuntaAhorro.MinimumWidth = 6;
            this.clmJuntaAhorro.Name = "clmJuntaAhorro";
            this.clmJuntaAhorro.Width = 125;
            // 
            // clmPoliza
            // 
            this.clmPoliza.HeaderText = "POLIZA";
            this.clmPoliza.MinimumWidth = 6;
            this.clmPoliza.Name = "clmPoliza";
            this.clmPoliza.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.label1.Location = new System.Drawing.Point(150, 579);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 71;
            this.label1.Text = "CODIGO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.label2.Location = new System.Drawing.Point(40, 522);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(637, 23);
            this.label2.TabIndex = 69;
            this.label2.Text = "INGRESE EL CODIGO DEL DEPARTAMENTO QUE DESEA ELIMINAR ";
            // 
            // btnBuscarDeduccion
            // 
            this.btnBuscarDeduccion.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDeduccion.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.btnBuscarDeduccion.Location = new System.Drawing.Point(880, 228);
            this.btnBuscarDeduccion.Name = "btnBuscarDeduccion";
            this.btnBuscarDeduccion.Size = new System.Drawing.Size(243, 82);
            this.btnBuscarDeduccion.TabIndex = 68;
            this.btnBuscarDeduccion.Text = "BUSCAR DEDUCCION";
            this.btnBuscarDeduccion.UseVisualStyleBackColor = true;
            this.btnBuscarDeduccion.Click += new System.EventHandler(this.btnBuscarDeduccion_Click);
            // 
            // btnModificarDeducciones
            // 
            this.btnModificarDeducciones.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarDeducciones.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.btnModificarDeducciones.Location = new System.Drawing.Point(999, 683);
            this.btnModificarDeducciones.Name = "btnModificarDeducciones";
            this.btnModificarDeducciones.Size = new System.Drawing.Size(243, 82);
            this.btnModificarDeducciones.TabIndex = 67;
            this.btnModificarDeducciones.Text = "MODIFICAR DEDUCCIONES";
            this.btnModificarDeducciones.UseVisualStyleBackColor = true;
            this.btnModificarDeducciones.Click += new System.EventHandler(this.btnModificarDeducciones_Click);
            // 
            // btnEliminarDeducciones
            // 
            this.btnEliminarDeducciones.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDeducciones.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.btnEliminarDeducciones.Location = new System.Drawing.Point(681, 683);
            this.btnEliminarDeducciones.Name = "btnEliminarDeducciones";
            this.btnEliminarDeducciones.Size = new System.Drawing.Size(243, 82);
            this.btnEliminarDeducciones.TabIndex = 66;
            this.btnEliminarDeducciones.Text = "ELIMINAR DEDUCCIONES";
            this.btnEliminarDeducciones.UseVisualStyleBackColor = true;
            this.btnEliminarDeducciones.Click += new System.EventHandler(this.btnEliminarDeducciones_Click);
            // 
            // lbCodigoModificar
            // 
            this.lbCodigoModificar.AutoSize = true;
            this.lbCodigoModificar.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigoModificar.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.lbCodigoModificar.Location = new System.Drawing.Point(793, 169);
            this.lbCodigoModificar.Name = "lbCodigoModificar";
            this.lbCodigoModificar.Size = new System.Drawing.Size(87, 23);
            this.lbCodigoModificar.TabIndex = 64;
            this.lbCodigoModificar.Text = "CODIGO";
            this.lbCodigoModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbModificar
            // 
            this.lbModificar.AutoSize = true;
            this.lbModificar.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModificar.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.lbModificar.Location = new System.Drawing.Point(677, 118);
            this.lbModificar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbModificar.Name = "lbModificar";
            this.lbModificar.Size = new System.Drawing.Size(647, 23);
            this.lbModificar.TabIndex = 63;
            this.lbModificar.Text = "INGRESE EL CODIGO DEL DEPARTAMENTO QUE DESEA MODIFICAR";
            // 
            // btnInsertarDeducciones
            // 
            this.btnInsertarDeducciones.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarDeducciones.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.btnInsertarDeducciones.Location = new System.Drawing.Point(371, 683);
            this.btnInsertarDeducciones.Name = "btnInsertarDeducciones";
            this.btnInsertarDeducciones.Size = new System.Drawing.Size(243, 82);
            this.btnInsertarDeducciones.TabIndex = 62;
            this.btnInsertarDeducciones.Text = "INSERTAR DEDUCCIONES";
            this.btnInsertarDeducciones.UseVisualStyleBackColor = true;
            this.btnInsertarDeducciones.Click += new System.EventHandler(this.btnInsertarDeducciones_Click);
            // 
            // lbDepartaemento
            // 
            this.lbDepartaemento.AutoSize = true;
            this.lbDepartaemento.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDepartaemento.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.lbDepartaemento.Location = new System.Drawing.Point(40, 154);
            this.lbDepartaemento.Name = "lbDepartaemento";
            this.lbDepartaemento.Size = new System.Drawing.Size(220, 23);
            this.lbDepartaemento.TabIndex = 59;
            this.lbDepartaemento.Text = "REBAJAS SALARIALES";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.lbCodigo.Location = new System.Drawing.Point(40, 101);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(87, 23);
            this.lbCodigo.TabIndex = 58;
            this.lbCodigo.Text = "CODIGO";
            this.lbCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnMostrarDEDUCCIONES
            // 
            this.btnMostrarDEDUCCIONES.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarDEDUCCIONES.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.btnMostrarDEDUCCIONES.Location = new System.Drawing.Point(45, 683);
            this.btnMostrarDEDUCCIONES.Name = "btnMostrarDEDUCCIONES";
            this.btnMostrarDEDUCCIONES.Size = new System.Drawing.Size(243, 82);
            this.btnMostrarDEDUCCIONES.TabIndex = 57;
            this.btnMostrarDEDUCCIONES.Text = "MOSTRAR DEDUCCIONES";
            this.btnMostrarDEDUCCIONES.UseVisualStyleBackColor = true;
            this.btnMostrarDEDUCCIONES.Click += new System.EventHandler(this.btnMostrarDEDUCCIONES_Click);
            // 
            // lbMantenimientoDiasFeriados
            // 
            this.lbMantenimientoDiasFeriados.AutoSize = true;
            this.lbMantenimientoDiasFeriados.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMantenimientoDiasFeriados.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.lbMantenimientoDiasFeriados.Location = new System.Drawing.Point(514, 24);
            this.lbMantenimientoDiasFeriados.Name = "lbMantenimientoDiasFeriados";
            this.lbMantenimientoDiasFeriados.Size = new System.Drawing.Size(327, 23);
            this.lbMantenimientoDiasFeriados.TabIndex = 55;
            this.lbMantenimientoDiasFeriados.Text = "MANTENIMIENTO DEDUCCIONES";
            // 
            // txtSalarioGanada
            // 
            this.txtSalarioGanada.Location = new System.Drawing.Point(335, 210);
            this.txtSalarioGanada.Name = "txtSalarioGanada";
            this.txtSalarioGanada.Size = new System.Drawing.Size(197, 22);
            this.txtSalarioGanada.TabIndex = 73;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.label3.Location = new System.Drawing.Point(40, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 23);
            this.label3.TabIndex = 72;
            this.label3.Text = "SALARIO GANADO ";
            // 
            // txtCCSS
            // 
            this.txtCCSS.Location = new System.Drawing.Point(335, 270);
            this.txtCCSS.Name = "txtCCSS";
            this.txtCCSS.Size = new System.Drawing.Size(197, 22);
            this.txtCCSS.TabIndex = 75;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.label4.Location = new System.Drawing.Point(40, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 23);
            this.label4.TabIndex = 74;
            this.label4.Text = "CCSS";
            // 
            // txtIVM
            // 
            this.txtIVM.Location = new System.Drawing.Point(335, 334);
            this.txtIVM.Name = "txtIVM";
            this.txtIVM.Size = new System.Drawing.Size(197, 22);
            this.txtIVM.TabIndex = 77;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.label5.Location = new System.Drawing.Point(40, 334);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 23);
            this.label5.TabIndex = 76;
            this.label5.Text = "IVM";
            // 
            // txtJuntaAhorro
            // 
            this.txtJuntaAhorro.Location = new System.Drawing.Point(335, 399);
            this.txtJuntaAhorro.Name = "txtJuntaAhorro";
            this.txtJuntaAhorro.Size = new System.Drawing.Size(197, 22);
            this.txtJuntaAhorro.TabIndex = 79;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.label6.Location = new System.Drawing.Point(40, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 23);
            this.label6.TabIndex = 78;
            this.label6.Text = "JUNTA AHORRO";
            // 
            // txtPoliza
            // 
            this.txtPoliza.Location = new System.Drawing.Point(335, 454);
            this.txtPoliza.Name = "txtPoliza";
            this.txtPoliza.Size = new System.Drawing.Size(197, 22);
            this.txtPoliza.TabIndex = 81;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.label7.Location = new System.Drawing.Point(40, 454);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 23);
            this.label7.TabIndex = 80;
            this.label7.Text = "POLIZA";
            // 
            // CrudDeducciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 788);
            this.Controls.Add(this.txtPoliza);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtJuntaAhorro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIVM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCCSS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSalarioGanada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigoEliminar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarDeduccion);
            this.Controls.Add(this.btnModificarDeducciones);
            this.Controls.Add(this.btnEliminarDeducciones);
            this.Controls.Add(this.txtCodigoModificar);
            this.Controls.Add(this.lbCodigoModificar);
            this.Controls.Add(this.lbModificar);
            this.Controls.Add(this.btnInsertarDeducciones);
            this.Controls.Add(this.txtRebejasSalariales);
            this.Controls.Add(this.txtCodigoDeducciones);
            this.Controls.Add(this.lbDepartaemento);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.btnMostrarDEDUCCIONES);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbMantenimientoDiasFeriados);
            this.Name = "CrudDeducciones";
            this.Text = "MANTENIMINETO DE DEDUCCIONES";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CrudDeducciones_FormClosing);
            this.Load += new System.EventHandler(this.CrudDeducciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoEliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarDeduccion;
        private System.Windows.Forms.Button btnModificarDeducciones;
        private System.Windows.Forms.Button btnEliminarDeducciones;
        private System.Windows.Forms.TextBox txtCodigoModificar;
        private System.Windows.Forms.Label lbCodigoModificar;
        private System.Windows.Forms.Label lbModificar;
        private System.Windows.Forms.Button btnInsertarDeducciones;
        private System.Windows.Forms.TextBox txtRebejasSalariales;
        private System.Windows.Forms.TextBox txtCodigoDeducciones;
        private System.Windows.Forms.Label lbDepartaemento;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Button btnMostrarDEDUCCIONES;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbMantenimientoDiasFeriados;
        private System.Windows.Forms.TextBox txtSalarioGanada;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCCSS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIVM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtJuntaAhorro;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPoliza;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSalarioGanado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCCSS;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmIVM;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmJuntaAhorro;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPoliza;
    }
}