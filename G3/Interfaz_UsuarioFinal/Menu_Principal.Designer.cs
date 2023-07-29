
namespace Interfaz_UsuarioFinal
{
    partial class Menu_Principal
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pnl_Menu = new System.Windows.Forms.Panel();
            this.Btn_Tablero = new System.Windows.Forms.Button();
            this.Btn_Estadisticas = new System.Windows.Forms.Button();
            this.Btn_Tablas = new System.Windows.Forms.Button();
            this.Btn_Equipos = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(700, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Btn_Equipos);
            this.panel1.Controls.Add(this.Btn_Tablas);
            this.panel1.Controls.Add(this.Btn_Estadisticas);
            this.panel1.Controls.Add(this.Btn_Tablero);
            this.panel1.Location = new System.Drawing.Point(45, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 333);
            this.panel1.TabIndex = 1;
            // 
            // Pnl_Menu
            // 
            this.Pnl_Menu.Location = new System.Drawing.Point(231, 60);
            this.Pnl_Menu.Name = "Pnl_Menu";
            this.Pnl_Menu.Size = new System.Drawing.Size(554, 369);
            this.Pnl_Menu.TabIndex = 2;
            // 
            // Btn_Tablero
            // 
            this.Btn_Tablero.Location = new System.Drawing.Point(36, 146);
            this.Btn_Tablero.Name = "Btn_Tablero";
            this.Btn_Tablero.Size = new System.Drawing.Size(91, 27);
            this.Btn_Tablero.TabIndex = 0;
            this.Btn_Tablero.Text = "Tablero";
            this.Btn_Tablero.UseVisualStyleBackColor = true;
            this.Btn_Tablero.Click += new System.EventHandler(this.Btn_Tablero_Click);
            // 
            // Btn_Estadisticas
            // 
            this.Btn_Estadisticas.Location = new System.Drawing.Point(36, 179);
            this.Btn_Estadisticas.Name = "Btn_Estadisticas";
            this.Btn_Estadisticas.Size = new System.Drawing.Size(91, 27);
            this.Btn_Estadisticas.TabIndex = 1;
            this.Btn_Estadisticas.Text = "Estadisticas";
            this.Btn_Estadisticas.UseVisualStyleBackColor = true;
            this.Btn_Estadisticas.Click += new System.EventHandler(this.Btn_Estadisticas_Click);
            // 
            // Btn_Tablas
            // 
            this.Btn_Tablas.Location = new System.Drawing.Point(36, 212);
            this.Btn_Tablas.Name = "Btn_Tablas";
            this.Btn_Tablas.Size = new System.Drawing.Size(91, 27);
            this.Btn_Tablas.TabIndex = 2;
            this.Btn_Tablas.Text = "Tablas";
            this.Btn_Tablas.UseVisualStyleBackColor = true;
            this.Btn_Tablas.Click += new System.EventHandler(this.Btn_Tablas_Click);
            // 
            // Btn_Equipos
            // 
            this.Btn_Equipos.Location = new System.Drawing.Point(36, 245);
            this.Btn_Equipos.Name = "Btn_Equipos";
            this.Btn_Equipos.Size = new System.Drawing.Size(91, 27);
            this.Btn_Equipos.TabIndex = 3;
            this.Btn_Equipos.Text = "Equipos";
            this.Btn_Equipos.UseVisualStyleBackColor = true;
            this.Btn_Equipos.Click += new System.EventHandler(this.Btn_Equipos_Click);
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pnl_Menu);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu_Principal";
            this.Text = "Menu_Principal";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_Equipos;
        private System.Windows.Forms.Button Btn_Tablas;
        private System.Windows.Forms.Button Btn_Estadisticas;
        private System.Windows.Forms.Button Btn_Tablero;
        private System.Windows.Forms.Panel Pnl_Menu;
    }
}