
namespace SEMCP
{
    partial class FromCC
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromCC));
            this.lbNivel = new System.Windows.Forms.Label();
            this.Tablero = new System.Windows.Forms.FlowLayoutPanel();
            this.lbAviso = new System.Windows.Forms.Label();
            this.lbPuntaje = new System.Windows.Forms.Label();
            this.Panel_R = new System.Windows.Forms.Panel();
            this.labelRN = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelR = new System.Windows.Forms.Label();
            this.Panel_I = new System.Windows.Forms.Panel();
            this.ButtonJugar = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.Label_Titulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel_R.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.Panel_I.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNivel
            // 
            this.lbNivel.AutoSize = true;
            this.lbNivel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNivel.Location = new System.Drawing.Point(455, 67);
            this.lbNivel.Name = "lbNivel";
            this.lbNivel.Size = new System.Drawing.Size(55, 21);
            this.lbNivel.TabIndex = 5;
            this.lbNivel.Text = "Nivel ";
            // 
            // Tablero
            // 
            this.Tablero.Location = new System.Drawing.Point(88, 117);
            this.Tablero.Name = "Tablero";
            this.Tablero.Size = new System.Drawing.Size(760, 341);
            this.Tablero.TabIndex = 4;
            // 
            // lbAviso
            // 
            this.lbAviso.AutoSize = true;
            this.lbAviso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbAviso.Location = new System.Drawing.Point(340, 18);
            this.lbAviso.Name = "lbAviso";
            this.lbAviso.Size = new System.Drawing.Size(240, 21);
            this.lbAviso.TabIndex = 6;
            this.lbAviso.Text = "Memoriza las siguiente cartas.";
            // 
            // lbPuntaje
            // 
            this.lbPuntaje.AutoSize = true;
            this.lbPuntaje.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPuntaje.Location = new System.Drawing.Point(88, 67);
            this.lbPuntaje.Name = "lbPuntaje";
            this.lbPuntaje.Size = new System.Drawing.Size(77, 42);
            this.lbPuntaje.TabIndex = 7;
            this.lbPuntaje.Text = "Nivel : \r\nPuntaje: ";
            // 
            // Panel_R
            // 
            this.Panel_R.Controls.Add(this.labelRN);
            this.Panel_R.Controls.Add(this.label4);
            this.Panel_R.Controls.Add(this.pictureBox2);
            this.Panel_R.Controls.Add(this.labelR);
            this.Panel_R.Location = new System.Drawing.Point(1, 12);
            this.Panel_R.Name = "Panel_R";
            this.Panel_R.Size = new System.Drawing.Size(906, 446);
            this.Panel_R.TabIndex = 30;
            this.Panel_R.Visible = false;
            // 
            // labelRN
            // 
            this.labelRN.AutoSize = true;
            this.labelRN.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRN.Location = new System.Drawing.Point(322, 248);
            this.labelRN.Name = "labelRN";
            this.labelRN.Size = new System.Drawing.Size(302, 29);
            this.labelRN.TabIndex = 26;
            this.labelRN.Text = "Te has quedato en el Nivel ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(322, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(378, 162);
            this.label4.TabIndex = 24;
            this.label4.Text = "Conjunto de cartas\r\n---\r\nResultados:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SEMCP.Properties.Resources.baseline_style_black_48dp;
            this.pictureBox2.Location = new System.Drawing.Point(199, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // labelR
            // 
            this.labelR.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelR.Location = new System.Drawing.Point(12, 377);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(894, 50);
            this.labelR.TabIndex = 22;
            this.labelR.Text = "Se deberá recordar una lista de artículos, se dará un tiempo límite para tratar d" +
    "e\r\nmemorizar.";
            this.labelR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Panel_I
            // 
            this.Panel_I.Controls.Add(this.ButtonJugar);
            this.Panel_I.Controls.Add(this.labelInfo);
            this.Panel_I.Controls.Add(this.Label_Titulo);
            this.Panel_I.Controls.Add(this.pictureBox1);
            this.Panel_I.Cursor = System.Windows.Forms.Cursors.Default;
            this.Panel_I.Location = new System.Drawing.Point(12, 12);
            this.Panel_I.Name = "Panel_I";
            this.Panel_I.Size = new System.Drawing.Size(906, 446);
            this.Panel_I.TabIndex = 31;
            // 
            // ButtonJugar
            // 
            this.ButtonJugar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ButtonJugar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonJugar.FlatAppearance.BorderSize = 0;
            this.ButtonJugar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonJugar.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonJugar.ForeColor = System.Drawing.Color.White;
            this.ButtonJugar.Location = new System.Drawing.Point(377, 360);
            this.ButtonJugar.Name = "ButtonJugar";
            this.ButtonJugar.Size = new System.Drawing.Size(144, 41);
            this.ButtonJugar.TabIndex = 23;
            this.ButtonJugar.Text = "A jugar";
            this.ButtonJugar.UseVisualStyleBackColor = false;
            this.ButtonJugar.Click += new System.EventHandler(this.ButtonJugar_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.BackColor = System.Drawing.SystemColors.Window;
            this.labelInfo.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInfo.Location = new System.Drawing.Point(64, 178);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(831, 115);
            this.labelInfo.TabIndex = 22;
            this.labelInfo.Text = resources.GetString("labelInfo.Text");
            // 
            // Label_Titulo
            // 
            this.Label_Titulo.AutoSize = true;
            this.Label_Titulo.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_Titulo.Location = new System.Drawing.Point(322, 74);
            this.Label_Titulo.Name = "Label_Titulo";
            this.Label_Titulo.Size = new System.Drawing.Size(378, 54);
            this.Label_Titulo.TabIndex = 1;
            this.Label_Titulo.Text = "Conjunto de cartas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SEMCP.Properties.Resources.baseline_style_black_48dp;
            this.pictureBox1.Location = new System.Drawing.Point(199, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FromCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(930, 470);
            this.Controls.Add(this.Panel_I);
            this.Controls.Add(this.Panel_R);
            this.Controls.Add(this.lbPuntaje);
            this.Controls.Add(this.lbAviso);
            this.Controls.Add(this.lbNivel);
            this.Controls.Add(this.Tablero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FromCC";
            this.Text = "FormCC";
            this.Load += new System.EventHandler(this.Tablero_Load);
            this.Panel_R.ResumeLayout(false);
            this.Panel_R.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.Panel_I.ResumeLayout(false);
            this.Panel_I.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Tablero;
        private System.Windows.Forms.Label lbNivel;
        private System.Windows.Forms.Label lbAviso;
        private System.Windows.Forms.Label lbPuntaje;
        private System.Windows.Forms.Panel Panel_R;
        private System.Windows.Forms.Label labelRN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Panel Panel_I;
        private System.Windows.Forms.Button ButtonJugar;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label Label_Titulo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

