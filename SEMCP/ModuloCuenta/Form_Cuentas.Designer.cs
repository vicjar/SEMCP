
namespace SEMCP
{
    partial class Form_Cuentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGUsuarios = new System.Windows.Forms.DataGridView();
            this.ColumnVer = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEditar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ColumnEliminar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.gbUsuario = new System.Windows.Forms.GroupBox();
            this.bntGuardar = new System.Windows.Forms.Button();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbCorreo = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lbNombres = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lbSexo = new System.Windows.Forms.Label();
            this.lbApellidos = new System.Windows.Forms.Label();
            this.ComSexo = new System.Windows.Forms.ComboBox();
            this.ComEdad = new System.Windows.Forms.NumericUpDown();
            this.lbEdad = new System.Windows.Forms.Label();
            this.ComFN = new System.Windows.Forms.DateTimePicker();
            this.lbFN = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGUsuarios)).BeginInit();
            this.gbUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComEdad)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGUsuarios
            // 
            this.DGUsuarios.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGUsuarios.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.DGUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.DGUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnVer,
            this.Column5,
            this.Column2,
            this.Column3,
            this.Column7,
            this.Column8,
            this.ColumnEditar,
            this.ColumnEliminar});
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGUsuarios.DefaultCellStyle = dataGridViewCellStyle10;
            this.DGUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGUsuarios.GridColor = System.Drawing.Color.Black;
            this.DGUsuarios.Location = new System.Drawing.Point(3, 18);
            this.DGUsuarios.Name = "DGUsuarios";
            this.DGUsuarios.ReadOnly = true;
            this.DGUsuarios.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGUsuarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.DGUsuarios.RowHeadersVisible = false;
            this.DGUsuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.DGUsuarios.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DGUsuarios.RowTemplate.Height = 25;
            this.DGUsuarios.Size = new System.Drawing.Size(900, 163);
            this.DGUsuarios.TabIndex = 0;
            this.DGUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // ColumnVer
            // 
            this.ColumnVer.HeaderText = "";
            this.ColumnVer.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ColumnVer.Name = "ColumnVer";
            this.ColumnVer.ReadOnly = true;
            this.ColumnVer.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            // 
            // Column5
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column5.HeaderText = "ID";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            // 
            // Column2
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            this.Column2.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column2.HeaderText = "Nombres";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            this.Column3.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column3.HeaderText = "Apellidos";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column7
            // 
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle6;
            this.Column7.HeaderText = "Usuario";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            this.Column8.DefaultCellStyle = dataGridViewCellStyle7;
            this.Column8.HeaderText = "Correo";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // ColumnEditar
            // 
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ColumnEditar.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColumnEditar.HeaderText = "";
            this.ColumnEditar.LinkColor = System.Drawing.Color.Green;
            this.ColumnEditar.Name = "ColumnEditar";
            this.ColumnEditar.ReadOnly = true;
            this.ColumnEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColumnEditar.VisitedLinkColor = System.Drawing.Color.Green;
            // 
            // ColumnEliminar
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ColumnEliminar.DefaultCellStyle = dataGridViewCellStyle9;
            this.ColumnEliminar.HeaderText = "";
            this.ColumnEliminar.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ColumnEliminar.Name = "ColumnEliminar";
            this.ColumnEliminar.ReadOnly = true;
            this.ColumnEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnEliminar.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // gbUsuario
            // 
            this.gbUsuario.Controls.Add(this.bntGuardar);
            this.gbUsuario.Controls.Add(this.txtCorreo);
            this.gbUsuario.Controls.Add(this.lbUsuario);
            this.gbUsuario.Controls.Add(this.lbCorreo);
            this.gbUsuario.Controls.Add(this.txtNombres);
            this.gbUsuario.Controls.Add(this.txtUsuario);
            this.gbUsuario.Controls.Add(this.lbNombres);
            this.gbUsuario.Controls.Add(this.txtApellidos);
            this.gbUsuario.Controls.Add(this.lbSexo);
            this.gbUsuario.Controls.Add(this.lbApellidos);
            this.gbUsuario.Controls.Add(this.ComSexo);
            this.gbUsuario.Controls.Add(this.ComEdad);
            this.gbUsuario.Controls.Add(this.lbEdad);
            this.gbUsuario.Controls.Add(this.ComFN);
            this.gbUsuario.Controls.Add(this.lbFN);
            this.gbUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbUsuario.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gbUsuario.Location = new System.Drawing.Point(12, 202);
            this.gbUsuario.Name = "gbUsuario";
            this.gbUsuario.Size = new System.Drawing.Size(906, 256);
            this.gbUsuario.TabIndex = 60;
            this.gbUsuario.TabStop = false;
            this.gbUsuario.Text = "Datos del Usuario";
            // 
            // bntGuardar
            // 
            this.bntGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bntGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntGuardar.FlatAppearance.BorderSize = 0;
            this.bntGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntGuardar.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bntGuardar.ForeColor = System.Drawing.Color.White;
            this.bntGuardar.Location = new System.Drawing.Point(394, 208);
            this.bntGuardar.Name = "bntGuardar";
            this.bntGuardar.Size = new System.Drawing.Size(128, 31);
            this.bntGuardar.TabIndex = 61;
            this.bntGuardar.Text = "Guardar";
            this.bntGuardar.UseVisualStyleBackColor = false;
            this.bntGuardar.Click += new System.EventHandler(this.bntGuardar_Click);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Enabled = false;
            this.txtCorreo.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCorreo.Location = new System.Drawing.Point(469, 165);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(412, 24);
            this.txtCorreo.TabIndex = 49;
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbUsuario.Location = new System.Drawing.Point(36, 141);
            this.lbUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(56, 17);
            this.lbUsuario.TabIndex = 45;
            this.lbUsuario.Text = "Usuario";
            this.lbUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbCorreo
            // 
            this.lbCorreo.AutoSize = true;
            this.lbCorreo.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCorreo.Location = new System.Drawing.Point(464, 143);
            this.lbCorreo.Margin = new System.Windows.Forms.Padding(0);
            this.lbCorreo.Name = "lbCorreo";
            this.lbCorreo.Size = new System.Drawing.Size(50, 17);
            this.lbCorreo.TabIndex = 50;
            this.lbCorreo.Text = "Correo";
            this.lbCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNombres
            // 
            this.txtNombres.Enabled = false;
            this.txtNombres.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombres.Location = new System.Drawing.Point(40, 49);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(410, 24);
            this.txtNombres.TabIndex = 42;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtUsuario.Location = new System.Drawing.Point(40, 165);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(412, 24);
            this.txtUsuario.TabIndex = 44;
            // 
            // lbNombres
            // 
            this.lbNombres.AutoSize = true;
            this.lbNombres.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbNombres.Location = new System.Drawing.Point(36, 25);
            this.lbNombres.Margin = new System.Windows.Forms.Padding(0);
            this.lbNombres.Name = "lbNombres";
            this.lbNombres.Size = new System.Drawing.Size(58, 17);
            this.lbNombres.TabIndex = 43;
            this.lbNombres.Text = "Nombre";
            this.lbNombres.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Enabled = false;
            this.txtApellidos.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtApellidos.Location = new System.Drawing.Point(469, 49);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(410, 24);
            this.txtApellidos.TabIndex = 47;
            // 
            // lbSexo
            // 
            this.lbSexo.AutoSize = true;
            this.lbSexo.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSexo.Location = new System.Drawing.Point(386, 85);
            this.lbSexo.Margin = new System.Windows.Forms.Padding(0);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(38, 17);
            this.lbSexo.TabIndex = 56;
            this.lbSexo.Text = "Sexo";
            this.lbSexo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbApellidos
            // 
            this.lbApellidos.AutoSize = true;
            this.lbApellidos.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbApellidos.Location = new System.Drawing.Point(465, 25);
            this.lbApellidos.Margin = new System.Windows.Forms.Padding(0);
            this.lbApellidos.Name = "lbApellidos";
            this.lbApellidos.Size = new System.Drawing.Size(57, 17);
            this.lbApellidos.TabIndex = 48;
            this.lbApellidos.Text = "Apellido";
            this.lbApellidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ComSexo
            // 
            this.ComSexo.Enabled = false;
            this.ComSexo.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComSexo.FormattingEnabled = true;
            this.ComSexo.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.ComSexo.Location = new System.Drawing.Point(386, 107);
            this.ComSexo.Name = "ComSexo";
            this.ComSexo.Size = new System.Drawing.Size(164, 23);
            this.ComSexo.TabIndex = 55;
            this.ComSexo.Text = "Selecciona";
            // 
            // ComEdad
            // 
            this.ComEdad.Enabled = false;
            this.ComEdad.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComEdad.Location = new System.Drawing.Point(246, 107);
            this.ComEdad.Name = "ComEdad";
            this.ComEdad.Size = new System.Drawing.Size(134, 24);
            this.ComEdad.TabIndex = 51;
            // 
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbEdad.Location = new System.Drawing.Point(246, 85);
            this.lbEdad.Margin = new System.Windows.Forms.Padding(0);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(40, 17);
            this.lbEdad.TabIndex = 54;
            this.lbEdad.Text = "Edad";
            this.lbEdad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ComFN
            // 
            this.ComFN.Enabled = false;
            this.ComFN.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComFN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ComFN.Location = new System.Drawing.Point(40, 107);
            this.ComFN.Name = "ComFN";
            this.ComFN.Size = new System.Drawing.Size(200, 24);
            this.ComFN.TabIndex = 52;
            // 
            // lbFN
            // 
            this.lbFN.AutoSize = true;
            this.lbFN.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbFN.Location = new System.Drawing.Point(36, 85);
            this.lbFN.Margin = new System.Windows.Forms.Padding(0);
            this.lbFN.Name = "lbFN";
            this.lbFN.Size = new System.Drawing.Size(138, 17);
            this.lbFN.TabIndex = 53;
            this.lbFN.Text = "Fecha de Nacimiento";
            this.lbFN.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.DGUsuarios);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(906, 184);
            this.groupBox2.TabIndex = 61;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Usuarios";
            // 
            // Form_Cuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(930, 470);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Cuentas";
            this.Text = "Form_Cuentas";
            this.Load += new System.EventHandler(this.Form_Cuentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGUsuarios)).EndInit();
            this.gbUsuario.ResumeLayout(false);
            this.gbUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ComEdad)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGUsuarios;
        private System.Windows.Forms.GroupBox gbUsuario;
        private System.Windows.Forms.Button bntGuardar;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbCorreo;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lbNombres;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lbSexo;
        private System.Windows.Forms.Label lbApellidos;
        private System.Windows.Forms.ComboBox ComSexo;
        private System.Windows.Forms.NumericUpDown ComEdad;
        private System.Windows.Forms.Label lbEdad;
        private System.Windows.Forms.DateTimePicker ComFN;
        private System.Windows.Forms.Label lbFN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnVer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnEditar;
        private System.Windows.Forms.DataGridViewLinkColumn ColumnEliminar;
    }
}