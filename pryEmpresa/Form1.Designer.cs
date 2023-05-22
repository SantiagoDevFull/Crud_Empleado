namespace pryEmpresa
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPaterno = new System.Windows.Forms.TextBox();
            this.txtMaterno = new System.Windows.Forms.TextBox();
            this.txtFecha = new System.Windows.Forms.DateTimePicker();
            this.boxRol = new System.Windows.Forms.ComboBox();
            this.dtgEmpleados = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paterno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechanaci = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelarOperacion = new System.Windows.Forms.Button();
            this.btnEditarEmpleado = new System.Windows.Forms.Button();
            this.btnEliminarEmpleado = new System.Windows.Forms.Button();
            this.btnAgregarEmpleado = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.rbTodos = new System.Windows.Forms.RadioButton();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("PanRoman", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.label1.ForeColor = System.Drawing.Color.Olive;
            this.label1.Location = new System.Drawing.Point(160, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(841, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "EMPLEADOS DE LA EMPRESA \"CUBIX\"";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.Blue;
            this.txtID.Location = new System.Drawing.Point(22, 144);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(132, 27);
            this.txtID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "NOMBRE : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "A. PATERNO :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 298);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "A. MATERNO :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 353);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 16);
            this.label6.TabIndex = 6;
            this.label6.Text = "FECHA DE NACIMIENTO : ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "ROL : ";
            // 
            // txtNombre
            // 
            this.txtNombre.ForeColor = System.Drawing.Color.Blue;
            this.txtNombre.Location = new System.Drawing.Point(23, 201);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(202, 22);
            this.txtNombre.TabIndex = 8;
            // 
            // txtPaterno
            // 
            this.txtPaterno.ForeColor = System.Drawing.Color.Blue;
            this.txtPaterno.Location = new System.Drawing.Point(23, 255);
            this.txtPaterno.Name = "txtPaterno";
            this.txtPaterno.Size = new System.Drawing.Size(202, 22);
            this.txtPaterno.TabIndex = 9;
            // 
            // txtMaterno
            // 
            this.txtMaterno.ForeColor = System.Drawing.Color.Blue;
            this.txtMaterno.Location = new System.Drawing.Point(23, 317);
            this.txtMaterno.Name = "txtMaterno";
            this.txtMaterno.Size = new System.Drawing.Size(202, 22);
            this.txtMaterno.TabIndex = 10;
            // 
            // txtFecha
            // 
            this.txtFecha.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.txtFecha.CalendarTitleForeColor = System.Drawing.Color.Blue;
            this.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtFecha.Location = new System.Drawing.Point(23, 372);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(202, 22);
            this.txtFecha.TabIndex = 11;
            // 
            // boxRol
            // 
            this.boxRol.ForeColor = System.Drawing.Color.Blue;
            this.boxRol.FormattingEnabled = true;
            this.boxRol.Items.AddRange(new object[] {
            "Desarrollador back-end",
            "Desarrollador front-end",
            "Desarrollador full-stack"});
            this.boxRol.Location = new System.Drawing.Point(23, 430);
            this.boxRol.Name = "boxRol";
            this.boxRol.Size = new System.Drawing.Size(202, 24);
            this.boxRol.TabIndex = 12;
            this.boxRol.Text = "[ Seleccionar ]";
            // 
            // dtgEmpleados
            // 
            this.dtgEmpleados.AllowUserToAddRows = false;
            this.dtgEmpleados.AllowUserToDeleteRows = false;
            this.dtgEmpleados.AllowUserToResizeColumns = false;
            this.dtgEmpleados.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgEmpleados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEmpleados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.nombe,
            this.paterno,
            this.materno,
            this.fechanaci,
            this.rol,
            this.sueldo});
            this.dtgEmpleados.Location = new System.Drawing.Point(231, 125);
            this.dtgEmpleados.Name = "dtgEmpleados";
            this.dtgEmpleados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dtgEmpleados.RowHeadersVisible = false;
            this.dtgEmpleados.RowHeadersWidth = 51;
            this.dtgEmpleados.RowTemplate.Height = 24;
            this.dtgEmpleados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgEmpleados.Size = new System.Drawing.Size(913, 339);
            this.dtgEmpleados.TabIndex = 13;
            this.dtgEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEmpleados_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 60;
            // 
            // nombe
            // 
            this.nombe.HeaderText = "NOMBRE";
            this.nombe.MinimumWidth = 6;
            this.nombe.Name = "nombe";
            this.nombe.Width = 115;
            // 
            // paterno
            // 
            this.paterno.HeaderText = "A. PATERNO";
            this.paterno.MinimumWidth = 6;
            this.paterno.Name = "paterno";
            this.paterno.Width = 115;
            // 
            // materno
            // 
            this.materno.HeaderText = "A. MATERNO";
            this.materno.MinimumWidth = 6;
            this.materno.Name = "materno";
            this.materno.Width = 115;
            // 
            // fechanaci
            // 
            this.fechanaci.HeaderText = "FECHA NAC.";
            this.fechanaci.MinimumWidth = 6;
            this.fechanaci.Name = "fechanaci";
            this.fechanaci.Width = 75;
            // 
            // rol
            // 
            this.rol.HeaderText = "ROL";
            this.rol.MinimumWidth = 6;
            this.rol.Name = "rol";
            this.rol.Width = 125;
            // 
            // sueldo
            // 
            this.sueldo.HeaderText = "SUELDO";
            this.sueldo.MinimumWidth = 6;
            this.sueldo.Name = "sueldo";
            this.sueldo.Width = 75;
            // 
            // btnCancelarOperacion
            // 
            this.btnCancelarOperacion.BackColor = System.Drawing.Color.Purple;
            this.btnCancelarOperacion.Enabled = false;
            this.btnCancelarOperacion.FlatAppearance.BorderSize = 0;
            this.btnCancelarOperacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarOperacion.Font = new System.Drawing.Font("SuperFrench", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnCancelarOperacion.ForeColor = System.Drawing.Color.White;
            this.btnCancelarOperacion.Image = global::pryEmpresa.Properties.Resources.iconoCancelar;
            this.btnCancelarOperacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelarOperacion.Location = new System.Drawing.Point(846, 496);
            this.btnCancelarOperacion.Name = "btnCancelarOperacion";
            this.btnCancelarOperacion.Size = new System.Drawing.Size(192, 56);
            this.btnCancelarOperacion.TabIndex = 17;
            this.btnCancelarOperacion.Text = "CANCELAR";
            this.btnCancelarOperacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelarOperacion.UseVisualStyleBackColor = false;
            this.btnCancelarOperacion.Click += new System.EventHandler(this.btnCancelarOperacion_Click);
            // 
            // btnEditarEmpleado
            // 
            this.btnEditarEmpleado.BackColor = System.Drawing.Color.Lime;
            this.btnEditarEmpleado.Enabled = false;
            this.btnEditarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnEditarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarEmpleado.Font = new System.Drawing.Font("SuperFrench", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnEditarEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnEditarEmpleado.Image = global::pryEmpresa.Properties.Resources.iconoEditar;
            this.btnEditarEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarEmpleado.Location = new System.Drawing.Point(382, 496);
            this.btnEditarEmpleado.Name = "btnEditarEmpleado";
            this.btnEditarEmpleado.Size = new System.Drawing.Size(192, 56);
            this.btnEditarEmpleado.TabIndex = 16;
            this.btnEditarEmpleado.Text = "EDITAR";
            this.btnEditarEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarEmpleado.UseVisualStyleBackColor = false;
            this.btnEditarEmpleado.Click += new System.EventHandler(this.btnEditarEmpleado_Click);
            // 
            // btnEliminarEmpleado
            // 
            this.btnEliminarEmpleado.BackColor = System.Drawing.Color.Red;
            this.btnEliminarEmpleado.Enabled = false;
            this.btnEliminarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnEliminarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarEmpleado.Font = new System.Drawing.Font("SuperFrench", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnEliminarEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnEliminarEmpleado.Image = global::pryEmpresa.Properties.Resources.iconoEliminar;
            this.btnEliminarEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarEmpleado.Location = new System.Drawing.Point(614, 496);
            this.btnEliminarEmpleado.Name = "btnEliminarEmpleado";
            this.btnEliminarEmpleado.Size = new System.Drawing.Size(192, 56);
            this.btnEliminarEmpleado.TabIndex = 15;
            this.btnEliminarEmpleado.Text = "ELIMINAR";
            this.btnEliminarEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarEmpleado.UseVisualStyleBackColor = false;
            this.btnEliminarEmpleado.Click += new System.EventHandler(this.btnEliminarEmpleado_Click);
            // 
            // btnAgregarEmpleado
            // 
            this.btnAgregarEmpleado.BackColor = System.Drawing.Color.Blue;
            this.btnAgregarEmpleado.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAgregarEmpleado.FlatAppearance.BorderSize = 0;
            this.btnAgregarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarEmpleado.Font = new System.Drawing.Font("SuperFrench", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btnAgregarEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnAgregarEmpleado.Image = global::pryEmpresa.Properties.Resources.iconoAgregar;
            this.btnAgregarEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(23, 496);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(192, 56);
            this.btnAgregarEmpleado.TabIndex = 14;
            this.btnAgregarEmpleado.Text = "AGREGAR";
            this.btnAgregarEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregarEmpleado.UseVisualStyleBackColor = false;
            this.btnAgregarEmpleado.Click += new System.EventHandler(this.btnAgregarEmpleado_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(1057, 98);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(87, 20);
            this.radioButton1.TabIndex = 18;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Back-End";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(952, 98);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(86, 20);
            this.radioButton2.TabIndex = 19;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Front-End";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(846, 98);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(87, 20);
            this.radioButton3.TabIndex = 20;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Full-Stack";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // rbTodos
            // 
            this.rbTodos.AutoSize = true;
            this.rbTodos.Checked = true;
            this.rbTodos.Location = new System.Drawing.Point(759, 99);
            this.rbTodos.Name = "rbTodos";
            this.rbTodos.Size = new System.Drawing.Size(68, 20);
            this.rbTodos.TabIndex = 21;
            this.rbTodos.TabStop = true;
            this.rbTodos.Text = "Todos";
            this.rbTodos.UseVisualStyleBackColor = true;
            this.rbTodos.CheckedChanged += new System.EventHandler(this.rbTodos_CheckedChanged);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(423, 99);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(297, 22);
            this.txtFiltro.TabIndex = 22;
            this.txtFiltro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(228, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(166, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "FILTRAR POR NOMBRE : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1156, 584);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.rbTodos);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.btnCancelarOperacion);
            this.Controls.Add(this.btnEditarEmpleado);
            this.Controls.Add(this.btnEliminarEmpleado);
            this.Controls.Add(this.btnAgregarEmpleado);
            this.Controls.Add(this.dtgEmpleados);
            this.Controls.Add(this.boxRol);
            this.Controls.Add(this.txtFecha);
            this.Controls.Add(this.txtMaterno);
            this.Controls.Add(this.txtPaterno);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPaterno;
        private System.Windows.Forms.TextBox txtMaterno;
        private System.Windows.Forms.DateTimePicker txtFecha;
        private System.Windows.Forms.ComboBox boxRol;
        private System.Windows.Forms.DataGridView dtgEmpleados;
        private System.Windows.Forms.Button btnAgregarEmpleado;
        private System.Windows.Forms.Button btnEliminarEmpleado;
        private System.Windows.Forms.Button btnEditarEmpleado;
        private System.Windows.Forms.Button btnCancelarOperacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombe;
        private System.Windows.Forms.DataGridViewTextBoxColumn paterno;
        private System.Windows.Forms.DataGridViewTextBoxColumn materno;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechanaci;
        private System.Windows.Forms.DataGridViewTextBoxColumn rol;
        private System.Windows.Forms.DataGridViewTextBoxColumn sueldo;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton rbTodos;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label8;
    }
}

