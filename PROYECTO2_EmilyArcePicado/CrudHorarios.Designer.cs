namespace PROYECTO2_EmilyArcePicado
{
    partial class CrudHorarios
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigoEliminar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBuscarHorarios = new System.Windows.Forms.Button();
            this.btnModificarHorarios = new System.Windows.Forms.Button();
            this.btnEliminarHorarios = new System.Windows.Forms.Button();
            this.txtCodigoModificar = new System.Windows.Forms.TextBox();
            this.lbCodigoModificar = new System.Windows.Forms.Label();
            this.lbModificar = new System.Windows.Forms.Label();
            this.btnInsertarHorarios = new System.Windows.Forms.Button();
            this.txtHorarios = new System.Windows.Forms.TextBox();
            this.txtCodigoHorarios = new System.Windows.Forms.TextBox();
            this.lbDepartaemento = new System.Windows.Forms.Label();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.btnMostrarHorarios = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clmCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbMantenimientoDiasFeriados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.label1.Location = new System.Drawing.Point(642, 461);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 71;
            this.label1.Text = "CODIGO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCodigoEliminar
            // 
            this.txtCodigoEliminar.Location = new System.Drawing.Point(863, 461);
            this.txtCodigoEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoEliminar.Name = "txtCodigoEliminar";
            this.txtCodigoEliminar.Size = new System.Drawing.Size(197, 22);
            this.txtCodigoEliminar.TabIndex = 70;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.label2.Location = new System.Drawing.Point(526, 357);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(637, 23);
            this.label2.TabIndex = 69;
            this.label2.Text = "INGRESE EL CODIGO DEL DEPARTAMENTO QUE DESEA ELIMINAR ";
            // 
            // btnBuscarHorarios
            // 
            this.btnBuscarHorarios.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarHorarios.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.btnBuscarHorarios.Location = new System.Drawing.Point(729, 233);
            this.btnBuscarHorarios.Name = "btnBuscarHorarios";
            this.btnBuscarHorarios.Size = new System.Drawing.Size(243, 82);
            this.btnBuscarHorarios.TabIndex = 68;
            this.btnBuscarHorarios.Text = "BUSCAR DEPARTAMENTOS ";
            this.btnBuscarHorarios.UseVisualStyleBackColor = true;
            this.btnBuscarHorarios.Click += new System.EventHandler(this.btnBuscarHorarios_Click);
            // 
            // btnModificarHorarios
            // 
            this.btnModificarHorarios.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarHorarios.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.btnModificarHorarios.Location = new System.Drawing.Point(973, 603);
            this.btnModificarHorarios.Name = "btnModificarHorarios";
            this.btnModificarHorarios.Size = new System.Drawing.Size(243, 82);
            this.btnModificarHorarios.TabIndex = 67;
            this.btnModificarHorarios.Text = "MODIFICAR DEPARTAMENTOS ";
            this.btnModificarHorarios.UseVisualStyleBackColor = true;
            this.btnModificarHorarios.Click += new System.EventHandler(this.btnModificarHorarios_Click);
            // 
            // btnEliminarHorarios
            // 
            this.btnEliminarHorarios.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarHorarios.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.btnEliminarHorarios.Location = new System.Drawing.Point(655, 603);
            this.btnEliminarHorarios.Name = "btnEliminarHorarios";
            this.btnEliminarHorarios.Size = new System.Drawing.Size(243, 82);
            this.btnEliminarHorarios.TabIndex = 66;
            this.btnEliminarHorarios.Text = "ELIMINAR DEPARTAMENTOS ";
            this.btnEliminarHorarios.UseVisualStyleBackColor = true;
            this.btnEliminarHorarios.Click += new System.EventHandler(this.btnEliminarHorarios_Click);
            // 
            // txtCodigoModificar
            // 
            this.txtCodigoModificar.Location = new System.Drawing.Point(863, 174);
            this.txtCodigoModificar.Name = "txtCodigoModificar";
            this.txtCodigoModificar.Size = new System.Drawing.Size(197, 22);
            this.txtCodigoModificar.TabIndex = 65;
            // 
            // lbCodigoModificar
            // 
            this.lbCodigoModificar.AutoSize = true;
            this.lbCodigoModificar.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigoModificar.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.lbCodigoModificar.Location = new System.Drawing.Point(642, 174);
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
            this.lbModificar.Location = new System.Drawing.Point(526, 123);
            this.lbModificar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbModificar.Name = "lbModificar";
            this.lbModificar.Size = new System.Drawing.Size(647, 23);
            this.lbModificar.TabIndex = 63;
            this.lbModificar.Text = "INGRESE EL CODIGO DEL DEPARTAMENTO QUE DESEA MODIFICAR";
            // 
            // btnInsertarHorarios
            // 
            this.btnInsertarHorarios.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarHorarios.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.btnInsertarHorarios.Location = new System.Drawing.Point(345, 603);
            this.btnInsertarHorarios.Name = "btnInsertarHorarios";
            this.btnInsertarHorarios.Size = new System.Drawing.Size(243, 82);
            this.btnInsertarHorarios.TabIndex = 62;
            this.btnInsertarHorarios.Text = "INSERTAR DEPARTAMENTOS ";
            this.btnInsertarHorarios.UseVisualStyleBackColor = true;
            this.btnInsertarHorarios.Click += new System.EventHandler(this.btnInsertarHorarios_Click);
            // 
            // txtHorarios
            // 
            this.txtHorarios.Location = new System.Drawing.Point(258, 177);
            this.txtHorarios.Name = "txtHorarios";
            this.txtHorarios.Size = new System.Drawing.Size(197, 22);
            this.txtHorarios.TabIndex = 61;
            // 
            // txtCodigoHorarios
            // 
            this.txtCodigoHorarios.Location = new System.Drawing.Point(258, 124);
            this.txtCodigoHorarios.Name = "txtCodigoHorarios";
            this.txtCodigoHorarios.Size = new System.Drawing.Size(197, 22);
            this.txtCodigoHorarios.TabIndex = 60;
            // 
            // lbDepartaemento
            // 
            this.lbDepartaemento.AutoSize = true;
            this.lbDepartaemento.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDepartaemento.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.lbDepartaemento.Location = new System.Drawing.Point(37, 177);
            this.lbDepartaemento.Name = "lbDepartaemento";
            this.lbDepartaemento.Size = new System.Drawing.Size(155, 23);
            this.lbDepartaemento.TabIndex = 59;
            this.lbDepartaemento.Text = "DIASFERIADOS";
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.lbCodigo.Location = new System.Drawing.Point(37, 124);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(87, 23);
            this.lbCodigo.TabIndex = 58;
            this.lbCodigo.Text = "CODIGO";
            this.lbCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnMostrarHorarios
            // 
            this.btnMostrarHorarios.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarHorarios.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.btnMostrarHorarios.Location = new System.Drawing.Point(32, 603);
            this.btnMostrarHorarios.Name = "btnMostrarHorarios";
            this.btnMostrarHorarios.Size = new System.Drawing.Size(243, 82);
            this.btnMostrarHorarios.TabIndex = 57;
            this.btnMostrarHorarios.Text = "MOSTRAR DEPARTAMENTOS ";
            this.btnMostrarHorarios.UseVisualStyleBackColor = true;
            this.btnMostrarHorarios.Click += new System.EventHandler(this.btnMostrarHorarios_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.clmNombre});
            this.dataGridView1.Location = new System.Drawing.Point(84, 257);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(303, 150);
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
            this.clmNombre.HeaderText = "HORARIOS";
            this.clmNombre.MinimumWidth = 6;
            this.clmNombre.Name = "clmNombre";
            this.clmNombre.Width = 125;
            // 
            // lbMantenimientoDiasFeriados
            // 
            this.lbMantenimientoDiasFeriados.AutoSize = true;
            this.lbMantenimientoDiasFeriados.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMantenimientoDiasFeriados.ForeColor = System.Drawing.Color.Black;
            this.lbMantenimientoDiasFeriados.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.lbMantenimientoDiasFeriados.Location = new System.Drawing.Point(462, 9);
            this.lbMantenimientoDiasFeriados.Name = "lbMantenimientoDiasFeriados";
            this.lbMantenimientoDiasFeriados.Size = new System.Drawing.Size(288, 23);
            this.lbMantenimientoDiasFeriados.TabIndex = 55;
            this.lbMantenimientoDiasFeriados.Text = "MANTENIMIENTO HORARIOS";
            // 
            // CrudHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 712);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigoEliminar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarHorarios);
            this.Controls.Add(this.btnModificarHorarios);
            this.Controls.Add(this.btnEliminarHorarios);
            this.Controls.Add(this.txtCodigoModificar);
            this.Controls.Add(this.lbCodigoModificar);
            this.Controls.Add(this.lbModificar);
            this.Controls.Add(this.btnInsertarHorarios);
            this.Controls.Add(this.txtHorarios);
            this.Controls.Add(this.txtCodigoHorarios);
            this.Controls.Add(this.lbDepartaemento);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.btnMostrarHorarios);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbMantenimientoDiasFeriados);
            this.Name = "CrudHorarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MANTENIMIENTO HORARIOS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CrudHorarios_FormClosing);
            this.Load += new System.EventHandler(this.CrudHorarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigoEliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBuscarHorarios;
        private System.Windows.Forms.Button btnModificarHorarios;
        private System.Windows.Forms.Button btnEliminarHorarios;
        private System.Windows.Forms.TextBox txtCodigoModificar;
        private System.Windows.Forms.Label lbCodigoModificar;
        private System.Windows.Forms.Label lbModificar;
        private System.Windows.Forms.Button btnInsertarHorarios;
        private System.Windows.Forms.TextBox txtHorarios;
        private System.Windows.Forms.TextBox txtCodigoHorarios;
        private System.Windows.Forms.Label lbDepartaemento;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Button btnMostrarHorarios;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.Label lbMantenimientoDiasFeriados;
    }
}