namespace Software_de_taquilla.Views
{
    partial class Login
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
            txt_user = new TextBox();
            txt_pass = new TextBox();
            btn_login = new Button();
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            combo_role = new ComboBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txt_user
            // 
            txt_user.BackColor = Color.White;
            txt_user.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_user.ForeColor = SystemColors.WindowFrame;
            txt_user.Location = new Point(542, 124);
            txt_user.Name = "txt_user";
            txt_user.PlaceholderText = "Usuario";
            txt_user.Size = new Size(230, 24);
            txt_user.TabIndex = 0;
            // 
            // txt_pass
            // 
            txt_pass.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_pass.ForeColor = SystemColors.WindowFrame;
            txt_pass.Location = new Point(539, 194);
            txt_pass.Name = "txt_pass";
            txt_pass.PasswordChar = '*';
            txt_pass.PlaceholderText = "Contraseña";
            txt_pass.Size = new Size(229, 24);
            txt_pass.TabIndex = 1;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.FromArgb(36, 171, 218);
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(539, 274);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(231, 25);
            btn_login.TabIndex = 2;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(36, 171, 218);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(427, 376);
            panel1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(38, 181);
            label3.Name = "label3";
            label3.Size = new Size(341, 45);
            label3.TabIndex = 1;
            label3.Text = "MACRO CINEMA";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bookman Old Style", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(48, 140);
            label2.Name = "label2";
            label2.Size = new Size(315, 45);
            label2.TabIndex = 0;
            label2.Text = "BIENVENIDO A";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(36, 171, 218);
            label1.ImageAlign = ContentAlignment.TopRight;
            label1.Location = new Point(574, 50);
            label1.Name = "label1";
            label1.Size = new Size(147, 45);
            label1.TabIndex = 4;
            label1.Text = "LOGIN";
            // 
            // combo_role
            // 
            combo_role.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_role.FlatStyle = FlatStyle.Popup;
            combo_role.ForeColor = SystemColors.GrayText;
            combo_role.FormattingEnabled = true;
            combo_role.Items.AddRange(new object[] { "Administrador", "Empleado", "Cliente" });
            combo_role.Location = new Point(660, 230);
            combo_role.Name = "combo_role";
            combo_role.Size = new Size(108, 23);
            combo_role.TabIndex = 5;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(864, 376);
            Controls.Add(combo_role);
            Controls.Add(label1);
            Controls.Add(panel1);
            Controls.Add(btn_login);
            Controls.Add(txt_pass);
            Controls.Add(txt_user);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load_1;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Button btn_login;
        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label2;
        public TextBox txt_user;
        public TextBox txt_pass;
        public ComboBox combo_role;
    }
}