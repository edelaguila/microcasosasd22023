namespace Software_de_taquilla.Views.UserViews
{
    partial class MenuAyuda
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            button4 = new Button();
            txt_telefonoayuda = new TextBox();
            txt_correoayuda = new TextBox();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(12, 62, 85);
            label1.Location = new Point(24, 14);
            label1.Name = "label1";
            label1.Size = new Size(227, 32);
            label1.TabIndex = 0;
            label1.Text = "Menú de Ayuda";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Image = Properties.Resources.manual3;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(135, 56);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(553, 50);
            button1.TabIndex = 1;
            button1.Text = "Manual de Usuario";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Image = Properties.Resources.ask1;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(135, 110);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(551, 50);
            button2.TabIndex = 2;
            button2.Text = "Preguntas frecuentes";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Image = Properties.Resources.dictionary1;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(136, 171);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(553, 50);
            button3.TabIndex = 3;
            button3.Text = "Diccionario de conceptos";
            button3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(button4);
            panel1.Controls.Add(txt_telefonoayuda);
            panel1.Controls.Add(txt_correoayuda);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(134, 226);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(554, 113);
            panel1.TabIndex = 8;
            // 
            // button4
            // 
            button4.Enabled = false;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Image = Properties.Resources.headphones1;
            button4.Location = new Point(3, 2);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(52, 52);
            button4.TabIndex = 5;
            button4.UseVisualStyleBackColor = true;
            // 
            // txt_telefonoayuda
            // 
            txt_telefonoayuda.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_telefonoayuda.Location = new Point(217, 81);
            txt_telefonoayuda.Margin = new Padding(3, 2, 3, 2);
            txt_telefonoayuda.Name = "txt_telefonoayuda";
            txt_telefonoayuda.Size = new Size(183, 22);
            txt_telefonoayuda.TabIndex = 4;
            txt_telefonoayuda.Click += txt_telefonoayuda_Click;
            txt_telefonoayuda.Leave += txt_telefonoayuda_Leave;
            // 
            // txt_correoayuda
            // 
            txt_correoayuda.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_correoayuda.Location = new Point(217, 35);
            txt_correoayuda.Margin = new Padding(3, 2, 3, 2);
            txt_correoayuda.Name = "txt_correoayuda";
            txt_correoayuda.Size = new Size(183, 22);
            txt_correoayuda.TabIndex = 3;
            txt_correoayuda.Click += txt_correoayuda_Click;
            txt_correoayuda.Leave += txt_correoayuda_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(54, 23);
            label4.Name = "label4";
            label4.Size = new Size(0, 17);
            label4.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(54, 8);
            label3.Name = "label3";
            label3.Size = new Size(467, 17);
            label3.TabIndex = 0;
            label3.Text = "Si tienes otra pregunta, te contactariamos via correo electrónico o teléfono.";
            // 
            // MenuAyuda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(766, 404);
            Controls.Add(panel1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(831, 450);
            Name = "MenuAyuda";
            Text = "MenuAyuda";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private TextBox txt_telefonoayuda;
        private TextBox txt_correoayuda;
        private Button button4;
    }
}