namespace Software_de_taquilla.Views.AdminViews
{
    partial class PuntosClientes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgv_puntosclientes = new System.Windows.Forms.DataGridView();
            this.Foto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puntos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_buscador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_IngresoS = new System.Windows.Forms.Button();
            this.btn_IngresoM = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_puntosclientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(62)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(34, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "Puntos acumulados";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgv_puntosclientes);
            this.panel1.Controls.Add(this.txt_buscador);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(109, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(605, 456);
            this.panel1.TabIndex = 2;
            // 
            // dgv_puntosclientes
            // 
            this.dgv_puntosclientes.AllowUserToOrderColumns = true;
            this.dgv_puntosclientes.BackgroundColor = System.Drawing.Color.White;
            this.dgv_puntosclientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_puntosclientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Foto,
            this.Nombre,
            this.Correo,
            this.Puntos});
            this.dgv_puntosclientes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_puntosclientes.Location = new System.Drawing.Point(0, 96);
            this.dgv_puntosclientes.Name = "dgv_puntosclientes";
            this.dgv_puntosclientes.RowHeadersWidth = 51;
            this.dgv_puntosclientes.RowTemplate.Height = 29;
            this.dgv_puntosclientes.Size = new System.Drawing.Size(605, 360);
            this.dgv_puntosclientes.TabIndex = 2;
            // 
            // Foto
            // 
            this.Foto.HeaderText = "Foto";
            this.Foto.MinimumWidth = 6;
            this.Foto.Name = "Foto";
            this.Foto.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Correo
            // 
            this.Correo.HeaderText = "Correo";
            this.Correo.MinimumWidth = 6;
            this.Correo.Name = "Correo";
            this.Correo.Width = 125;
            // 
            // Puntos
            // 
            this.Puntos.HeaderText = "Puntos";
            this.Puntos.MinimumWidth = 6;
            this.Puntos.Name = "Puntos";
            this.Puntos.Width = 125;
            // 
            // txt_buscador
            // 
            this.txt_buscador.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_buscador.Location = new System.Drawing.Point(26, 48);
            this.txt_buscador.Name = "txt_buscador";
            this.txt_buscador.Size = new System.Drawing.Size(561, 26);
            this.txt_buscador.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(20, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Puntos de clientes";
            // 
            // btn_IngresoS
            // 
            this.btn_IngresoS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(209)))), ((int)(((byte)(212)))));
            this.btn_IngresoS.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_IngresoS.Location = new System.Drawing.Point(731, 255);
            this.btn_IngresoS.Name = "btn_IngresoS";
            this.btn_IngresoS.Size = new System.Drawing.Size(159, 53);
            this.btn_IngresoS.TabIndex = 3;
            this.btn_IngresoS.Text = "Ingresos Semanales";
            this.btn_IngresoS.UseVisualStyleBackColor = false;
            // 
            // btn_IngresoM
            // 
            this.btn_IngresoM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(209)))), ((int)(((byte)(212)))));
            this.btn_IngresoM.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_IngresoM.Location = new System.Drawing.Point(732, 352);
            this.btn_IngresoM.Name = "btn_IngresoM";
            this.btn_IngresoM.Size = new System.Drawing.Size(158, 53);
            this.btn_IngresoM.TabIndex = 4;
            this.btn_IngresoM.Text = "Ingresos Mensuales";
            this.btn_IngresoM.UseVisualStyleBackColor = false;
            // 
            // PuntosClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(916, 562);
            this.Controls.Add(this.btn_IngresoM);
            this.Controls.Add(this.btn_IngresoS);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PuntosClientes";
            this.Text = "PuntosClientes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_puntosclientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private DataGridView dgv_puntosclientes;
        private DataGridViewTextBoxColumn Foto;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Puntos;
        private TextBox txt_buscador;
        private Label label2;
        private Button btn_IngresoS;
        private Button btn_IngresoM;
    }
}