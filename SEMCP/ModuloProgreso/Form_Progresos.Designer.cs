
namespace SEMCP
{
    partial class Form_Progresos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGPuntaje = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Grafica = new ScottPlot.FormsPlot();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bntVer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ComJuego = new System.Windows.Forms.ComboBox();
            this.lbSexo = new System.Windows.Forms.Label();
            this.ComUsuario = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rlineal = new System.Windows.Forms.RadioButton();
            this.rbar = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGPuntaje)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGPuntaje);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(678, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 349);
            this.groupBox1.TabIndex = 63;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Puntajes";
            // 
            // DGPuntaje
            // 
            this.DGPuntaje.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DGPuntaje.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGPuntaje.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGPuntaje.BackgroundColor = System.Drawing.Color.White;
            this.DGPuntaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGPuntaje.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            this.DGPuntaje.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGPuntaje.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGPuntaje.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGPuntaje.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column8});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGPuntaje.DefaultCellStyle = dataGridViewCellStyle5;
            this.DGPuntaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGPuntaje.GridColor = System.Drawing.Color.Black;
            this.DGPuntaje.Location = new System.Drawing.Point(3, 25);
            this.DGPuntaje.Name = "DGPuntaje";
            this.DGPuntaje.ReadOnly = true;
            this.DGPuntaje.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGPuntaje.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DGPuntaje.RowHeadersVisible = false;
            this.DGPuntaje.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.DGPuntaje.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DGPuntaje.RowTemplate.Height = 25;
            this.DGPuntaje.Size = new System.Drawing.Size(234, 321);
            this.DGPuntaje.TabIndex = 2;
            // 
            // Column7
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            this.Column7.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column7.HeaderText = "Puntaje";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            this.Column8.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column8.HeaderText = "Fecha";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Grafica);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(12, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(660, 349);
            this.groupBox2.TabIndex = 64;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Progreso";
            // 
            // Grafica
            // 
            this.Grafica.BackColor = System.Drawing.Color.Transparent;
            this.Grafica.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grafica.Location = new System.Drawing.Point(3, 25);
            this.Grafica.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Grafica.Name = "Grafica";
            this.Grafica.Size = new System.Drawing.Size(654, 321);
            this.Grafica.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bntVer);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.ComJuego);
            this.groupBox3.Controls.Add(this.lbSexo);
            this.groupBox3.Controls.Add(this.ComUsuario);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(660, 89);
            this.groupBox3.TabIndex = 65;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Usuarios";
            // 
            // bntVer
            // 
            this.bntVer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.bntVer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntVer.FlatAppearance.BorderSize = 0;
            this.bntVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntVer.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bntVer.ForeColor = System.Drawing.Color.White;
            this.bntVer.Location = new System.Drawing.Point(532, 44);
            this.bntVer.Name = "bntVer";
            this.bntVer.Size = new System.Drawing.Size(122, 31);
            this.bntVer.TabIndex = 67;
            this.bntVer.Text = "Buscar";
            this.bntVer.UseVisualStyleBackColor = false;
            this.bntVer.Click += new System.EventHandler(this.bntVer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(267, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 66;
            this.label1.Text = "Juego";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ComJuego
            // 
            this.ComJuego.Enabled = false;
            this.ComJuego.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComJuego.FormattingEnabled = true;
            this.ComJuego.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.ComJuego.Location = new System.Drawing.Point(267, 49);
            this.ComJuego.Name = "ComJuego";
            this.ComJuego.Size = new System.Drawing.Size(249, 23);
            this.ComJuego.TabIndex = 65;
            this.ComJuego.Text = "Selecciona";
            // 
            // lbSexo
            // 
            this.lbSexo.AutoSize = true;
            this.lbSexo.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbSexo.Location = new System.Drawing.Point(12, 27);
            this.lbSexo.Margin = new System.Windows.Forms.Padding(0);
            this.lbSexo.Name = "lbSexo";
            this.lbSexo.Size = new System.Drawing.Size(56, 17);
            this.lbSexo.TabIndex = 64;
            this.lbSexo.Text = "Usuario";
            this.lbSexo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ComUsuario
            // 
            this.ComUsuario.Enabled = false;
            this.ComUsuario.Font = new System.Drawing.Font("Roboto", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComUsuario.FormattingEnabled = true;
            this.ComUsuario.Items.AddRange(new object[] {
            "Hombre",
            "Mujer"});
            this.ComUsuario.Location = new System.Drawing.Point(12, 49);
            this.ComUsuario.Name = "ComUsuario";
            this.ComUsuario.Size = new System.Drawing.Size(249, 23);
            this.ComUsuario.TabIndex = 63;
            this.ComUsuario.Text = "Selecciona";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rlineal);
            this.groupBox4.Controls.Add(this.rbar);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox4.Location = new System.Drawing.Point(678, 18);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(240, 83);
            this.groupBox4.TabIndex = 66;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tipo de Grafica";
            // 
            // rlineal
            // 
            this.rlineal.AutoSize = true;
            this.rlineal.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rlineal.Location = new System.Drawing.Point(90, 52);
            this.rlineal.Name = "rlineal";
            this.rlineal.Size = new System.Drawing.Size(62, 23);
            this.rlineal.TabIndex = 1;
            this.rlineal.TabStop = true;
            this.rlineal.Text = "Lineal";
            this.rlineal.UseVisualStyleBackColor = true;
            this.rlineal.CheckedChanged += new System.EventHandler(this.rlineal_CheckedChanged);
            // 
            // rbar
            // 
            this.rbar.AutoSize = true;
            this.rbar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbar.Location = new System.Drawing.Point(90, 28);
            this.rbar.Name = "rbar";
            this.rbar.Size = new System.Drawing.Size(65, 23);
            this.rbar.TabIndex = 0;
            this.rbar.TabStop = true;
            this.rbar.Text = "Barras";
            this.rbar.UseVisualStyleBackColor = true;
            this.rbar.CheckedChanged += new System.EventHandler(this.rbar_CheckedChanged);
            // 
            // Form_Progresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(930, 470);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Progresos";
            this.Text = "Form_Progresos";
            this.Load += new System.EventHandler(this.Form_Progresos_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGPuntaje)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGPuntaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.GroupBox groupBox2;
        private ScottPlot.FormsPlot Grafica;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bntVer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ComJuego;
        private System.Windows.Forms.Label lbSexo;
        private System.Windows.Forms.ComboBox ComUsuario;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rlineal;
        private System.Windows.Forms.RadioButton rbar;
    }
}