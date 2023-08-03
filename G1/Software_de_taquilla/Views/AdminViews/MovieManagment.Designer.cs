namespace Software_de_taquilla.Views.AdminViews
{
    partial class MovieManagment
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
            btn_update = new Button();
            btn_delete = new Button();
            label3 = new Label();
            data_grid = new DataGridView();
            txt_duracion = new NumericUpDown();
            list_listing = new ComboBox();
            label4 = new Label();
            label5 = new Label();
            room_listing = new ComboBox();
            label2 = new Label();
            btn_save = new Button();
            txt_publico = new TextBox();
            txt_name = new TextBox();
            label1 = new Label();
            label6 = new Label();
            panel_picture = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)data_grid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txt_duracion).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_update
            // 
            btn_update.BackColor = Color.Goldenrod;
            btn_update.FlatAppearance.BorderSize = 0;
            btn_update.FlatStyle = FlatStyle.Flat;
            btn_update.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_update.ForeColor = Color.White;
            btn_update.Location = new Point(709, 463);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(103, 23);
            btn_update.TabIndex = 22;
            btn_update.Text = "Actualizar";
            btn_update.UseVisualStyleBackColor = false;
            // 
            // btn_delete
            // 
            btn_delete.BackColor = Color.IndianRed;
            btn_delete.FlatAppearance.BorderSize = 0;
            btn_delete.FlatStyle = FlatStyle.Flat;
            btn_delete.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_delete.ForeColor = Color.White;
            btn_delete.Location = new Point(864, 463);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(103, 23);
            btn_delete.TabIndex = 21;
            btn_delete.Text = "Eliminar";
            btn_delete.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(863, 30);
            label3.Name = "label3";
            label3.Size = new Size(62, 17);
            label3.TabIndex = 19;
            label3.Text = "Duración";
            // 
            // data_grid
            // 
            data_grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            data_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_grid.Location = new Point(296, 130);
            data_grid.Name = "data_grid";
            data_grid.RowHeadersVisible = false;
            data_grid.RowHeadersWidth = 51;
            data_grid.RowTemplate.Height = 25;
            data_grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_grid.Size = new Size(672, 320);
            data_grid.TabIndex = 15;
            // 
            // txt_duracion
            // 
            txt_duracion.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_duracion.Location = new Point(863, 50);
            txt_duracion.Name = "txt_duracion";
            txt_duracion.Size = new Size(120, 22);
            txt_duracion.TabIndex = 25;
            // 
            // list_listing
            // 
            list_listing.DropDownStyle = ComboBoxStyle.DropDownList;
            list_listing.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            list_listing.FormattingEnabled = true;
            list_listing.Location = new Point(698, 49);
            list_listing.Name = "list_listing";
            list_listing.Size = new Size(121, 25);
            list_listing.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(696, 31);
            label4.Name = "label4";
            label4.Size = new Size(65, 17);
            label4.TabIndex = 27;
            label4.Text = "Cartelera";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(518, 31);
            label5.Name = "label5";
            label5.Size = new Size(34, 17);
            label5.TabIndex = 30;
            label5.Text = "Sala";
            // 
            // room_listing
            // 
            room_listing.DropDownStyle = ComboBoxStyle.DropDownList;
            room_listing.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            room_listing.FormattingEnabled = true;
            room_listing.Location = new Point(520, 49);
            room_listing.Name = "room_listing";
            room_listing.Size = new Size(121, 25);
            room_listing.TabIndex = 29;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(263, 31);
            label2.Name = "label2";
            label2.Size = new Size(52, 17);
            label2.TabIndex = 18;
            label2.Text = "Publico";
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.SeaGreen;
            btn_save.FlatAppearance.BorderSize = 0;
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.Font = new Font("Century Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_save.ForeColor = Color.White;
            btn_save.Location = new Point(51, 427);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(178, 23);
            btn_save.TabIndex = 16;
            btn_save.Text = "Guardar";
            btn_save.UseVisualStyleBackColor = false;
            // 
            // txt_publico
            // 
            txt_publico.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_publico.Location = new Point(263, 49);
            txt_publico.Name = "txt_publico";
            txt_publico.Size = new Size(178, 26);
            txt_publico.TabIndex = 14;
            // 
            // txt_name
            // 
            txt_name.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            txt_name.Location = new Point(26, 49);
            txt_name.Name = "txt_name";
            txt_name.Size = new Size(178, 26);
            txt_name.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(26, 31);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 17;
            label1.Text = "Nombre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(23, 215);
            label6.Name = "label6";
            label6.Size = new Size(53, 17);
            label6.TabIndex = 31;
            label6.Text = "Imagen";
            // 
            // panel_picture
            // 
            panel_picture.AllowDrop = true;
            panel_picture.BackColor = Color.Silver;
            panel_picture.BackgroundImageLayout = ImageLayout.Zoom;
            panel_picture.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            panel_picture.Location = new Point(23, 235);
            panel_picture.Name = "panel_picture";
            panel_picture.Size = new Size(242, 154);
            panel_picture.TabIndex = 32;
            panel_picture.DragDrop += panel_picture_DragDrop;
            panel_picture.DragEnter += panel_picture_DragEnter;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txt_name);
            panel1.Controls.Add(txt_publico);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(list_listing);
            panel1.Controls.Add(room_listing);
            panel1.Controls.Add(txt_duracion);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(993, 101);
            panel1.TabIndex = 28;
            panel1.Paint += panel1_Paint;
            // 
            // MovieManagment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(993, 498);
            Controls.Add(label6);
            Controls.Add(panel_picture);
            Controls.Add(panel1);
            Controls.Add(btn_update);
            Controls.Add(btn_save);
            Controls.Add(btn_delete);
            Controls.Add(data_grid);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MovieManagment";
            Text = "MovieManagment";
            ((System.ComponentModel.ISupportInitialize)data_grid).EndInit();
            ((System.ComponentModel.ISupportInitialize)txt_duracion).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Button btn_update;
        public Button btn_delete;
        private Label label3;
        public DataGridView data_grid;
        private Label label4;
        private Label label5;
        public NumericUpDown txt_duracion;
        public ComboBox list_listing;
        public ComboBox room_listing;
        private Label label2;
        public Button btn_save;
        public TextBox txt_publico;
        public TextBox txt_name;
        private Label label1;
        private Label label6;
        public Panel panel_picture;
        private Panel panel1;
    }
}