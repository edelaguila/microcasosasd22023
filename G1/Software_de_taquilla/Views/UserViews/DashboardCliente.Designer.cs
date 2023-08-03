namespace Software_de_taquilla.Views.UserViews
{
    partial class DashboardCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardCliente));
            PanelMenu = new Panel();
            btnMenuAyuda = new Button();
            btnCobros = new Button();
            btnCartelera = new Button();
            btnInicio = new Button();
            PanelDatos = new Panel();
            lblEstado = new Label();
            lblPerfil = new Label();
            PctPerfil = new PictureBox();
            label1 = new Label();
            panel_container = new Panel();
            pic_exit = new PictureBox();
            label2 = new Label();
            PanelMenu.SuspendLayout();
            PanelDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PctPerfil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pic_exit).BeginInit();
            SuspendLayout();
            // 
            // PanelMenu
            // 
            PanelMenu.BackColor = Color.FromArgb(12, 62, 85);
            PanelMenu.Controls.Add(label2);
            PanelMenu.Controls.Add(pic_exit);
            PanelMenu.Controls.Add(btnMenuAyuda);
            PanelMenu.Controls.Add(btnCobros);
            PanelMenu.Controls.Add(btnCartelera);
            PanelMenu.Controls.Add(btnInicio);
            PanelMenu.Controls.Add(PanelDatos);
            PanelMenu.Dock = DockStyle.Left;
            PanelMenu.Location = new Point(0, 0);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(227, 484);
            PanelMenu.TabIndex = 0;
            // 
            // btnMenuAyuda
            // 
            btnMenuAyuda.Dock = DockStyle.Top;
            btnMenuAyuda.FlatAppearance.BorderSize = 0;
            btnMenuAyuda.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 171, 218);
            btnMenuAyuda.FlatAppearance.MouseOverBackColor = Color.FromArgb(36, 171, 218);
            btnMenuAyuda.FlatStyle = FlatStyle.Flat;
            btnMenuAyuda.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenuAyuda.ForeColor = SystemColors.Control;
            btnMenuAyuda.Image = (Image)resources.GetObject("btnMenuAyuda.Image");
            btnMenuAyuda.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuAyuda.Location = new Point(0, 274);
            btnMenuAyuda.Name = "btnMenuAyuda";
            btnMenuAyuda.Size = new Size(227, 45);
            btnMenuAyuda.TabIndex = 5;
            btnMenuAyuda.Text = "Menú de ayuda";
            btnMenuAyuda.UseVisualStyleBackColor = true;
            btnMenuAyuda.Click += btnMenuAyuda_Click;
            // 
            // btnCobros
            // 
            btnCobros.Dock = DockStyle.Top;
            btnCobros.FlatAppearance.BorderSize = 0;
            btnCobros.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 171, 218);
            btnCobros.FlatAppearance.MouseOverBackColor = Color.FromArgb(36, 171, 218);
            btnCobros.FlatStyle = FlatStyle.Flat;
            btnCobros.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCobros.ForeColor = SystemColors.Control;
            btnCobros.Image = (Image)resources.GetObject("btnCobros.Image");
            btnCobros.ImageAlign = ContentAlignment.MiddleLeft;
            btnCobros.Location = new Point(0, 229);
            btnCobros.Name = "btnCobros";
            btnCobros.Size = new Size(227, 45);
            btnCobros.TabIndex = 4;
            btnCobros.Text = "Cobros";
            btnCobros.UseVisualStyleBackColor = true;
            btnCobros.Click += btnCobros_Click;
            // 
            // btnCartelera
            // 
            btnCartelera.Dock = DockStyle.Top;
            btnCartelera.FlatAppearance.BorderSize = 0;
            btnCartelera.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 171, 218);
            btnCartelera.FlatAppearance.MouseOverBackColor = Color.FromArgb(36, 171, 218);
            btnCartelera.FlatStyle = FlatStyle.Flat;
            btnCartelera.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCartelera.ForeColor = SystemColors.Control;
            btnCartelera.Image = (Image)resources.GetObject("btnCartelera.Image");
            btnCartelera.ImageAlign = ContentAlignment.MiddleLeft;
            btnCartelera.Location = new Point(0, 184);
            btnCartelera.Name = "btnCartelera";
            btnCartelera.Size = new Size(227, 45);
            btnCartelera.TabIndex = 3;
            btnCartelera.Text = "Cartelera";
            btnCartelera.UseVisualStyleBackColor = true;
            btnCartelera.Click += btnCartelera_Click;
            // 
            // btnInicio
            // 
            btnInicio.Dock = DockStyle.Top;
            btnInicio.FlatAppearance.BorderSize = 0;
            btnInicio.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 171, 218);
            btnInicio.FlatAppearance.MouseOverBackColor = Color.FromArgb(36, 171, 218);
            btnInicio.FlatStyle = FlatStyle.Flat;
            btnInicio.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnInicio.ForeColor = SystemColors.Control;
            btnInicio.Image = (Image)resources.GetObject("btnInicio.Image");
            btnInicio.ImageAlign = ContentAlignment.MiddleLeft;
            btnInicio.Location = new Point(0, 139);
            btnInicio.Name = "btnInicio";
            btnInicio.Size = new Size(227, 45);
            btnInicio.TabIndex = 2;
            btnInicio.Text = "Inicio";
            btnInicio.UseVisualStyleBackColor = true;
            // 
            // PanelDatos
            // 
            PanelDatos.Controls.Add(lblEstado);
            PanelDatos.Controls.Add(lblPerfil);
            PanelDatos.Controls.Add(PctPerfil);
            PanelDatos.Controls.Add(label1);
            PanelDatos.Dock = DockStyle.Top;
            PanelDatos.Location = new Point(0, 0);
            PanelDatos.Name = "PanelDatos";
            PanelDatos.Size = new Size(227, 139);
            PanelDatos.TabIndex = 1;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEstado.ForeColor = Color.FromArgb(43, 105, 130);
            lblEstado.Location = new Point(124, 99);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(52, 17);
            lblEstado.TabIndex = 3;
            lblEstado.Text = "Estado";
            // 
            // lblPerfil
            // 
            lblPerfil.AutoSize = true;
            lblPerfil.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPerfil.ForeColor = SystemColors.Control;
            lblPerfil.Location = new Point(124, 74);
            lblPerfil.Name = "lblPerfil";
            lblPerfil.Size = new Size(54, 17);
            lblPerfil.TabIndex = 2;
            lblPerfil.Text = "Usuario";
            // 
            // PctPerfil
            // 
            PctPerfil.Location = new Point(49, 65);
            PctPerfil.Name = "PctPerfil";
            PctPerfil.Size = new Size(66, 57);
            PctPerfil.TabIndex = 1;
            PctPerfil.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bookman Old Style", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(35, 25);
            label1.Name = "label1";
            label1.Size = new Size(152, 19);
            label1.TabIndex = 0;
            label1.Text = "MACRO CINEMA";
            // 
            // panel_container
            // 
            panel_container.BackColor = Color.White;
            panel_container.Dock = DockStyle.Fill;
            panel_container.Location = new Point(227, 0);
            panel_container.Name = "panel_container";
            panel_container.Size = new Size(790, 484);
            panel_container.TabIndex = 3;
            // 
            // pic_exit
            // 
            pic_exit.Image = (Image)resources.GetObject("pic_exit.Image");
            pic_exit.Location = new Point(202, 453);
            pic_exit.Name = "pic_exit";
            pic_exit.Size = new Size(19, 19);
            pic_exit.SizeMode = PictureBoxSizeMode.Zoom;
            pic_exit.TabIndex = 6;
            pic_exit.TabStop = false;
            pic_exit.Click += pic_exit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(167, 455);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 7;
            label2.Text = "Salir";
            // 
            // DashboardCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 484);
            Controls.Add(panel_container);
            Controls.Add(PanelMenu);
            Name = "DashboardCliente";
            Text = "DashboardCliente";
            PanelMenu.ResumeLayout(false);
            PanelMenu.PerformLayout();
            PanelDatos.ResumeLayout(false);
            PanelDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PctPerfil).EndInit();
            ((System.ComponentModel.ISupportInitialize)pic_exit).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelMenu;
        private Panel PanelDatos;
        private Label label1;
        private PictureBox PctPerfil;
        private Label lblPerfil;
        private Label lblEstado;
        private Button btnInicio;
        private Button btnMenuAyuda;
        private Button btnCobros;
        private Button btnCartelera;
        private Panel panel_container;
        private PictureBox pic_exit;
        private Label label2;
    }
}