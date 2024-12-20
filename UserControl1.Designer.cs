namespace Musica
{
    partial class UserControl1
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Pablo = new System.Windows.Forms.PictureBox();
            this.CRO = new System.Windows.Forms.PictureBox();
            this.duki = new System.Windows.Forms.PictureBox();
            this.Ysya = new System.Windows.Forms.PictureBox();
            this.Emilia = new System.Windows.Forms.PictureBox();
            this.Nicki = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.reaunudar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CRO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ysya)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emilia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nicki)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Green;
            this.button1.Location = new System.Drawing.Point(93, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Anterior";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Anterior);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Green;
            this.button2.Location = new System.Drawing.Point(209, 269);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Pausar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Pausar);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Green;
            this.button3.Location = new System.Drawing.Point(332, 268);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Siguiente";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Siguiente);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.TextChanged += new System.EventHandler(this.CambiarImagen);
            // 
            // Pablo
            // 
            this.Pablo.Image = ((System.Drawing.Image)(resources.GetObject("Pablo.Image")));
            this.Pablo.Location = new System.Drawing.Point(144, 80);
            this.Pablo.Name = "Pablo";
            this.Pablo.Size = new System.Drawing.Size(228, 108);
            this.Pablo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pablo.TabIndex = 5;
            this.Pablo.TabStop = false;
            // 
            // CRO
            // 
            this.CRO.Image = ((System.Drawing.Image)(resources.GetObject("CRO.Image")));
            this.CRO.Location = new System.Drawing.Point(144, 80);
            this.CRO.Name = "CRO";
            this.CRO.Size = new System.Drawing.Size(207, 108);
            this.CRO.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CRO.TabIndex = 6;
            this.CRO.TabStop = false;
            // 
            // duki
            // 
            this.duki.Image = ((System.Drawing.Image)(resources.GetObject("duki.Image")));
            this.duki.Location = new System.Drawing.Point(144, 80);
            this.duki.Name = "duki";
            this.duki.Size = new System.Drawing.Size(193, 108);
            this.duki.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.duki.TabIndex = 7;
            this.duki.TabStop = false;
            // 
            // Ysya
            // 
            this.Ysya.Image = ((System.Drawing.Image)(resources.GetObject("Ysya.Image")));
            this.Ysya.Location = new System.Drawing.Point(144, 80);
            this.Ysya.Name = "Ysya";
            this.Ysya.Size = new System.Drawing.Size(207, 108);
            this.Ysya.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ysya.TabIndex = 9;
            this.Ysya.TabStop = false;
            // 
            // Emilia
            // 
            this.Emilia.Image = ((System.Drawing.Image)(resources.GetObject("Emilia.Image")));
            this.Emilia.Location = new System.Drawing.Point(144, 80);
            this.Emilia.Name = "Emilia";
            this.Emilia.Size = new System.Drawing.Size(207, 108);
            this.Emilia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Emilia.TabIndex = 10;
            this.Emilia.TabStop = false;
            // 
            // Nicki
            // 
            this.Nicki.Image = ((System.Drawing.Image)(resources.GetObject("Nicki.Image")));
            this.Nicki.Location = new System.Drawing.Point(144, 80);
            this.Nicki.Name = "Nicki";
            this.Nicki.Size = new System.Drawing.Size(207, 108);
            this.Nicki.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Nicki.TabIndex = 11;
            this.Nicki.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(144, 207);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(228, 45);
            this.trackBar1.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "label2";
            // 
            // reaunudar
            // 
            this.reaunudar.BackColor = System.Drawing.Color.Green;
            this.reaunudar.Location = new System.Drawing.Point(209, 315);
            this.reaunudar.Name = "reaunudar";
            this.reaunudar.Size = new System.Drawing.Size(75, 23);
            this.reaunudar.TabIndex = 14;
            this.reaunudar.Text = "Reanudar";
            this.reaunudar.UseVisualStyleBackColor = false;
            this.reaunudar.Click += new System.EventHandler(this.Reanudar);
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reaunudar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.Nicki);
            this.Controls.Add(this.Emilia);
            this.Controls.Add(this.Ysya);
            this.Controls.Add(this.duki);
            this.Controls.Add(this.CRO);
            this.Controls.Add(this.Pablo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(550, 413);
            ((System.ComponentModel.ISupportInitialize)(this.Pablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CRO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ysya)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Emilia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nicki)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

       
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Pablo;
        private System.Windows.Forms.PictureBox CRO;
        private System.Windows.Forms.PictureBox duki;
        private System.Windows.Forms.PictureBox Ysya;
        private System.Windows.Forms.PictureBox Emilia;
        private System.Windows.Forms.PictureBox Nicki;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button reaunudar;
    }
}
