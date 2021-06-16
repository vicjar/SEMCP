
namespace SEMCP
{
    partial class Form_Cuenta
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
            this.lbPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbSexo = new System.Windows.Forms.Label();
            this.ComSexo = new System.Windows.Forms.ComboBox();
            this.lbEdad = new System.Windows.Forms.Label();
            this.lbFN = new System.Windows.Forms.Label();
            this.ComFN = new System.Windows.Forms.DateTimePicker();
            this.ComEdad = new System.Windows.Forms.NumericUpDown();
            this.lbCorreo = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lbApellidos = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lbNombres = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.gbUsuario = new System.Windows.Forms.GroupBox();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.bntGuardar = new System.Windows.Forms.Button();
            this.gbPassword = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNPV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNP = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ComEdad)).BeginInit();
            this.gbUsuario.SuspendLayout();
            this.gbPassword.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPassword.Location = new System.Drawing.Point(36, 24);
            this.lbPassword.Margin = new System.Windows.Forms.Padding(0);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(122, 17);
            this.lbPassword.TabIndex = 58;
            this.lbPassword.Text = "Actual contraseña";
            this.lbPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPassword.Location = new System.Drawing.Point(40, 46);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(412, 24);
            this.txtPassword.TabIndex = 57;
            this.txtPassword.UseSystemPasswordChar = true;
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
            // ComEdad
            // 
            this.ComEdad.Enabled = false;
            this.ComEdad.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComEdad.Location = new System.Drawing.Point(246, 107);
            this.ComEdad.Name = "ComEdad";
            this.ComEdad.Size = new System.Drawing.Size(134, 24);
            this.ComEdad.TabIndex = 51;
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
            // txtCorreo
            // 
            this.txtCorreo.Enabled = false;
            this.txtCorreo.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCorreo.Location = new System.Drawing.Point(469, 165);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(412, 24);
            this.txtCorreo.TabIndex = 49;
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
            // txtApellidos
            // 
            this.txtApellidos.Enabled = false;
            this.txtApellidos.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtApellidos.Location = new System.Drawing.Point(469, 49);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(410, 24);
            this.txtApellidos.TabIndex = 47;
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
            // txtNombres
            // 
            this.txtNombres.Enabled = false;
            this.txtNombres.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNombres.Location = new System.Drawing.Point(40, 49);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(410, 24);
            this.txtNombres.TabIndex = 42;
            // 
            // gbUsuario
            // 
            this.gbUsuario.Controls.Add(this.btnEditar);
            this.gbUsuario.Controls.Add(this.btnCancelar);
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
            this.gbUsuario.Location = new System.Drawing.Point(12, 12);
            this.gbUsuario.Name = "gbUsuario";
            this.gbUsuario.Size = new System.Drawing.Size(906, 256);
            this.gbUsuario.TabIndex = 59;
            this.gbUsuario.TabStop = false;
            this.gbUsuario.Text = "Datos del Usuario";
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(260, 208);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(128, 31);
            this.btnEditar.TabIndex = 63;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.Editar);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Maroon;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(528, 208);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(128, 31);
            this.btnCancelar.TabIndex = 62;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
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
            // gbPassword
            // 
            this.gbPassword.Controls.Add(this.btnModificar);
            this.gbPassword.Controls.Add(this.label2);
            this.gbPassword.Controls.Add(this.txtNPV);
            this.gbPassword.Controls.Add(this.label1);
            this.gbPassword.Controls.Add(this.txtNP);
            this.gbPassword.Controls.Add(this.lbPassword);
            this.gbPassword.Controls.Add(this.txtPassword);
            this.gbPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbPassword.Location = new System.Drawing.Point(12, 274);
            this.gbPassword.Name = "gbPassword";
            this.gbPassword.Size = new System.Drawing.Size(906, 181);
            this.gbPassword.TabIndex = 60;
            this.gbPassword.TabStop = false;
            this.gbPassword.Text = "Cambiar contraseña";
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(394, 136);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(128, 31);
            this.btnModificar.TabIndex = 63;
            this.btnModificar.Text = "Cambiar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(473, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 17);
            this.label2.TabIndex = 62;
            this.label2.Text = "Verificar nueva contraseña";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNPV
            // 
            this.txtNPV.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNPV.Location = new System.Drawing.Point(477, 99);
            this.txtNPV.Name = "txtNPV";
            this.txtNPV.Size = new System.Drawing.Size(404, 24);
            this.txtNPV.TabIndex = 61;
            this.txtNPV.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(36, 77);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 60;
            this.label1.Text = "Nueva contraseña";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNP
            // 
            this.txtNP.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNP.Location = new System.Drawing.Point(40, 99);
            this.txtNP.Name = "txtNP";
            this.txtNP.Size = new System.Drawing.Size(410, 24);
            this.txtNP.TabIndex = 59;
            this.txtNP.UseSystemPasswordChar = true;
            // 
            // Form_Cuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(930, 470);
            this.Controls.Add(this.gbPassword);
            this.Controls.Add(this.gbUsuario);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Cuenta";
            this.Text = "Form_Cuenta";
            ((System.ComponentModel.ISupportInitialize)(this.ComEdad)).EndInit();
            this.gbUsuario.ResumeLayout(false);
            this.gbUsuario.PerformLayout();
            this.gbPassword.ResumeLayout(false);
            this.gbPassword.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbSexo;
        private System.Windows.Forms.ComboBox ComSexo;
        private System.Windows.Forms.Label lbEdad;
        private System.Windows.Forms.Label lbFN;
        private System.Windows.Forms.DateTimePicker ComFN;
        private System.Windows.Forms.NumericUpDown ComEdad;
        private System.Windows.Forms.Label lbCorreo;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label lbApellidos;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lbNombres;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.GroupBox gbUsuario;
        private System.Windows.Forms.GroupBox gbPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNPV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNP;
        private System.Windows.Forms.Button bntGuardar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
    }
}