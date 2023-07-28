namespace Interface_Usuario
{
    partial class Interface
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Salir = new System.Windows.Forms.Button();
            this.TablaPosicion = new System.Windows.Forms.Button();
            this.VerEquipoB = new System.Windows.Forms.Button();
            this.Vtablero = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.Salir);
            this.panel1.Controls.Add(this.TablaPosicion);
            this.panel1.Controls.Add(this.VerEquipoB);
            this.panel1.Controls.Add(this.Vtablero);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(230, 471);
            this.panel1.TabIndex = 0;
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(53, 255);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(127, 23);
            this.Salir.TabIndex = 4;
            this.Salir.Text = "Salir";
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // TablaPosicion
            // 
            this.TablaPosicion.Location = new System.Drawing.Point(53, 226);
            this.TablaPosicion.Name = "TablaPosicion";
            this.TablaPosicion.Size = new System.Drawing.Size(127, 23);
            this.TablaPosicion.TabIndex = 3;
            this.TablaPosicion.Text = "Tabla de Posiciones";
            this.TablaPosicion.UseVisualStyleBackColor = true;
            this.TablaPosicion.Click += new System.EventHandler(this.button3_Click);
            // 
            // VerEquipoB
            // 
            this.VerEquipoB.Location = new System.Drawing.Point(53, 197);
            this.VerEquipoB.Name = "VerEquipoB";
            this.VerEquipoB.Size = new System.Drawing.Size(127, 23);
            this.VerEquipoB.TabIndex = 2;
            this.VerEquipoB.Text = "Ver Equipo";
            this.VerEquipoB.UseVisualStyleBackColor = true;
            this.VerEquipoB.Click += new System.EventHandler(this.button2_Click);
            // 
            // Vtablero
            // 
            this.Vtablero.Location = new System.Drawing.Point(53, 168);
            this.Vtablero.Name = "Vtablero";
            this.Vtablero.Size = new System.Drawing.Size(127, 23);
            this.Vtablero.TabIndex = 1;
            this.Vtablero.Text = "Ver Tablero";
            this.Vtablero.UseVisualStyleBackColor = true;
            this.Vtablero.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Interface_Usuario.Properties.Resources.usu;
            this.pictureBox1.Location = new System.Drawing.Point(90, 105);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(272, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(346, 480);
            this.panel2.TabIndex = 1;
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 537);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Interface";
            this.Text = "Interface";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Button TablaPosicion;
        private Button VerEquipoB;
        private Button Vtablero;
        private Button Salir;
        private Panel panel2;
    }
}