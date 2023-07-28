namespace Software_de_taquilla.Views.AdminViews
{
    partial class UserManagment
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
            txt_name = new TextBox();
            txt_contrasenia = new TextBox();
            data_grid = new DataGridView();
            btn_save = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            role_list = new ComboBox();
            btn_delete = new Button();
            btn_update = new Button();
            passImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)data_grid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)passImage).BeginInit();
            SuspendLayout();
            // 
            // txt_name
            // 
            txt_name.BackColor = Color.WhiteSmoke;
            txt_name.Font = new Font("Century Gothic", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txt_name.Location = new Point(44, 77);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(178, 25);
            txt_name.TabIndex = 0;
            // 
            // txt_contrasenia
            // 
            txt_contrasenia.BackColor = Color.WhiteSmoke;
            txt_contrasenia.Font = new Font("Century Gothic", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_contrasenia.Location = new Point(44, 140);
            txt_contrasenia.Name = "txt_contrasenia";
            txt_contrasenia.PasswordChar = '*';
            txt_contrasenia.Size = new Size(178, 24);
            txt_contrasenia.TabIndex = 1;
            // 
            // data_grid
            // 
            data_grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            data_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_grid.Location = new Point(291, 47);
            data_grid.Name = "data_grid";
            data_grid.RowHeadersVisible = false;
            data_grid.RowHeadersWidth = 51;
            data_grid.RowTemplate.Height = 25;
            data_grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_grid.Size = new Size(682, 296);
            data_grid.TabIndex = 4;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.SeaGreen;
            btn_save.FlatAppearance.BorderSize = 0;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_save.ForeColor = Color.White;
            btn_save.Location = new Point(44, 280);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(178, 23);
            btn_save.TabIndex = 5;
            btn_save.Text = "Guardar";
            btn_save.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(50, 54);
            label1.Name = "label1";
            label1.Size = new Size(51, 17);
            label1.TabIndex = 6;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(50, 122);
            label2.Name = "label2";
            label2.Size = new Size(77, 17);
            label2.TabIndex = 7;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(50, 184);
            label3.Name = "label3";
            label3.Size = new Size(26, 17);
            label3.TabIndex = 8;
            label3.Text = "Rol";
            // 
            // role_list
            // 
            role_list.BackColor = Color.WhiteSmoke;
            role_list.DropDownStyle = ComboBoxStyle.DropDownList;
            role_list.FlatStyle = FlatStyle.Flat;
            role_list.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            role_list.FormattingEnabled = true;
            role_list.Location = new Point(44, 206);
            role_list.Name = "role_list";
            role_list.Size = new Size(178, 25);
            role_list.TabIndex = 9;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.IndianRed;
            btn_delete.FlatAppearance.BorderSize = 0;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(868, 427);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(103, 23);
            btn_delete.TabIndex = 10;
            btn_delete.Text = "Eliminar";
            btn_delete.UseVisualStyleBackColor = false;
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.Goldenrod;
            btn_update.FlatAppearance.BorderSize = 0;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(710, 427);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(103, 23);
            btn_update.TabIndex = 11;
            btn_update.Text = "Actualizar";
            btn_update.UseVisualStyleBackColor = false;
            // 
            // passImage
            // 
            passImage.Image = Properties.Resources.ojo1;
            passImage.Location = new Point(227, 143);
            passImage.Name = "passImage";
            passImage.Size = new Size(17, 27);
            passImage.SizeMode = PictureBoxSizeMode.Zoom;
            passImage.TabIndex = 12;
            passImage.TabStop = false;
            // 
            // UserManagment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1020, 498);
            Controls.Add(passImage);
            Controls.Add(btn_update);
            Controls.Add(btn_delete);
            Controls.Add(role_list);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_save);
            Controls.Add(data_grid);
            Controls.Add(txt_contrasenia);
            Controls.Add(txt_name);
            FormBorderStyle = FormBorderStyle.None;
            Name = "UserManagment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "UserManagment";
            ((System.ComponentModel.ISupportInitialize)data_grid).EndInit();
            ((System.ComponentModel.ISupportInitialize)passImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox txt_name;
        public TextBox txt_contrasenia;
        public DataGridView data_grid;
        public Button btn_save;
        private Label label1;
        private Label label2;
        private Label label3;
        public ComboBox role_list;
        public Button btn_delete;
        public Button btn_update;
        public PictureBox passImage;
    }
}