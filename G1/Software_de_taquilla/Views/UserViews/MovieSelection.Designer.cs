namespace Software_de_taquilla.Views.UserViews
{
    partial class MovieSelection
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
            this.pic_imag = new System.Windows.Forms.PictureBox();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.lbl_3 = new System.Windows.Forms.Label();
            this.lbl_4 = new System.Windows.Forms.Label();
            this.panel_horarios = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_imag)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_imag
            // 
            this.pic_imag.Location = new System.Drawing.Point(14, 64);
            this.pic_imag.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pic_imag.Name = "pic_imag";
            this.pic_imag.Size = new System.Drawing.Size(359, 257);
            this.pic_imag.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pic_imag.TabIndex = 0;
            this.pic_imag.TabStop = false;
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_1.Location = new System.Drawing.Point(15, 25);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(60, 19);
            this.lbl_1.TabIndex = 1;
            this.lbl_1.Text = "label1";
            // 
            // lbl_2
            // 
            this.lbl_2.AutoSize = true;
            this.lbl_2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_2.Location = new System.Drawing.Point(89, 337);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(60, 19);
            this.lbl_2.TabIndex = 2;
            this.lbl_2.Text = "label2";
            // 
            // lbl_3
            // 
            this.lbl_3.AutoSize = true;
            this.lbl_3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_3.Location = new System.Drawing.Point(160, 337);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(60, 19);
            this.lbl_3.TabIndex = 3;
            this.lbl_3.Text = "label3";
            // 
            // lbl_4
            // 
            this.lbl_4.AutoSize = true;
            this.lbl_4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_4.Location = new System.Drawing.Point(242, 337);
            this.lbl_4.Name = "lbl_4";
            this.lbl_4.Size = new System.Drawing.Size(60, 19);
            this.lbl_4.TabIndex = 4;
            this.lbl_4.Text = "label4";
            // 
            // panel_horarios
            // 
            this.panel_horarios.AutoScroll = true;
            this.panel_horarios.Location = new System.Drawing.Point(416, 64);
            this.panel_horarios.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel_horarios.Name = "panel_horarios";
            this.panel_horarios.Size = new System.Drawing.Size(152, 257);
            this.panel_horarios.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(399, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(187, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "CONSULTA HORARIOS";
            // 
            // MovieSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(633, 392);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel_horarios);
            this.Controls.Add(this.lbl_4);
            this.Controls.Add(this.lbl_3);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.pic_imag);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MovieSelection";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovieSelection";
            ((System.ComponentModel.ISupportInitialize)(this.pic_imag)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbl_1;
        private Label lbl_2;
        private Label lbl_3;
        private Label lbl_4;
        public PictureBox pic_imag;
        private FlowLayoutPanel panel_horarios;
        private Label label5;
    }
}