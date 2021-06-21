
namespace SEMCP
{
    partial class FormLA
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelLista = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.lListaAcierto = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lTiempo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelPuntaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Timpo restante para memorizar: ";
            // 
            // labelLista
            // 
            this.labelLista.AutoSize = true;
            this.labelLista.Location = new System.Drawing.Point(356, 115);
            this.labelLista.Name = "labelLista";
            this.labelLista.Size = new System.Drawing.Size(38, 15);
            this.labelLista.TabIndex = 1;
            this.labelLista.Text = "label2";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(356, 303);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(243, 319);
            this.listBox1.TabIndex = 2;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(637, 303);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(255, 319);
            this.listBox2.TabIndex = 3;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.ItemHeight = 15;
            this.listBox3.Location = new System.Drawing.Point(916, 303);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(248, 319);
            this.listBox3.TabIndex = 4;
            // 
            // lListaAcierto
            // 
            this.lListaAcierto.AutoSize = true;
            this.lListaAcierto.Location = new System.Drawing.Point(843, 115);
            this.lListaAcierto.Name = "lListaAcierto";
            this.lListaAcierto.Size = new System.Drawing.Size(38, 15);
            this.lListaAcierto.TabIndex = 5;
            this.lListaAcierto.Text = "label2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(916, 241);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Comprobar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lTiempo
            // 
            this.lTiempo.AutoSize = true;
            this.lTiempo.Font = new System.Drawing.Font("Yu Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lTiempo.Location = new System.Drawing.Point(487, 26);
            this.lTiempo.Name = "lTiempo";
            this.lTiempo.Size = new System.Drawing.Size(365, 38);
            this.lTiempo.TabIndex = 7;
            this.lTiempo.Text = "Tiempo para memorizar: ";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelPuntaje
            // 
            this.labelPuntaje.AutoSize = true;
            this.labelPuntaje.Location = new System.Drawing.Point(952, 48);
            this.labelPuntaje.Name = "labelPuntaje";
            this.labelPuntaje.Size = new System.Drawing.Size(38, 15);
            this.labelPuntaje.TabIndex = 8;
            this.labelPuntaje.Text = "label2";
            // 
            // FormLA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 654);
            this.Controls.Add(this.labelPuntaje);
            this.Controls.Add(this.lTiempo);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lListaAcierto);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.labelLista);
            this.Controls.Add(this.label1);
            this.Name = "FormLA";
            this.Text = "Timpo restante para memorizar: ";
            this.Load += new System.EventHandler(this.FormLA_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelLista;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Label lListaAcierto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lTiempo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelPuntaje;
    }
}