namespace PROYECTO2_EmilyArcePicado
{
    partial class CrudDepartamentos
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
            this.btnMostrarDepartamentos = new System.Windows.Forms.Button();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.lbDepartaemento = new System.Windows.Forms.Label();
            this.txtCodigoDepartamento = new System.Windows.Forms.TextBox();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.btnInsertarDepartamento = new System.Windows.Forms.Button();
            this.lbMantenimientoDepartamentos = new System.Windows.Forms.Label();
            this.lbModificar = new System.Windows.Forms.Label();
            this.txtCodigoModificar = new System.Windows.Forms.TextBox();
            this.lbCodigoModificar = new System.Windows.Forms.Label();
            this.btnEliminarDepartamento = new System.Windows.Forms.Button();
            this.btnModificarDepartamento = new System.Windows.Forms.Button();
            this.btnBuscarDepartamentos = new System.Windows.Forms.Button();
            this.txtCodigoEliminar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmCodigo,
            this.clmNombre});
            this.dataGridView1.Location = new System.Drawing.Point(67, 221);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(303, 150);
            this.dataGridView1.TabIndex = 1;
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
            // btnMostrarDepartamentos
            // 
            this.btnMostrarDepartamentos.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarDepartamentos.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.btnMostrarDepartamentos.Location = new System.Drawing.Point(35, 517);
            this.btnMostrarDepartamentos.Name = "btnMostrarDepartamentos";
            this.btnMostrarDepartamentos.Size = new System.Drawing.Size(243, 82);
            this.btnMostrarDepartamentos.TabIndex = 2;
            this.btnMostrarDepartamentos.Text = "MOSTRAR DEPARTAMENTOS ";
            this.btnMostrarDepartamentos.UseVisualStyleBackColor = true;
            this.btnMostrarDepartamentos.Click += new System.EventHandler(this.btnMostrarDepartamentos_Click);
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigo.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.lbCodigo.Location = new System.Drawing.Point(23, 94);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(87, 23);
            this.lbCodigo.TabIndex = 3;
            this.lbCodigo.Text = "CODIGO";
            this.lbCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbDepartaemento
            // 
            this.lbDepartaemento.AutoSize = true;
            this.lbDepartaemento.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDepartaemento.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.lbDepartaemento.Location = new System.Drawing.Point(23, 147);
            this.lbDepartaemento.Name = "lbDepartaemento";
            this.lbDepartaemento.Size = new System.Drawing.Size(169, 23);
            this.lbDepartaemento.TabIndex = 4;
            this.lbDepartaemento.Text = "DEPARTAMENTO";
            // 
            // txtCodigoDepartamento
            // 
            this.txtCodigoDepartamento.Location = new System.Drawing.Point(244, 94);
            this.txtCodigoDepartamento.Name = "txtCodigoDepartamento";
            this.txtCodigoDepartamento.Size = new System.Drawing.Size(197, 22);
            this.txtCodigoDepartamento.TabIndex = 5;
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(244, 147);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(197, 22);
            this.txtDepartamento.TabIndex = 6;
            // 
            // btnInsertarDepartamento
            // 
            this.btnInsertarDepartamento.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsertarDepartamento.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.btnInsertarDepartamento.Location = new System.Drawing.Point(348, 517);
            this.btnInsertarDepartamento.Name = "btnInsertarDepartamento";
            this.btnInsertarDepartamento.Size = new System.Drawing.Size(243, 82);
            this.btnInsertarDepartamento.TabIndex = 8;
            this.btnInsertarDepartamento.Text = "INSERTAR DEPARTAMENTOS ";
            this.btnInsertarDepartamento.UseVisualStyleBackColor = true;
            this.btnInsertarDepartamento.Click += new System.EventHandler(this.btnInsertarDepartamento_Click);
            // 
            // lbMantenimientoDepartamentos
            // 
            this.lbMantenimientoDepartamentos.AutoSize = true;
            this.lbMantenimientoDepartamentos.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMantenimientoDepartamentos.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.lbMantenimientoDepartamentos.Location = new System.Drawing.Point(442, 9);
            this.lbMantenimientoDepartamentos.Name = "lbMantenimientoDepartamentos";
            this.lbMantenimientoDepartamentos.Size = new System.Drawing.Size(435, 23);
            this.lbMantenimientoDepartamentos.TabIndex = 0;
            this.lbMantenimientoDepartamentos.Text = "MANTENIMIENTO DE LOS DEPARTAMENTOS ";
            // 
            // lbModificar
            // 
            this.lbModificar.AutoSize = true;
            this.lbModificar.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModificar.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.lbModificar.Location = new System.Drawing.Point(598, 93);
            this.lbModificar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbModificar.Name = "lbModificar";
            this.lbModificar.Size = new System.Drawing.Size(647, 23);
            this.lbModificar.TabIndex = 29;
            this.lbModificar.Text = "INGRESE EL CODIGO DEL DEPARTAMENTO QUE DESEA MODIFICAR";
            // 
            // txtCodigoModificar
            // 
            this.txtCodigoModificar.Location = new System.Drawing.Point(935, 144);
            this.txtCodigoModificar.Name = "txtCodigoModificar";
            this.txtCodigoModificar.Size = new System.Drawing.Size(197, 22);
            this.txtCodigoModificar.TabIndex = 31;
            // 
            // lbCodigoModificar
            // 
            this.lbCodigoModificar.AutoSize = true;
            this.lbCodigoModificar.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCodigoModificar.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.lbCodigoModificar.Location = new System.Drawing.Point(714, 144);
            this.lbCodigoModificar.Name = "lbCodigoModificar";
            this.lbCodigoModificar.Size = new System.Drawing.Size(87, 23);
            this.lbCodigoModificar.TabIndex = 30;
            this.lbCodigoModificar.Text = "CODIGO";
            this.lbCodigoModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnEliminarDepartamento
            // 
            this.btnEliminarDepartamento.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarDepartamento.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.btnEliminarDepartamento.Location = new System.Drawing.Point(658, 517);
            this.btnEliminarDepartamento.Name = "btnEliminarDepartamento";
            this.btnEliminarDepartamento.Size = new System.Drawing.Size(243, 82);
            this.btnEliminarDepartamento.TabIndex = 32;
            this.btnEliminarDepartamento.Text = "ELIMINAR DEPARTAMENTOS ";
            this.btnEliminarDepartamento.UseVisualStyleBackColor = true;
            this.btnEliminarDepartamento.Click += new System.EventHandler(this.btnEliminarDepartamento_Click);
            // 
            // btnModificarDepartamento
            // 
            this.btnModificarDepartamento.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarDepartamento.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.btnModificarDepartamento.Location = new System.Drawing.Point(976, 517);
            this.btnModificarDepartamento.Name = "btnModificarDepartamento";
            this.btnModificarDepartamento.Size = new System.Drawing.Size(243, 82);
            this.btnModificarDepartamento.TabIndex = 33;
            this.btnModificarDepartamento.Text = "MODIFICAR DEPARTAMENTOS ";
            this.btnModificarDepartamento.UseVisualStyleBackColor = true;
            this.btnModificarDepartamento.Click += new System.EventHandler(this.btnModificarDepartamento_Click);
            // 
            // btnBuscarDepartamentos
            // 
            this.btnBuscarDepartamentos.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarDepartamentos.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.btnBuscarDepartamentos.Location = new System.Drawing.Point(801, 203);
            this.btnBuscarDepartamentos.Name = "btnBuscarDepartamentos";
            this.btnBuscarDepartamentos.Size = new System.Drawing.Size(243, 82);
            this.btnBuscarDepartamentos.TabIndex = 34;
            this.btnBuscarDepartamentos.Text = "BUSCAR DEPARTAMENTOS ";
            this.btnBuscarDepartamentos.UseVisualStyleBackColor = true;
            this.btnBuscarDepartamentos.Click += new System.EventHandler(this.btnBuscarDepartamentos_Click);
            // 
            // txtCodigoEliminar
            // 
            this.txtCodigoEliminar.Location = new System.Drawing.Point(935, 431);
            this.txtCodigoEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoEliminar.Name = "txtCodigoEliminar";
            this.txtCodigoEliminar.Size = new System.Drawing.Size(197, 22);
            this.txtCodigoEliminar.TabIndex = 37;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.label2.Location = new System.Drawing.Point(598, 327);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(637, 23);
            this.label2.TabIndex = 35;
            this.label2.Text = "INGRESE EL CODIGO DEL DEPARTAMENTO QUE DESEA ELIMINAR ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Image = global::PROYECTO2_EmilyArcePicado.Properties.Resources.fondo1;
            this.label1.Location = new System.Drawing.Point(714, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 38;
            this.label1.Text = "CODIGO";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CrudDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 611);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCodigoEliminar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBuscarDepartamentos);
            this.Controls.Add(this.btnModificarDepartamento);
            this.Controls.Add(this.btnEliminarDepartamento);
            this.Controls.Add(this.txtCodigoModificar);
            this.Controls.Add(this.lbCodigoModificar);
            this.Controls.Add(this.lbModificar);
            this.Controls.Add(this.btnInsertarDepartamento);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.txtCodigoDepartamento);
            this.Controls.Add(this.lbDepartaemento);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.btnMostrarDepartamentos);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbMantenimientoDepartamentos);
            this.Name = "CrudDepartamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRUD DEPARTAMENTOS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CrudDepartamentos_FormClosing);
            this.Load += new System.EventHandler(this.CrudDepartamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMantenimientoDepartamentos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmNombre;
        private System.Windows.Forms.Button btnMostrarDepartamentos;
        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Label lbDepartaemento;
        private System.Windows.Forms.TextBox txtCodigoDepartamento;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Button btnInsertarDepartamento;
        private System.Windows.Forms.Label lbModificar;
        private System.Windows.Forms.TextBox txtCodigoModificar;
        private System.Windows.Forms.Label lbCodigoModificar;
        private System.Windows.Forms.Button btnEliminarDepartamento;
        private System.Windows.Forms.Button btnModificarDepartamento;
        private System.Windows.Forms.Button btnBuscarDepartamentos;
        private System.Windows.Forms.TextBox txtCodigoEliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}