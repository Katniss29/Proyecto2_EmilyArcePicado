namespace PROYECTO2_EmilyArcePicado
{
    partial class CrudDiasFeriados
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
            this.lbMantenimientoDiasFeriados = new System.Windows.Forms.Label();
            this.txtCodigoEliminar = new System.Windows.Forms.TextBox();
            this.txtCodigoModificar = new System.Windows.Forms.TextBox();
            this.txtDiasFeriados = new System.Windows.Forms.TextBox();
            this.txtCodigoDiaFeriado = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarDepartamentos = new System.Windows.Forms.Button();
            this.btnModificarDiasFeriados = new System.Windows.Forms.Button();
            this.btnEliminarDiasFeriados = new System.Windows.Forms.Button();
            this.lbCodigoModificar = new System.Windows.Forms.Label();
            this.lbModificar = new System.Windows.Forms.Label();
            this.btnInsertarDiasFeriados = new System.Windows.Forms.Button();
            this.lbDepartaemento = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.btnMostrarDiasFeriados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbMantenimientoDiasFeriados
            // 
            this.lbMantenimientoDiasFeriados.AutoSize = true;
            this.lbMantenimientoDiasFeriados.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMantenimientoDiasFeriados.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.lbMantenimientoDiasFeriados.Location = new System.Drawing.Point(494, 9);
            this.lbMantenimientoDiasFeriados.Name = "lbMantenimientoDiasFeriados";
            this.lbMantenimientoDiasFeriados.Size = new System.Drawing.Size(336, 23);
            this.lbMantenimientoDiasFeriados.TabIndex = 0;
            this.lbMantenimientoDiasFeriados.Text = "MANTENIMIENTO DIAS FERIADOS";
            // 
            // txtCodigoEliminar
            // 
            this.txtCodigoEliminar.Location = new System.Drawing.Point(875, 451);
            this.txtCodigoEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoEliminar.Name = "txtCodigoEliminar";
            this.txtCodigoEliminar.Size = new System.Drawing.Size(197, 22);
            this.txtCodigoEliminar.TabIndex = 53;
            // 
            // txtCodigoModificar
            // 
            this.txtCodigoModificar.Location = new System.Drawing.Point(875, 164);
            this.txtCodigoModificar.Name = "txtCodigoModificar";
            this.txtCodigoModificar.Size = new System.Drawing.Size(197, 22);
            this.txtCodigoModificar.TabIndex = 48;
            // 
            // txtDiasFeriados
            // 
            this.txtDiasFeriados.Location = new System.Drawing.Point(242, 157);
            this.txtDiasFeriados.Name = "txtDiasFeriados";
            this.txtDiasFeriados.Size = new System.Drawing.Size(197, 22);
            this.txtDiasFeriados.TabIndex = 44;
            // 
            // txtCodigoDiaFeriado
            // 
            this.txtCodigoDiaFeriado.Location = new System.Drawing.Point(242, 104);
            this.txtCodigoDiaFeriado.Name = "txtCodigoDiaFeriado";
            this.txtCodigoDiaFeriado.Size = new System.Drawing.Size(197, 22);
            this.txtCodigoDiaFeriado.TabIndex = 43;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.clmNombre});
            this.dataGridView1.Location = new System.Drawing.Point(68, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(303, 150);
            this.dataGridView1.TabIndex = 39;
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
            this.clmNombre.HeaderText = "DIAS FERIADOS";
            this.clmNombre.MinimumWidth = 6;
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.label1.Location = new System.Drawing.Point(654, 451);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 54;
            this.label1.Text = "CODIGO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.label2.Location = new System.Drawing.Point(538, 347);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(637, 23);
            this.label2.TabIndex = 52;
            this.label2.Text = "INGRESE EL CODIGO DEL DEPARTAMENTO QUE DESEA ELIMINAR ";
            // 
            // btnBuscarDepartamentos
            // 
            this.btnBuscarDepartamentos.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDepartamentos.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.btnBuscarDepartamentos.Location = new System.Drawing.Point(741, 223);
            this.btnBuscarDepartamentos.Name = "btnBuscarDepartamentos";
            this.btnBuscarDepartamentos.Size = new System.Drawing.Size(243, 82);
            this.btnBuscarDepartamentos.TabIndex = 51;
            this.btnBuscarDepartamentos.Text = "BUSCAR DEPARTAMENTOS ";
            this.btnBuscarDepartamentos.UseVisualStyleBackColor = true;
            this.btnBuscarDepartamentos.Click += new System.EventHandler(this.btnBuscarDepartamentos_Click);
            // 
            // btnModificarDiasFeriados
            // 
            this.btnModificarDiasFeriados.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarDiasFeriados.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.btnModificarDiasFeriados.Location = new System.Drawing.Point(979, 538);
            this.btnModificarDiasFeriados.Name = "btnModificarDiasFeriados";
            this.btnModificarDiasFeriados.Size = new System.Drawing.Size(243, 82);
            this.btnModificarDiasFeriados.TabIndex = 50;
            this.btnModificarDiasFeriados.Text = "MODIFICAR DEPARTAMENTOS ";
            this.btnModificarDiasFeriados.UseVisualStyleBackColor = true;
            this.btnModificarDiasFeriados.Click += new System.EventHandler(this.btnModificarDiasFeriados_Click);
            // 
            // btnEliminarDiasFeriados
            // 
            this.btnEliminarDiasFeriados.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDiasFeriados.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.btnEliminarDiasFeriados.Location = new System.Drawing.Point(661, 538);
            this.btnEliminarDiasFeriados.Name = "btnEliminarDiasFeriados";
            this.btnEliminarDiasFeriados.Size = new System.Drawing.Size(243, 82);
            this.btnEliminarDiasFeriados.TabIndex = 49;
            this.btnEliminarDiasFeriados.Text = "ELIMINAR DEPARTAMENTOS ";
            this.btnEliminarDiasFeriados.UseVisualStyleBackColor = true;
            this.btnEliminarDiasFeriados.Click += new System.EventHandler(this.btnEliminarDiasFeriados_Click);
            // 
            // lbCodigoModificar
            // 
            this.lbCodigoModificar.AutoSize = true;
            this.lbCodigoModificar.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigoModificar.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.lbCodigoModificar.Location = new System.Drawing.Point(654, 164);
            this.lbCodigoModificar.Name = "lbCodigoModificar";
            this.lbCodigoModificar.Size = new System.Drawing.Size(87, 23);
            this.lbCodigoModificar.TabIndex = 47;
            this.lbCodigoModificar.Text = "CODIGO";
            this.lbCodigoModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbModificar
            // 
            this.lbModificar.AutoSize = true;
            this.lbModificar.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModificar.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.lbModificar.Location = new System.Drawing.Point(538, 113);
            this.lbModificar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbModificar.Name = "lbModificar";
            this.lbModificar.Size = new System.Drawing.Size(647, 23);
            this.lbModificar.TabIndex = 46;
            this.lbModificar.Text = "INGRESE EL CODIGO DEL DEPARTAMENTO QUE DESEA MODIFICAR";
            // 
            // btnInsertarDiasFeriados
            // 
            this.btnInsertarDiasFeriados.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarDiasFeriados.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.btnInsertarDiasFeriados.Location = new System.Drawing.Point(351, 538);
            this.btnInsertarDiasFeriados.Name = "btnInsertarDiasFeriados";
            this.btnInsertarDiasFeriados.Size = new System.Drawing.Size(243, 82);
            this.btnInsertarDiasFeriados.TabIndex = 45;
            this.btnInsertarDiasFeriados.Text = "INSERTAR DEPARTAMENTOS ";
            this.btnInsertarDiasFeriados.UseVisualStyleBackColor = true;
            this.btnInsertarDiasFeriados.Click += new System.EventHandler(this.btnInsertarDiasFeriados_Click);
            // 
            // lbDepartaemento
            // 
            this.lbDepartaemento.AutoSize = true;
            this.lbDepartaemento.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDepartaemento.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.lbDepartaemento.Location = new System.Drawing.Point(21, 157);
            this.lbDepartaemento.Name = "lbDepartaemento";
            this.lbDepartaemento.Size = new System.Drawing.Size(155, 23);
            this.lbDepartaemento.TabIndex = 42;
            this.lbDepartaemento.Text = "DIASFERIADOS";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.lbCodigo.Location = new System.Drawing.Point(21, 104);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(87, 23);
            this.lbCodigo.TabIndex = 41;
            this.lbCodigo.Text = "CODIGO";
            this.lbCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnMostrarDiasFeriados
            // 
            this.btnMostrarDiasFeriados.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarDiasFeriados.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.btnMostrarDiasFeriados.Location = new System.Drawing.Point(38, 538);
            this.btnMostrarDiasFeriados.Name = "btnMostrarDiasFeriados";
            this.btnMostrarDiasFeriados.Size = new System.Drawing.Size(243, 82);
            this.btnMostrarDiasFeriados.TabIndex = 40;
            this.btnMostrarDiasFeriados.Text = "MOSTRAR DEPARTAMENTOS ";
            this.btnMostrarDiasFeriados.UseVisualStyleBackColor = true;
            this.btnMostrarDiasFeriados.Click += new System.EventHandler(this.btnMostrarDiasFeriados_Click_1);
            // 
            // CrudDiasFeriados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 676);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigoEliminar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarDepartamentos);
            this.Controls.Add(this.btnModificarDiasFeriados);
            this.Controls.Add(this.btnEliminarDiasFeriados);
            this.Controls.Add(this.txtCodigoModificar);
            this.Controls.Add(this.lbCodigoModificar);
            this.Controls.Add(this.lbModificar);
            this.Controls.Add(this.btnInsertarDiasFeriados);
            this.Controls.Add(this.txtDiasFeriados);
            this.Controls.Add(this.txtCodigoDiaFeriado);
            this.Controls.Add(this.lbDepartaemento);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.btnMostrarDiasFeriados);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbMantenimientoDiasFeriados);
            this.Name = "CrudDiasFeriados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrudDiasFeriados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CrudDiasFeriados_FormClosing);
            this.Load += new System.EventHandler(this.CrudDiasFeriados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMantenimientoDiasFeriados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoEliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarDepartamentos;
        private System.Windows.Forms.Button btnModificarDiasFeriados;
        private System.Windows.Forms.Button btnEliminarDiasFeriados;
        private System.Windows.Forms.TextBox txtCodigoModificar;
        private System.Windows.Forms.Label lbCodigoModificar;
        private System.Windows.Forms.Label lbModificar;
        private System.Windows.Forms.Button btnInsertarDiasFeriados;
        private System.Windows.Forms.TextBox txtDiasFeriados;
        private System.Windows.Forms.TextBox txtCodigoDiaFeriado;
        private System.Windows.Forms.Label lbDepartaemento;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Button btnMostrarDiasFeriados;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
    }
}