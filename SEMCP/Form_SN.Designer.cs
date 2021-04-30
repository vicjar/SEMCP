
namespace SEMCP
{
    partial class Form_SN
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_SN));
            this.Panel_I = new System.Windows.Forms.Panel();
            this.ButtonJugar = new System.Windows.Forms.Button();
            this.labelInfo = new System.Windows.Forms.Label();
            this.Label_Titulo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel_J = new System.Windows.Forms.Panel();
            this.label_T = new System.Windows.Forms.Label();
            this.P_T = new System.Windows.Forms.PictureBox();
            this.labelinfo3 = new System.Windows.Forms.Label();
            this.ButtonComprobar = new System.Windows.Forms.Button();
            this.labelSerie = new System.Windows.Forms.Label();
            this.LabelN = new System.Windows.Forms.Label();
            this.TextBoxNumber = new System.Windows.Forms.TextBox();
            this.labelinfo2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Panel_R = new System.Windows.Forms.Panel();
            this.labelRN = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelR = new System.Windows.Forms.Label();
            this.Panel_I.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Panel_J.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P_T)).BeginInit();
            this.Panel_R.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_I
            // 
            this.Panel_I.Controls.Add(this.ButtonJugar);
            this.Panel_I.Controls.Add(this.labelInfo);
            this.Panel_I.Controls.Add(this.Label_Titulo);
            this.Panel_I.Controls.Add(this.pictureBox1);
            this.Panel_I.Location = new System.Drawing.Point(12, 12);
            this.Panel_I.Name = "Panel_I";
            this.Panel_I.Size = new System.Drawing.Size(906, 446);
            this.Panel_I.TabIndex = 27;
            // 
            // ButtonJugar
            // 
            this.ButtonJugar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonJugar.Location = new System.Drawing.Point(377, 360);
            this.ButtonJugar.Name = "ButtonJugar";
            this.ButtonJugar.Size = new System.Drawing.Size(144, 41);
            this.ButtonJugar.TabIndex = 23;
            this.ButtonJugar.Text = "A jugar";
            this.ButtonJugar.UseVisualStyleBackColor = true;
            this.ButtonJugar.Click += new System.EventHandler(this.ButtonJugar_Click);
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.BackColor = System.Drawing.SystemColors.Window;
            this.labelInfo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelInfo.Location = new System.Drawing.Point(78, 166);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(757, 150);
            this.labelInfo.TabIndex = 22;
            this.labelInfo.Text = resources.GetString("labelInfo.Text");
            // 
            // Label_Titulo
            // 
            this.Label_Titulo.AutoSize = true;
            this.Label_Titulo.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_Titulo.Location = new System.Drawing.Point(322, 74);
            this.Label_Titulo.Name = "Label_Titulo";
            this.Label_Titulo.Size = new System.Drawing.Size(350, 54);
            this.Label_Titulo.TabIndex = 1;
            this.Label_Titulo.Text = "Serie de números";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SEMCP.Properties.Resources.baseline_pin_black_48dp;
            this.pictureBox1.Location = new System.Drawing.Point(199, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Panel_J
            // 
            this.Panel_J.Controls.Add(this.label_T);
            this.Panel_J.Controls.Add(this.P_T);
            this.Panel_J.Controls.Add(this.labelinfo3);
            this.Panel_J.Controls.Add(this.ButtonComprobar);
            this.Panel_J.Controls.Add(this.labelSerie);
            this.Panel_J.Controls.Add(this.LabelN);
            this.Panel_J.Controls.Add(this.TextBoxNumber);
            this.Panel_J.Controls.Add(this.labelinfo2);
            this.Panel_J.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Panel_J.Location = new System.Drawing.Point(12, 12);
            this.Panel_J.Name = "Panel_J";
            this.Panel_J.Size = new System.Drawing.Size(913, 446);
            this.Panel_J.TabIndex = 28;
            this.Panel_J.Visible = false;
            // 
            // label_T
            // 
            this.label_T.AutoSize = true;
            this.label_T.Location = new System.Drawing.Point(728, 84);
            this.label_T.Name = "label_T";
            this.label_T.Size = new System.Drawing.Size(32, 23);
            this.label_T.TabIndex = 29;
            this.label_T.Text = "10";
            // 
            // P_T
            // 
            this.P_T.Image = global::SEMCP.Properties.Resources.clock;
            this.P_T.Location = new System.Drawing.Point(766, 74);
            this.P_T.Name = "P_T";
            this.P_T.Size = new System.Drawing.Size(40, 40);
            this.P_T.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.P_T.TabIndex = 28;
            this.P_T.TabStop = false;
            // 
            // labelinfo3
            // 
            this.labelinfo3.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelinfo3.Location = new System.Drawing.Point(68, 242);
            this.labelinfo3.Name = "labelinfo3";
            this.labelinfo3.Size = new System.Drawing.Size(788, 38);
            this.labelinfo3.TabIndex = 27;
            this.labelinfo3.Text = "Ahora ingresa la serie que memorizaste hace unos momentos.";
            this.labelinfo3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ButtonComprobar
            // 
            this.ButtonComprobar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ButtonComprobar.Location = new System.Drawing.Point(403, 360);
            this.ButtonComprobar.Name = "ButtonComprobar";
            this.ButtonComprobar.Size = new System.Drawing.Size(144, 41);
            this.ButtonComprobar.TabIndex = 26;
            this.ButtonComprobar.Text = "Comprobar";
            this.ButtonComprobar.UseVisualStyleBackColor = true;
            this.ButtonComprobar.Click += new System.EventHandler(this.ButtonComprobar_Click);
            // 
            // labelSerie
            // 
            this.labelSerie.Font = new System.Drawing.Font("Roboto", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSerie.Location = new System.Drawing.Point(12, 149);
            this.labelSerie.Name = "labelSerie";
            this.labelSerie.Size = new System.Drawing.Size(894, 63);
            this.labelSerie.TabIndex = 25;
            this.labelSerie.Text = "----------------";
            this.labelSerie.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelN
            // 
            this.LabelN.AutoSize = true;
            this.LabelN.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelN.Location = new System.Drawing.Point(290, 90);
            this.LabelN.Name = "LabelN";
            this.LabelN.Size = new System.Drawing.Size(58, 23);
            this.LabelN.TabIndex = 24;
            this.LabelN.Text = "Nivel ";
            // 
            // TextBoxNumber
            // 
            this.TextBoxNumber.Font = new System.Drawing.Font("Roboto", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBoxNumber.Location = new System.Drawing.Point(290, 295);
            this.TextBoxNumber.Name = "TextBoxNumber";
            this.TextBoxNumber.Size = new System.Drawing.Size(369, 42);
            this.TextBoxNumber.TabIndex = 23;
            this.TextBoxNumber.Text = "-----";
            this.TextBoxNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNumber_KeyPress);
            // 
            // labelinfo2
            // 
            this.labelinfo2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelinfo2.Location = new System.Drawing.Point(68, 12);
            this.labelinfo2.Name = "labelinfo2";
            this.labelinfo2.Size = new System.Drawing.Size(788, 38);
            this.labelinfo2.TabIndex = 22;
            this.labelinfo2.Text = "Haz lo posible para poder memorizar la serie de números porque hay limite de tiem" +
    "po.";
            this.labelinfo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Panel_R
            // 
            this.Panel_R.Controls.Add(this.labelRN);
            this.Panel_R.Controls.Add(this.label4);
            this.Panel_R.Controls.Add(this.pictureBox2);
            this.Panel_R.Controls.Add(this.labelR);
            this.Panel_R.Location = new System.Drawing.Point(12, 12);
            this.Panel_R.Name = "Panel_R";
            this.Panel_R.Size = new System.Drawing.Size(906, 446);
            this.Panel_R.TabIndex = 29;
            this.Panel_R.Visible = false;
            // 
            // labelRN
            // 
            this.labelRN.AutoSize = true;
            this.labelRN.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRN.Location = new System.Drawing.Point(322, 248);
            this.labelRN.Name = "labelRN";
            this.labelRN.Size = new System.Drawing.Size(321, 32);
            this.labelRN.TabIndex = 26;
            this.labelRN.Text = "Te has quedato en el Nivel ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(322, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(350, 162);
            this.label4.TabIndex = 24;
            this.label4.Text = "Serie de números\r\n---\r\nResultados:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SEMCP.Properties.Resources.baseline_pin_black_48dp;
            this.pictureBox2.Location = new System.Drawing.Point(199, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            // 
            // labelR
            // 
            this.labelR.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelR.Location = new System.Drawing.Point(64, 340);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(792, 50);
            this.labelR.TabIndex = 22;
            this.labelR.Text = "Se deberá recordar una lista de artículos, se dará un tiempo límite para tratar d" +
    "e\r\nmemorizar.";
            this.labelR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_SN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(930, 470);
            this.Controls.Add(this.Panel_R);
            this.Controls.Add(this.Panel_J);
            this.Controls.Add(this.Panel_I);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_SN";
            this.Text = "Form_SN";
            this.Panel_I.ResumeLayout(false);
            this.Panel_I.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Panel_J.ResumeLayout(false);
            this.Panel_J.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.P_T)).EndInit();
            this.Panel_R.ResumeLayout(false);
            this.Panel_R.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_I;
        private System.Windows.Forms.Button ButtonJugar;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Label Label_Titulo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Panel_J;
        private System.Windows.Forms.TextBox TextBoxNumber;
        private System.Windows.Forms.Label labelinfo2;
        private System.Windows.Forms.Label labelSerie;
        private System.Windows.Forms.Label LabelN;
        private System.Windows.Forms.Button ButtonComprobar;
        private System.Windows.Forms.Label labelinfo3;
        private System.Windows.Forms.Label label_T;
        public System.Windows.Forms.PictureBox P_T;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel Panel_R;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Label labelRN;
    }
}