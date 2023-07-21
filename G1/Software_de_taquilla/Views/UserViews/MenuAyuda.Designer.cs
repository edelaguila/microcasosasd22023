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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.txt_telefonoayuda = new System.Windows.Forms.TextBox();
            this.txt_correoayuda = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(62)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(27, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menú de Ayuda";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Image = global::Software_de_taquilla.Properties.Resources.manual3;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(154, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(632, 66);
            this.button1.TabIndex = 1;
            this.button1.Text = "Manual de Usuario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Image = global::Software_de_taquilla.Properties.Resources.ask1;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(154, 147);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(630, 67);
            this.button2.TabIndex = 2;
            this.button2.Text = "Preguntas frecuentes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.Image = global::Software_de_taquilla.Properties.Resources.dictionary1;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(156, 228);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(632, 67);
            this.button3.TabIndex = 3;
            this.button3.Text = "Diccionario de conceptos";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.txt_telefonoayuda);
            this.panel1.Controls.Add(this.txt_correoayuda);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(153, 301);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(633, 151);
            this.panel1.TabIndex = 8;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = global::Software_de_taquilla.Properties.Resources.headphones1;
            this.button4.Location = new System.Drawing.Point(3, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(59, 70);
            this.button4.TabIndex = 5;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // txt_telefonoayuda
            // 
            this.txt_telefonoayuda.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_telefonoayuda.Location = new System.Drawing.Point(85, 108);
            this.txt_telefonoayuda.Name = "txt_telefonoayuda";
            this.txt_telefonoayuda.Size = new System.Drawing.Size(504, 26);
            this.txt_telefonoayuda.TabIndex = 4;
            this.txt_telefonoayuda.Click += new System.EventHandler(this.txt_telefonoayuda_Click);
            this.txt_telefonoayuda.Leave += new System.EventHandler(this.txt_telefonoayuda_Leave);
            // 
            // txt_correoayuda
            // 
            this.txt_correoayuda.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_correoayuda.Location = new System.Drawing.Point(85, 47);
            this.txt_correoayuda.Name = "txt_correoayuda";
            this.txt_correoayuda.Size = new System.Drawing.Size(504, 26);
            this.txt_correoayuda.TabIndex = 3;
            this.txt_correoayuda.Click += new System.EventHandler(this.txt_correoayuda_Click);
            this.txt_correoayuda.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_correoayuda.Leave += new System.EventHandler(this.txt_correoayuda_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(62, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 20);
            this.label4.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(62, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(569, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Si tienes otra pregunta, te contactariamos via correo electrónico o teléfono.";
            // 
            // MenuAyuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(875, 539);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(950, 600);
            this.Name = "MenuAyuda";
            this.Text = "MenuAyuda";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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