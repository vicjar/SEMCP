
namespace SEMCP
{
    partial class FormSD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSD));
            this.amarillo = new System.Windows.Forms.PictureBox();
            this.rojo = new System.Windows.Forms.PictureBox();
            this.azul = new System.Windows.Forms.PictureBox();
            this.verde = new System.Windows.Forms.PictureBox();
            this.iniciar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.puntos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.amarillo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rojo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.azul)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.verde)).BeginInit();
            this.SuspendLayout();
            // 
            // amarillo
            // 
            this.amarillo.Image = ((System.Drawing.Image)(resources.GetObject("amarillo.Image")));
            this.amarillo.Location = new System.Drawing.Point(150, 22);
            this.amarillo.Name = "amarillo";
            this.amarillo.Size = new System.Drawing.Size(200, 200);
            this.amarillo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.amarillo.TabIndex = 0;
            this.amarillo.TabStop = false;
            this.amarillo.Click += new System.EventHandler(this.amarillo_Click);
            this.amarillo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.amarillo_MouseDown);
            this.amarillo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.amarillo_MouseUp);
            // 
            // rojo
            // 
            this.rojo.Image = ((System.Drawing.Image)(resources.GetObject("rojo.Image")));
            this.rojo.Location = new System.Drawing.Point(588, 22);
            this.rojo.Name = "rojo";
            this.rojo.Size = new System.Drawing.Size(200, 200);
            this.rojo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rojo.TabIndex = 1;
            this.rojo.TabStop = false;
            this.rojo.Click += new System.EventHandler(this.amarillo_Click);
            this.rojo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rojo_MouseDown);
            this.rojo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.rojo_MouseUp);
            // 
            // azul
            // 
            this.azul.Image = ((System.Drawing.Image)(resources.GetObject("azul.Image")));
            this.azul.Location = new System.Drawing.Point(150, 260);
            this.azul.Name = "azul";
            this.azul.Size = new System.Drawing.Size(200, 200);
            this.azul.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.azul.TabIndex = 2;
            this.azul.TabStop = false;
            this.azul.Click += new System.EventHandler(this.amarillo_Click);
            this.azul.MouseDown += new System.Windows.Forms.MouseEventHandler(this.azul_MouseDown);
            this.azul.MouseUp += new System.Windows.Forms.MouseEventHandler(this.azul_MouseUp);
            // 
            // verde
            // 
            this.verde.Image = ((System.Drawing.Image)(resources.GetObject("verde.Image")));
            this.verde.Location = new System.Drawing.Point(588, 260);
            this.verde.Name = "verde";
            this.verde.Size = new System.Drawing.Size(200, 200);
            this.verde.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.verde.TabIndex = 3;
            this.verde.TabStop = false;
            this.verde.Click += new System.EventHandler(this.amarillo_Click);
            this.verde.MouseDown += new System.Windows.Forms.MouseEventHandler(this.verde_MouseDown);
            this.verde.MouseUp += new System.Windows.Forms.MouseEventHandler(this.verde_MouseUp);
            // 
            // iniciar
            // 
            this.iniciar.Location = new System.Drawing.Point(421, 491);
            this.iniciar.Name = "iniciar";
            this.iniciar.Size = new System.Drawing.Size(75, 23);
            this.iniciar.TabIndex = 4;
            this.iniciar.Text = "Iniciar";
            this.iniciar.UseVisualStyleBackColor = true;
            this.iniciar.Click += new System.EventHandler(this.iniciar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(436, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Puntaje";
            // 
            // puntos
            // 
            this.puntos.Location = new System.Drawing.Point(463, 238);
            this.puntos.Name = "puntos";
            this.puntos.Size = new System.Drawing.Size(25, 25);
            this.puntos.TabIndex = 6;
            this.puntos.Text = "0";
            // 
            // FormSD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(949, 558);
            this.Controls.Add(this.puntos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iniciar);
            this.Controls.Add(this.verde);
            this.Controls.Add(this.azul);
            this.Controls.Add(this.rojo);
            this.Controls.Add(this.amarillo);
            this.Name = "FormSD";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormSD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.amarillo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rojo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.azul)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.verde)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox amarillo;
        private System.Windows.Forms.PictureBox rojo;
        private System.Windows.Forms.PictureBox azul;
        private System.Windows.Forms.PictureBox verde;
        private System.Windows.Forms.Button iniciar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label puntos;
    }
}