namespace Software_de_taquilla.Views
{
    partial class Register
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
            btn_reg = new Button();
            txt_pass = new TextBox();
            txt_user = new TextBox();
            SuspendLayout();
            // 
            // btn_reg
            // 
            btn_reg.BackColor = Color.FromArgb(36, 171, 218);
            btn_reg.FlatAppearance.BorderSize = 0;
            btn_reg.FlatStyle = FlatStyle.Flat;
            btn_reg.Font = new Font("Bookman Old Style", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            btn_reg.ForeColor = Color.White;
            btn_reg.Location = new Point(60, 228);
            btn_reg.Name = "btn_reg";
            btn_reg.Size = new Size(231, 25);
            btn_reg.TabIndex = 5;
            btn_reg.Text = "Registrar";
            btn_reg.UseVisualStyleBackColor = false;
            // 
            // txt_pass
            // 
            txt_pass.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_pass.ForeColor = SystemColors.WindowFrame;
            txt_pass.Location = new Point(60, 148);
            txt_pass.Name = "txt_pass";
            txt_pass.PlaceholderText = "Contraseña";
            txt_pass.Size = new Size(229, 24);
            txt_pass.TabIndex = 4;
            // 
            // txt_user
            // 
            txt_user.BackColor = Color.White;
            txt_user.Font = new Font("Times New Roman", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_user.ForeColor = SystemColors.WindowFrame;
            txt_user.Location = new Point(63, 78);
            txt_user.Name = "txt_user";
            txt_user.PlaceholderText = "Usuario";
            txt_user.Size = new Size(230, 24);
            txt_user.TabIndex = 3;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(349, 363);
            Controls.Add(btn_reg);
            Controls.Add(txt_pass);
            Controls.Add(txt_user);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Button btn_reg;
        public TextBox txt_pass;
        public TextBox txt_user;
    }
}