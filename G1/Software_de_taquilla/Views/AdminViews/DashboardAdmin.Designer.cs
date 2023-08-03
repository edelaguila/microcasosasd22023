namespace Software_de_taquilla.Views.AdminViews
{
    partial class DashboardAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardAdmin));
            PanelMenu = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            btn_peliculas = new Button();
            btn_usuarios = new Button();
            btnMenuAyuda = new Button();
            btn_reportes = new Button();
            btn_inicio = new Button();
            PanelDatos = new Panel();
            lblEstado = new Label();
            lblPerfil = new Label();
            Pic_Perfil = new PictureBox();
            label1 = new Label();
            panel_container = new Panel();
            PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            PanelDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_Perfil).BeginInit();
            SuspendLayout();
            // 
            // PanelMenu
            // 
            PanelMenu.AutoScroll = true;
            PanelMenu.BackColor = Color.FromArgb(12, 62, 85);
            PanelMenu.Controls.Add(label2);
            PanelMenu.Controls.Add(pictureBox1);
            PanelMenu.Controls.Add(btn_peliculas);
            PanelMenu.Controls.Add(btn_usuarios);
            PanelMenu.Controls.Add(btnMenuAyuda);
            PanelMenu.Controls.Add(btn_reportes);
            PanelMenu.Controls.Add(btn_inicio);
            PanelMenu.Controls.Add(PanelDatos);
            PanelMenu.Dock = DockStyle.Left;
            PanelMenu.Location = new Point(0, 0);
            PanelMenu.Name = "PanelMenu";
            PanelMenu.Size = new Size(239, 498);
            PanelMenu.TabIndex = 1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(181, 476);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 11;
            label2.Text = "Salir";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(214, 474);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(19, 19);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_1;
            // 
            // btn_peliculas
            // 
            btn_peliculas.Dock = DockStyle.Top;
            btn_peliculas.FlatAppearance.BorderSize = 0;
            btn_peliculas.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 171, 218);
            btn_peliculas.FlatAppearance.MouseOverBackColor = Color.FromArgb(36, 171, 218);
            btn_peliculas.FlatStyle = FlatStyle.Flat;
            btn_peliculas.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_peliculas.ForeColor = SystemColors.Control;
            btn_peliculas.Image = Properties.Resources.movies;
            btn_peliculas.ImageAlign = ContentAlignment.MiddleLeft;
            btn_peliculas.Location = new Point(0, 319);
            btn_peliculas.Name = "btn_peliculas";
            btn_peliculas.Padding = new Padding(60, 0, 0, 0);
            btn_peliculas.Size = new Size(239, 45);
            btn_peliculas.TabIndex = 9;
            btn_peliculas.Text = "    Peliculas";
            btn_peliculas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_peliculas.UseVisualStyleBackColor = true;
            btn_peliculas.Click += btn_peliculas_Click;
            // 
            // btn_usuarios
            // 
            btn_usuarios.Dock = DockStyle.Top;
            btn_usuarios.FlatAppearance.BorderSize = 0;
            btn_usuarios.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 171, 218);
            btn_usuarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(36, 171, 218);
            btn_usuarios.FlatStyle = FlatStyle.Flat;
            btn_usuarios.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_usuarios.ForeColor = SystemColors.Control;
            btn_usuarios.Image = Properties.Resources.users2;
            btn_usuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btn_usuarios.Location = new Point(0, 274);
            btn_usuarios.Name = "btn_usuarios";
            btn_usuarios.Padding = new Padding(60, 0, 0, 0);
            btn_usuarios.Size = new Size(239, 45);
            btn_usuarios.TabIndex = 7;
            btn_usuarios.Text = "   Usuarios";
            btn_usuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_usuarios.UseVisualStyleBackColor = true;
            btn_usuarios.Click += btn_usuarios_Click;
            // 
            // btnMenuAyuda
            // 
            btnMenuAyuda.Dock = DockStyle.Top;
            btnMenuAyuda.FlatAppearance.BorderSize = 0;
            btnMenuAyuda.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 171, 218);
            btnMenuAyuda.FlatAppearance.MouseOverBackColor = Color.FromArgb(36, 171, 218);
            btnMenuAyuda.FlatStyle = FlatStyle.Flat;
            btnMenuAyuda.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnMenuAyuda.ForeColor = SystemColors.Control;
            btnMenuAyuda.Image = (Image)resources.GetObject("btnMenuAyuda.Image");
            btnMenuAyuda.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuAyuda.Location = new Point(0, 229);
            btnMenuAyuda.Name = "btnMenuAyuda";
            btnMenuAyuda.Padding = new Padding(60, 0, 0, 0);
            btnMenuAyuda.Size = new Size(239, 45);
            btnMenuAyuda.TabIndex = 5;
            btnMenuAyuda.Text = "Menú de ayuda";
            btnMenuAyuda.UseVisualStyleBackColor = true;
            btnMenuAyuda.Click += btnMenuAyuda_Click;
            // 
            // btn_reportes
            // 
            btn_reportes.Dock = DockStyle.Top;
            btn_reportes.FlatAppearance.BorderSize = 0;
            btn_reportes.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 171, 218);
            btn_reportes.FlatAppearance.MouseOverBackColor = Color.FromArgb(36, 171, 218);
            btn_reportes.FlatStyle = FlatStyle.Flat;
            btn_reportes.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_reportes.ForeColor = SystemColors.Control;
            btn_reportes.Image = Properties.Resources.report;
            btn_reportes.ImageAlign = ContentAlignment.MiddleLeft;
            btn_reportes.Location = new Point(0, 184);
            btn_reportes.Name = "btn_reportes";
            btn_reportes.Padding = new Padding(60, 0, 0, 0);
            btn_reportes.Size = new Size(239, 45);
            btn_reportes.TabIndex = 3;
            btn_reportes.Text = "   Reportes";
            btn_reportes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_reportes.UseVisualStyleBackColor = true;
            btn_reportes.Click += btn_reportes_Click;
            // 
            // btn_inicio
            // 
            btn_inicio.Dock = DockStyle.Top;
            btn_inicio.FlatAppearance.BorderSize = 0;
            btn_inicio.FlatAppearance.MouseDownBackColor = Color.FromArgb(36, 171, 218);
            btn_inicio.FlatAppearance.MouseOverBackColor = Color.FromArgb(36, 171, 218);
            btn_inicio.FlatStyle = FlatStyle.Flat;
            btn_inicio.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btn_inicio.ForeColor = SystemColors.Control;
            btn_inicio.Image = (Image)resources.GetObject("btn_inicio.Image");
            btn_inicio.ImageAlign = ContentAlignment.MiddleLeft;
            btn_inicio.Location = new Point(0, 139);
            btn_inicio.Name = "btn_inicio";
            btn_inicio.Padding = new Padding(60, 0, 0, 0);
            btn_inicio.Size = new Size(239, 45);
            btn_inicio.TabIndex = 2;
            btn_inicio.Text = "    Horarios";
            btn_inicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            btn_inicio.UseVisualStyleBackColor = true;
            btn_inicio.Click += btn_inicio_Click;
            // 
            // PanelDatos
            // 
            PanelDatos.BackColor = Color.FromArgb(12, 62, 85);
            PanelDatos.Controls.Add(lblEstado);
            PanelDatos.Controls.Add(lblPerfil);
            PanelDatos.Controls.Add(Pic_Perfil);
            PanelDatos.Controls.Add(label1);
            PanelDatos.Dock = DockStyle.Top;
            PanelDatos.Location = new Point(0, 0);
            PanelDatos.Name = "PanelDatos";
            PanelDatos.Size = new Size(239, 139);
            PanelDatos.TabIndex = 1;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblEstado.ForeColor = Color.FromArgb(43, 105, 130);
            lblEstado.Location = new Point(124, 99);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(44, 15);
            lblEstado.TabIndex = 3;
            lblEstado.Text = "Estado";
            // 
            // lblPerfil
            // 
            lblPerfil.AutoSize = true;
            lblPerfil.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            lblPerfil.ForeColor = SystemColors.Control;
            lblPerfil.Location = new Point(124, 74);
            lblPerfil.Name = "lblPerfil";
            lblPerfil.Size = new Size(84, 15);
            lblPerfil.TabIndex = 2;
            lblPerfil.Text = "Administrador";
            // 
            // Pic_Perfil
            // 
            Pic_Perfil.Location = new Point(49, 65);
            Pic_Perfil.Name = "Pic_Perfil";
            Pic_Perfil.Size = new Size(66, 57);
            Pic_Perfil.TabIndex = 1;
            Pic_Perfil.TabStop = false;
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
            panel_container.Dock = DockStyle.Fill;
            panel_container.Location = new Point(239, 0);
            panel_container.Name = "panel_container";
            panel_container.Size = new Size(995, 498);
            panel_container.TabIndex = 2;
            // 
            // DashboardAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1234, 498);
            Controls.Add(panel_container);
            Controls.Add(PanelMenu);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(832, 458);
            Name = "DashboardAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashboardAdmin";
            PanelMenu.ResumeLayout(false);
            PanelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            PanelDatos.ResumeLayout(false);
            PanelDatos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Pic_Perfil).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel PanelMenu;
        private Button btn_inicio;
        private Panel PanelDatos;
        private Label lblEstado;
        private Label lblPerfil;
        private PictureBox Pic_Perfil;
        private Label label1;
        private Button btn_usuarios;
        private Button btnMenuAyuda;
        private Button btn_reportes;
        private Panel panel_container;
        private Button btn_peliculas;
        private Label label2;
        private PictureBox pictureBox1;
    }
}