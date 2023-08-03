namespace Software_de_taquilla.Views.AdminViews
{
    partial class ReportesMensuales
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
            panel1 = new Panel();
            combo_mes = new ComboBox();
            combo_filtro = new ComboBox();
            data_grid = new DataGridView();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)data_grid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(12, 62, 85);
            label1.Location = new Point(28, 36);
            label1.Name = "label1";
            label1.Size = new Size(292, 32);
            label1.TabIndex = 2;
            label1.Text = "Reportes Mensuales";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(combo_mes);
            panel1.Controls.Add(combo_filtro);
            panel1.Controls.Add(data_grid);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(12, 70);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(807, 369);
            panel1.TabIndex = 5;
            // 
            // combo_mes
            // 
            combo_mes.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_mes.FlatStyle = FlatStyle.System;
            combo_mes.FormattingEnabled = true;
            combo_mes.Items.AddRange(new object[] { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" });
            combo_mes.Location = new Point(521, 10);
            combo_mes.Margin = new Padding(3, 2, 3, 2);
            combo_mes.Name = "combo_mes";
            combo_mes.Size = new Size(133, 23);
            combo_mes.TabIndex = 6;
            // 
            // combo_filtro
            // 
            combo_filtro.DropDownStyle = ComboBoxStyle.DropDownList;
            combo_filtro.FlatStyle = FlatStyle.System;
            combo_filtro.FormattingEnabled = true;
            combo_filtro.Items.AddRange(new object[] { "Semana 1", "Semana 2", "Semana 3", "Semana 4" });
            combo_filtro.Location = new Point(671, 10);
            combo_filtro.Margin = new Padding(3, 2, 3, 2);
            combo_filtro.Name = "combo_filtro";
            combo_filtro.Size = new Size(133, 23);
            combo_filtro.TabIndex = 0;
            combo_filtro.SelectedIndexChanged += combo_filtro_SelectedIndexChanged;
            // 
            // data_grid
            // 
            data_grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            data_grid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            data_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            data_grid.Dock = DockStyle.Bottom;
            data_grid.Location = new Point(0, 46);
            data_grid.Name = "data_grid";
            data_grid.RowHeadersVisible = false;
            data_grid.RowHeadersWidth = 51;
            data_grid.RowTemplate.Height = 25;
            data_grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            data_grid.Size = new Size(807, 323);
            data_grid.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(12, 62, 85);
            label3.Location = new Point(19, 10);
            label3.Name = "label3";
            label3.Size = new Size(270, 19);
            label3.TabIndex = 4;
            label3.Text = "Peliculas Taquilleras Mensuales";
            // 
            // ReportesMensuales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(831, 450);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(831, 450);
            Name = "ReportesMensuales";
            Text = "ReportesMensuales";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)data_grid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label label3;
        private ComboBox combo_filtro;
        public DataGridView data_grid;
        private ComboBox combo_mes;
    }
}