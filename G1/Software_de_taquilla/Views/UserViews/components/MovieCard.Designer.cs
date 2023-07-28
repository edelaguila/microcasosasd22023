namespace Software_de_taquilla.Views.UserViews.components
{
    partial class MovieCard
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
            panel_card = new Panel();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            time_line = new ProgressBar();
            label1 = new Label();
            picture = new PictureBox();
            panel_card.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            SuspendLayout();
            // 
            // panel_card
            // 
            panel_card.Controls.Add(label3);
            panel_card.Controls.Add(pictureBox1);
            panel_card.Controls.Add(label2);
            panel_card.Controls.Add(time_line);
            panel_card.Controls.Add(label1);
            panel_card.Controls.Add(picture);
            panel_card.Dock = DockStyle.Fill;
            panel_card.Location = new Point(0, 0);
            panel_card.Name = "panel_card";
            panel_card.Size = new Size(228, 253);
            panel_card.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(162, 222);
            label3.Name = "label3";
            label3.Size = new Size(26, 15);
            label3.TabIndex = 10;
            label3.Text = "Ver";
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.play_button1;
            pictureBox1.Location = new Point(190, 217);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.MouseClick += pictureBox1_MouseClick;
            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            pictureBox1.MouseLeave += pictureBox1_MouseLeave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(16, 223);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 8;
            label2.Text = "label2";
            // 
            // time_line
            // 
            time_line.Location = new Point(16, 211);
            time_line.Maximum = 500;
            time_line.Name = "time_line";
            time_line.Size = new Size(199, 2);
            time_line.Step = 60;
            time_line.Style = ProgressBarStyle.Continuous;
            time_line.TabIndex = 7;
            time_line.Value = 60;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 11);
            label1.Name = "label1";
            label1.Size = new Size(105, 17);
            label1.TabIndex = 6;
            label1.Text = "Mujer Maravilla";
            // 
            // picture
            // 
            picture.Location = new Point(14, 42);
            picture.Name = "picture";
            picture.Size = new Size(201, 163);
            picture.SizeMode = PictureBoxSizeMode.StretchImage;
            picture.TabIndex = 5;
            picture.TabStop = false;
            // 
            // MovieCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel_card);
            Name = "MovieCard";
            Size = new Size(228, 253);
            panel_card.ResumeLayout(false);
            panel_card.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_card;
        private PictureBox pictureBox1;
        private Label label2;
        public ProgressBar time_line;
        public Label label1;
        public PictureBox picture;
        private Label label3;
    }
}
