namespace Software_de_taquilla.Views.AdminViews
{
    partial class Horarios
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
            btn_delete = new Button();
            data_grid = new DataGridView();
            label4 = new Label();
            label1 = new Label();
            combo_movie = new ComboBox();
            label2 = new Label();
            txt_hi = new TextBox();
            txt_hf = new TextBox();
            btn_save = new Button();
            ((System.ComponentModel.ISupportInitialize)data_grid).BeginInit();
            SuspendLayout();
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.IndianRed;
            btn_delete.FlatAppearance.BorderSize = 0;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(870, 435);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(103, 23);
            btn_delete.TabIndex = 24;
            btn_delete.Text = "Eliminar";
            btn_delete.UseVisualStyleBackColor = false;
            // 
            // data_grid
            // 
            data_grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            data_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_grid.Location = new Point(199, 80);
            data_grid.Name = "data_grid";
            data_grid.RowHeadersVisible = false;
            data_grid.RowHeadersWidth = 51;
            data_grid.RowTemplate.Height = 25;
            data_grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_grid.Size = new Size(766, 315);
            data_grid.TabIndex = 23;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(24, 132);
            label4.Name = "label4";
            label4.Size = new Size(71, 17);
            label4.TabIndex = 29;
            label4.Text = "Hora Inicio";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 211);
            label1.Name = "label1";
            label1.Size = new Size(55, 17);
            label1.TabIndex = 31;
            label1.Text = "Hora Fin";
            // 
            // combo_movie
            // 
            combo_movie.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_movie.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            combo_movie.FormattingEnabled = true;
            combo_movie.Location = new Point(30, 316);
            combo_movie.Name = "combo_movie";
            combo_movie.Size = new Size(142, 25);
            combo_movie.TabIndex = 32;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(28, 298);
            label2.Name = "label2";
            label2.Size = new Size(55, 17);
            label2.TabIndex = 33;
            label2.Text = "Pelicula";
            // 
            // txt_hi
            // 
            txt_hi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_hi.Location = new Point(26, 152);
            txt_hi.Name = "txt_hi";
            txt_hi.Size = new Size(146, 26);
            txt_hi.TabIndex = 34;
            // 
            // txt_hf
            // 
            txt_hf.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_hf.Location = new Point(26, 235);
            txt_hf.Name = "txt_hf";
            txt_hf.Size = new Size(146, 26);
            txt_hf.TabIndex = 35;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.SeaGreen;
            btn_save.FlatAppearance.BorderSize = 0;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_save.ForeColor = Color.White;
            btn_save.Location = new Point(30, 371);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(142, 23);
            btn_save.TabIndex = 36;
            btn_save.Text = "Guardar";
            btn_save.UseVisualStyleBackColor = false;
            // 
            // Horarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 498);
            Controls.Add(btn_save);
            Controls.Add(txt_hf);
            Controls.Add(txt_hi);
            Controls.Add(combo_movie);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(btn_delete);
            Controls.Add(data_grid);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Horarios";
            Text = "Horarios";
            ((System.ComponentModel.ISupportInitialize)data_grid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Button btn_delete;
        public DataGridView data_grid;
        private Label label4;
        private Label label1;
        public ComboBox combo_movie;
        private Label label2;
        public TextBox txt_hi;
        public TextBox txt_hf;
        public Button btn_save;
    }
}