namespace Software_de_taquilla.Views.UserViews
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            dtFecha = new DateTimePicker();
            btnNotificacion = new Button();
            pctPelicula1 = new PictureBox();
            pctPelicula2 = new PictureBox();
            pctPelicula3 = new PictureBox();
            pctPelicula4 = new PictureBox();
            pctPelicula5 = new PictureBox();
            pctPelicula6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pctPelicula1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctPelicula2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctPelicula3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctPelicula4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctPelicula5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pctPelicula6).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(188, 188, 188);
            label1.Location = new Point(30, 28);
            label1.Name = "label1";
            label1.Size = new Size(79, 16);
            label1.TabIndex = 0;
            label1.Text = "Bienvenido";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(12, 64, 76);
            label2.Location = new Point(30, 54);
            label2.Name = "label2";
            label2.Size = new Size(127, 28);
            label2.TabIndex = 1;
            label2.Text = "Cartelera";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(42, 212);
            label3.Name = "label3";
            label3.Size = new Size(55, 17);
            label3.TabIndex = 2;
            label3.Text = "Película";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(227, 212);
            label4.Name = "label4";
            label4.Size = new Size(55, 17);
            label4.TabIndex = 3;
            label4.Text = "Película";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(428, 212);
            label5.Name = "label5";
            label5.Size = new Size(55, 17);
            label5.TabIndex = 4;
            label5.Text = "Película";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(42, 373);
            label6.Name = "label6";
            label6.Size = new Size(55, 17);
            label6.TabIndex = 5;
            label6.Text = "Película";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(227, 373);
            label7.Name = "label7";
            label7.Size = new Size(55, 17);
            label7.TabIndex = 6;
            label7.Text = "Película";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(428, 373);
            label8.Name = "label8";
            label8.Size = new Size(55, 17);
            label8.TabIndex = 7;
            label8.Text = "Película";
            // 
            // dtFecha
            // 
            dtFecha.Location = new Point(288, 37);
            dtFecha.Name = "dtFecha";
            dtFecha.Size = new Size(200, 23);
            dtFecha.TabIndex = 8;
            dtFecha.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // btnNotificacion
            // 
            btnNotificacion.FlatAppearance.BorderSize = 0;
            btnNotificacion.FlatStyle = FlatStyle.Flat;
            btnNotificacion.Image = (Image)resources.GetObject("btnNotificacion.Image");
            btnNotificacion.Location = new Point(515, 21);
            btnNotificacion.Name = "btnNotificacion";
            btnNotificacion.Size = new Size(38, 39);
            btnNotificacion.TabIndex = 9;
            btnNotificacion.UseVisualStyleBackColor = true;
            // 
            // pctPelicula1
            // 
            pctPelicula1.Location = new Point(30, 116);
            pctPelicula1.Name = "pctPelicula1";
            pctPelicula1.Size = new Size(116, 84);
            pctPelicula1.TabIndex = 10;
            pctPelicula1.TabStop = false;
            pctPelicula1.Click += pictureBox1_Click;
            // 
            // pctPelicula2
            // 
            pctPelicula2.Location = new Point(215, 116);
            pctPelicula2.Name = "pctPelicula2";
            pctPelicula2.Size = new Size(116, 84);
            pctPelicula2.TabIndex = 11;
            pctPelicula2.TabStop = false;
            // 
            // pctPelicula3
            // 
            pctPelicula3.Location = new Point(416, 116);
            pctPelicula3.Name = "pctPelicula3";
            pctPelicula3.Size = new Size(116, 84);
            pctPelicula3.TabIndex = 12;
            pctPelicula3.TabStop = false;
            // 
            // pctPelicula4
            // 
            pctPelicula4.Location = new Point(30, 279);
            pctPelicula4.Name = "pctPelicula4";
            pctPelicula4.Size = new Size(116, 84);
            pctPelicula4.TabIndex = 13;
            pctPelicula4.TabStop = false;
            // 
            // pctPelicula5
            // 
            pctPelicula5.Location = new Point(215, 279);
            pctPelicula5.Name = "pctPelicula5";
            pctPelicula5.Size = new Size(116, 84);
            pctPelicula5.TabIndex = 14;
            pctPelicula5.TabStop = false;
            // 
            // pctPelicula6
            // 
            pctPelicula6.Location = new Point(416, 279);
            pctPelicula6.Name = "pctPelicula6";
            pctPelicula6.Size = new Size(116, 84);
            pctPelicula6.TabIndex = 15;
            pctPelicula6.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(586, 427);
            Controls.Add(pctPelicula6);
            Controls.Add(pctPelicula5);
            Controls.Add(pctPelicula4);
            Controls.Add(pctPelicula3);
            Controls.Add(pctPelicula2);
            Controls.Add(pctPelicula1);
            Controls.Add(btnNotificacion);
            Controls.Add(dtFecha);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Cartelera";
            ((System.ComponentModel.ISupportInitialize)pctPelicula1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctPelicula2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctPelicula3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctPelicula4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctPelicula5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pctPelicula6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private DateTimePicker dtFecha;
        private Button btnNotificacion;
        private PictureBox pctPelicula1;
        private PictureBox pctPelicula2;
        private PictureBox pctPelicula3;
        private PictureBox pctPelicula4;
        private PictureBox pctPelicula5;
        private PictureBox pctPelicula6;
    }
}