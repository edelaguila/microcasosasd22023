namespace Prodeportes_admin
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox1.AutoCompleteSource = AutoCompleteSource.HistoryList;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(164, 109);
            textBox1.MaxLength = 50;
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = " Usuario";
            textBox1.Size = new Size(245, 27);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(164, 157);
            textBox2.MaxLength = 100;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.PlaceholderText = " Constraseña";
            textBox2.Size = new Size(245, 27);
            textBox2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(208, 55);
            label3.Name = "label3";
            label3.Size = new Size(172, 22);
            label3.TabIndex = 4;
            label3.Text = "Inicio de Sesión";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(120, 112, 112);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(241, 216);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 11, 11);
            ClientSize = new Size(562, 328);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MaximumSize = new Size(580, 375);
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Deportes-Pro Admin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private Button button1;
    }
}