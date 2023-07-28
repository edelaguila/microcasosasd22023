<<<<<<< HEAD
﻿namespace Prodeportes_admin
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            Bien = new Label();
            pnlLateral = new Panel();
            btnBitacora = new Button();
            btnEmpleado = new Button();
            btnJugador = new Button();
            btnEntrenador = new Button();
            btnEquipo = new Button();
            btnCampeonato = new Button();
            btnTablero = new Button();
            pnlAdmin = new Panel();
            label1 = new Label();
            pnlContenedor = new Panel();
            btnCerrar = new Button();
            pnlLateral.SuspendLayout();
            pnlAdmin.SuspendLayout();
            pnlContenedor.SuspendLayout();
            SuspendLayout();
            // 
            // Bien
            // 
            Bien.AutoSize = true;
            Bien.Location = new Point(446, 63);
            Bien.Name = "Bien";
            Bien.Size = new Size(50, 20);
            Bien.TabIndex = 1;
            Bien.Text = "label1";
            // 
            // pnlLateral
            // 
            pnlLateral.Controls.Add(btnBitacora);
            pnlLateral.Controls.Add(btnEmpleado);
            pnlLateral.Controls.Add(btnJugador);
            pnlLateral.Controls.Add(btnEntrenador);
            pnlLateral.Controls.Add(btnEquipo);
            pnlLateral.Controls.Add(btnCampeonato);
            pnlLateral.Controls.Add(btnTablero);
            pnlLateral.Controls.Add(pnlAdmin);
            pnlLateral.Dock = DockStyle.Left;
            pnlLateral.Location = new Point(0, 0);
            pnlLateral.Name = "pnlLateral";
            pnlLateral.Size = new Size(310, 1080);
            pnlLateral.TabIndex = 0;
            // 
            // btnBitacora
            // 
            btnBitacora.Dock = DockStyle.Bottom;
            btnBitacora.Location = new Point(0, 1040);
            btnBitacora.Name = "btnBitacora";
            btnBitacora.Size = new Size(310, 40);
            btnBitacora.TabIndex = 14;
            btnBitacora.Text = "Bitácora";
            btnBitacora.UseVisualStyleBackColor = true;
            btnBitacora.Click += btnBitacora_Click;
            // 
            // btnEmpleado
            // 
            btnEmpleado.Dock = DockStyle.Top;
            btnEmpleado.Location = new Point(0, 480);
            btnEmpleado.Name = "btnEmpleado";
            btnEmpleado.Size = new Size(310, 40);
            btnEmpleado.TabIndex = 13;
            btnEmpleado.Text = "Empleados";
            btnEmpleado.UseVisualStyleBackColor = true;
            btnEmpleado.Click += btnEmpleado_Click;
            // 
            // btnJugador
            // 
            btnJugador.Dock = DockStyle.Top;
            btnJugador.Location = new Point(0, 440);
            btnJugador.Name = "btnJugador";
            btnJugador.Size = new Size(310, 40);
            btnJugador.TabIndex = 12;
            btnJugador.Text = "Jugadores";
            btnJugador.UseVisualStyleBackColor = true;
            btnJugador.Click += btnJugador_Click;
            // 
            // btnEntrenador
            // 
            btnEntrenador.Dock = DockStyle.Top;
            btnEntrenador.Location = new Point(0, 400);
            btnEntrenador.Name = "btnEntrenador";
            btnEntrenador.Size = new Size(310, 40);
            btnEntrenador.TabIndex = 11;
            btnEntrenador.Text = "Entrenadores";
            btnEntrenador.UseVisualStyleBackColor = true;
            btnEntrenador.Click += btnEntrenador_Click;
            // 
            // btnEquipo
            // 
            btnEquipo.Dock = DockStyle.Top;
            btnEquipo.Location = new Point(0, 360);
            btnEquipo.Name = "btnEquipo";
            btnEquipo.Size = new Size(310, 40);
            btnEquipo.TabIndex = 10;
            btnEquipo.Text = "Equipos";
            btnEquipo.UseVisualStyleBackColor = true;
            btnEquipo.Click += btnEquipo_Click;
            // 
            // btnCampeonato
            // 
            btnCampeonato.Dock = DockStyle.Top;
            btnCampeonato.Location = new Point(0, 320);
            btnCampeonato.Name = "btnCampeonato";
            btnCampeonato.Size = new Size(310, 40);
            btnCampeonato.TabIndex = 9;
            btnCampeonato.Text = "Campeonatos";
            btnCampeonato.UseVisualStyleBackColor = true;
            btnCampeonato.Click += btnCampeonato_Click;
            // 
            // btnTablero
            // 
            btnTablero.Dock = DockStyle.Top;
            btnTablero.Location = new Point(0, 280);
            btnTablero.Name = "btnTablero";
            btnTablero.Size = new Size(310, 40);
            btnTablero.TabIndex = 8;
            btnTablero.Text = "Tablero";
            btnTablero.UseVisualStyleBackColor = true;
            btnTablero.Click += btnTablero_Click;
            // 
            // pnlAdmin
            // 
            pnlAdmin.Controls.Add(label1);
            pnlAdmin.Dock = DockStyle.Top;
            pnlAdmin.Location = new Point(0, 0);
            pnlAdmin.Name = "pnlAdmin";
            pnlAdmin.Size = new Size(310, 280);
            pnlAdmin.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(79, 9);
            label1.Name = "label1";
            label1.Size = new Size(164, 38);
            label1.TabIndex = 1;
            label1.Text = "Bienvenido";
            // 
            // pnlContenedor
            // 
            pnlContenedor.Controls.Add(btnCerrar);
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Location = new Point(310, 0);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1610, 1080);
            pnlContenedor.TabIndex = 1;
            // 
            // btnCerrar
            // 
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1554, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(53, 54);
            btnCerrar.TabIndex = 0;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 11, 11);
            ClientSize = new Size(1920, 1080);
            Controls.Add(pnlContenedor);
            Controls.Add(pnlLateral);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administración";
            pnlLateral.ResumeLayout(false);
            pnlAdmin.ResumeLayout(false);
            pnlAdmin.PerformLayout();
            pnlContenedor.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label Bien;
        private Panel pnlLateral;
        private Panel pnlContenedor;
        private Button btnCerrar;
        private Button btnBitacora;
        private Button btnEmpleado;
        private Button btnJugador;
        private Button btnEntrenador;
        private Button btnEquipo;
        private Button btnCampeonato;
        private Button btnTablero;
        private Panel pnlAdmin;
        private Label label1;
    }
=======
﻿namespace Prodeportes_admin
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            Bien = new Label();
            pnlLateral = new Panel();
            btnBitacora = new Button();
            btnEmpleado = new Button();
            btnJugador = new Button();
            btnEntrenador = new Button();
            btnEquipo = new Button();
            btnCampeonato = new Button();
            btnTablero = new Button();
            pnlAdmin = new Panel();
            label1 = new Label();
            pnlContenedor = new Panel();
            btnCerrar = new Button();
            pnlLateral.SuspendLayout();
            pnlAdmin.SuspendLayout();
            pnlContenedor.SuspendLayout();
            SuspendLayout();
            // 
            // Bien
            // 
            Bien.AutoSize = true;
            Bien.Location = new Point(446, 63);
            Bien.Name = "Bien";
            Bien.Size = new Size(50, 20);
            Bien.TabIndex = 1;
            Bien.Text = "label1";
            // 
            // pnlLateral
            // 
            pnlLateral.Controls.Add(btnBitacora);
            pnlLateral.Controls.Add(btnEmpleado);
            pnlLateral.Controls.Add(btnJugador);
            pnlLateral.Controls.Add(btnEntrenador);
            pnlLateral.Controls.Add(btnEquipo);
            pnlLateral.Controls.Add(btnCampeonato);
            pnlLateral.Controls.Add(btnTablero);
            pnlLateral.Controls.Add(pnlAdmin);
            pnlLateral.Dock = DockStyle.Left;
            pnlLateral.Location = new Point(0, 0);
            pnlLateral.Name = "pnlLateral";
            pnlLateral.Size = new Size(310, 1080);
            pnlLateral.TabIndex = 0;
            // 
            // btnBitacora
            // 
            btnBitacora.Dock = DockStyle.Bottom;
            btnBitacora.Location = new Point(0, 1040);
            btnBitacora.Name = "btnBitacora";
            btnBitacora.Size = new Size(310, 40);
            btnBitacora.TabIndex = 14;
            btnBitacora.Text = "Bitácora";
            btnBitacora.UseVisualStyleBackColor = true;
            btnBitacora.Click += btnBitacora_Click;
            // 
            // btnEmpleado
            // 
            btnEmpleado.Dock = DockStyle.Top;
            btnEmpleado.Location = new Point(0, 480);
            btnEmpleado.Name = "btnEmpleado";
            btnEmpleado.Size = new Size(310, 40);
            btnEmpleado.TabIndex = 13;
            btnEmpleado.Text = "Empleados";
            btnEmpleado.UseVisualStyleBackColor = true;
            btnEmpleado.Click += btnEmpleado_Click;
            // 
            // btnJugador
            // 
            btnJugador.Dock = DockStyle.Top;
            btnJugador.Location = new Point(0, 440);
            btnJugador.Name = "btnJugador";
            btnJugador.Size = new Size(310, 40);
            btnJugador.TabIndex = 12;
            btnJugador.Text = "Jugadores";
            btnJugador.UseVisualStyleBackColor = true;
            btnJugador.Click += btnJugador_Click;
            // 
            // btnEntrenador
            // 
            btnEntrenador.Dock = DockStyle.Top;
            btnEntrenador.Location = new Point(0, 400);
            btnEntrenador.Name = "btnEntrenador";
            btnEntrenador.Size = new Size(310, 40);
            btnEntrenador.TabIndex = 11;
            btnEntrenador.Text = "Entrenadores";
            btnEntrenador.UseVisualStyleBackColor = true;
            btnEntrenador.Click += btnEntrenador_Click;
            // 
            // btnEquipo
            // 
            btnEquipo.Dock = DockStyle.Top;
            btnEquipo.Location = new Point(0, 360);
            btnEquipo.Name = "btnEquipo";
            btnEquipo.Size = new Size(310, 40);
            btnEquipo.TabIndex = 10;
            btnEquipo.Text = "Equipos";
            btnEquipo.UseVisualStyleBackColor = true;
            btnEquipo.Click += btnEquipo_Click;
            // 
            // btnCampeonato
            // 
            btnCampeonato.Dock = DockStyle.Top;
            btnCampeonato.Location = new Point(0, 320);
            btnCampeonato.Name = "btnCampeonato";
            btnCampeonato.Size = new Size(310, 40);
            btnCampeonato.TabIndex = 9;
            btnCampeonato.Text = "Campeonatos";
            btnCampeonato.UseVisualStyleBackColor = true;
            btnCampeonato.Click += btnCampeonato_Click;
            // 
            // btnTablero
            // 
            btnTablero.Dock = DockStyle.Top;
            btnTablero.Location = new Point(0, 280);
            btnTablero.Name = "btnTablero";
            btnTablero.Size = new Size(310, 40);
            btnTablero.TabIndex = 8;
            btnTablero.Text = "Tablero";
            btnTablero.UseVisualStyleBackColor = true;
            btnTablero.Click += btnTablero_Click;
            // 
            // pnlAdmin
            // 
            pnlAdmin.Controls.Add(label1);
            pnlAdmin.Dock = DockStyle.Top;
            pnlAdmin.Location = new Point(0, 0);
            pnlAdmin.Name = "pnlAdmin";
            pnlAdmin.Size = new Size(310, 280);
            pnlAdmin.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(79, 9);
            label1.Name = "label1";
            label1.Size = new Size(164, 38);
            label1.TabIndex = 1;
            label1.Text = "Bienvenido";
            // 
            // pnlContenedor
            // 
            pnlContenedor.Controls.Add(btnCerrar);
            pnlContenedor.Dock = DockStyle.Fill;
            pnlContenedor.Location = new Point(310, 0);
            pnlContenedor.Name = "pnlContenedor";
            pnlContenedor.Size = new Size(1610, 1080);
            pnlContenedor.TabIndex = 1;
            // 
            // btnCerrar
            // 
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Image = (Image)resources.GetObject("btnCerrar.Image");
            btnCerrar.Location = new Point(1554, 3);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(53, 54);
            btnCerrar.TabIndex = 0;
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(11, 11, 11);
            ClientSize = new Size(1920, 1080);
            Controls.Add(pnlContenedor);
            Controls.Add(pnlLateral);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administración";
            pnlLateral.ResumeLayout(false);
            pnlAdmin.ResumeLayout(false);
            pnlAdmin.PerformLayout();
            pnlContenedor.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label Bien;
        private Panel pnlLateral;
        private Panel pnlContenedor;
        private Button btnCerrar;
        private Button btnBitacora;
        private Button btnEmpleado;
        private Button btnJugador;
        private Button btnEntrenador;
        private Button btnEquipo;
        private Button btnCampeonato;
        private Button btnTablero;
        private Panel pnlAdmin;
        private Label label1;
    }
>>>>>>> 2c8af600a16738343e5e8e7883032b3022314bcc
}